using KeyTools.Classes;
using KeyTools.Dialogs;
using KeyTools.Responces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace KeyTools
{
    public partial class KeyTools : Form
    {
        public KeyToolsClient Client => _userClient;

        public Content Content { get => _currentData.Content; }

        private KeyToolsClient _userClient;


        private readonly string[] _servers = new string[] { "https://nau-mag.com/", "https://savanto.me/" };
        private string CurrentServer => serversList.Text;

        private Dictionary<string, string> _tokens = new Dictionary<string, string>();
        private bool TokenAvalible => _tokens != null && _tokens.TryGetValue(CurrentServer, out string token) && !string.IsNullOrEmpty(token);

        

        private readonly SavedData savedData = new SavedData();

        private readonly KeyToolsDataControl _currentData;

        private AuthDialog authDialog;
        private string currentProductToken;

        private string Key => keyField.Text;
        private string Product => productBox.Text;

        private string ResultGroupText => string.Format("Check [{0}] for [{1}]", Key, Product);
        
        public string KeyUrl => string.Format("{0}pub/school", CurrentServer);
        private string UserDataUrl => string.Format("{0}pub/school/user/{1}", CurrentServer, Key);


        public KeyTools()
        {
            InitializeComponent();
            _userClient = new KeyToolsClient(serversList);
            InitServersBox();
            productBox.Items.AddRange(Enum.GetNames(typeof(StatisticsProduct)));
            _currentData = new KeyToolsDataControl(this);
            UpdateAuth();
            lessonsTests.SetClient(_userClient);
        }

        private void InitServersBox()
        {
            serversList.Items.AddRange(_servers);
            serversList.SelectedIndex = 0;
        }

        private void UpdateAuth()
        {
            SetButtonState(authorizationButton, !TokenAvalible, authIcon);
            UpdateClientHeaders();
        }

        private void SetButtonState(Button button, bool state, Label icon = null)
        {
            button.Enabled = state;
            AcceptButton = state ? button : null;

            if (icon != null)
            {
                icon.Text = state ?  "X" : "✓";
                icon.ForeColor = state ? Color.Red : Color.Green;
            }
        }
        
        private void SetStatusIcon(bool state)
        {
            statusIcon.Text = state ? "OK" : "FAIL";
            statusIcon.ForeColor = state ? Color.Green : Color.Red;
        }

        private void SetErrorLabels(bool state, string text)
        {
            errorText.Visible = state;
            errorText.Text = text;
        }

        private void OnAuth(string token)
        {
            _tokens[CurrentServer] = token;
            //////////////////////////////////////////////
            keyField.Text = "Moderator";
            updateDevicesButton.Select();
            //////////////////////////////////////////////
            UpdateAuth();
        }

        private void UpdateClientHeaders()
        {
            _userClient.DefaultRequestHeaders.Clear();

            if (TokenAvalible)
                _userClient.DefaultRequestHeaders.Add("Authorization", _tokens[CurrentServer]);
        }

        private void OnCheckKey(object sender, EventArgs e)
        {
            CheckKey();
        }

        private void CheckKey()
        {
            var toSend = JsonSerializer.Serialize(new KeyRequest(Product, Key, _currentData.SelectedHardware));
            var response = _userClient.PostAsync(KeyUrl, new StringContent(toSend, Encoding.UTF8, "application/json")).Result; //todo убрать внутрь клиента

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.StatusCode.ToString(), "KEY_CHEK_ERROR", MessageBoxButtons.OK);
                OnAuth(null);
            }
            else
            {
                var res = response.Content.ReadAsStringAsync().Result;
                var keyResponse = JsonSerializer.Deserialize<KeyResponse>(res);
                SetCheckResult(keyResponse.value, keyResponse.details);
                currentProductToken = keyResponse.auth.token;
            }
        }

        private void SetCheckResult(string value, string text)
        {
            keyResultGroup.Text = ResultGroupText;

            bool isOk = value == "ok";

            SetStatusIcon(isOk);
            SetErrorLabels(!isOk, text);
        }

        private void OnChangeServer(object sender, EventArgs e)
        {
            if (authDialog != null)
            {
                authDialog.Close();
            }

            UpdateAuth();
        }

        private void OnAuthorizationClick(object sender, EventArgs e)
        {
            if (authDialog == null || !authDialog.CanFocus)
            {
                authDialog = new AuthDialog(Client, OnAuth, savedData);
                authDialog.Show();
            }
            else
            {
                authDialog.Focus();
            }
        }

        private void OnKeyChanged(object sender, EventArgs e)
        {
            SetButtonState(updateDevicesButton, TokenAvalible && !string.IsNullOrEmpty(Key));
        }

        private void OnUpdateDevicesClick(object sender, EventArgs e)
        {
            var response = _userClient.GetAsync(UserDataUrl).Result;//todo убрать внутрь клиента
            
            SetButtonState(checkButton, response.IsSuccessStatusCode);

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.StatusCode.ToString(), "UPDATE_DEVICES_ERROR", MessageBoxButtons.OK);
                OnAuth(null);
            }
            else
            {
                var userData = JsonSerializer.DeserializeAsync<UserData>(response.Content.ReadAsStreamAsync().Result).Result;

                _currentData.UpdateDevices(userData.user.hardwares);

                SwitchUpdateDeviceButton(false);
            }
        }

        private void OnClearDevicesButton_Click(object sender, EventArgs e)
        {
            SwitchUpdateDeviceButton(true);
            ClearDevices();

        }

        private void SwitchUpdateDeviceButton(bool state)
        {
            updateDevicesButton.Visible = state;
            clearDevicesButton.Visible = !state;
            keyField.Enabled = state;
        }

        private void ClearDevices()
        {
            _currentData.ClearDevices();
            UpdateAuth();
        }

        internal void SetSelectedProductToken()
        {
            if(currentProductToken == null)
            {
                CheckKey();
            }

            _userClient.DefaultRequestHeaders.Clear();
            _userClient.DefaultRequestHeaders.Add("Authorization", currentProductToken);
            _userClient.DefaultRequestHeaders.Add("auth-type", "OAUTH");
        }

        internal void SetSelectedDeviceToken()
        {
            var token = _currentData.SelectedHardware.token;
            _userClient.DefaultRequestHeaders.Clear();
            _userClient.DefaultRequestHeaders.Add("Authorization", token);
            _userClient.DefaultRequestHeaders.Add("auth-type", "OAUTH");
        }

        private void TabControlSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 1:
                    SetSelectedProductToken();
                    lessonsTests.Update(_currentData.SelectedHardwareProducts);
                    break;
                default:
                    SetSelectedDeviceToken();
                    break;
            }
        }
    }
}

