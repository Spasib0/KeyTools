using KeyCheckGui.Dialogs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace KeyCheckGui
{
    public partial class KeyTools : Form
    {
        public static HttpClient Client => userClient;

        public Content Content { get => _currentData.Content; }

        private static readonly HttpClient userClient = new HttpClient();

        private readonly string[] _servers = new string[] { "https://nau-mag.com/", "https://savanto.me/" };
        private string CurrentServer => serversList.Text;

        private Dictionary<string, string> _tokens = new Dictionary<string, string>();
        private bool TokenAvalible => _tokens != null && _tokens.TryGetValue(CurrentServer, out string token) && !string.IsNullOrEmpty(token);

        

        private readonly SavedData savedData = new SavedData();

        private readonly KeyToolsDataControl _currentData;

        private AuthDialog authDialog;

        private string Key => keyField.Text;
        private string Product => productBox.Text;

        private string ResultGroupText => string.Format("Check [{0}] for [{1}]", Key, Product);
        
        public string KeyUrl => string.Format("{0}pub/school", CurrentServer);
        private string UserDataUrl => string.Format("{0}pub/school/user/{1}", CurrentServer, Key);


        public KeyTools()
        {
            InitializeComponent();
            InitServersBox();
            productBox.Items.AddRange(Enum.GetNames(typeof(StatisticsProduct)));
            _currentData = new KeyToolsDataControl(this);
            UpdateAuth();
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
            keyField.Text = "naura";
            updateDevicesButton.Select();
            //////////////////////////////////////////////
            UpdateAuth();
        }

        private void UpdateClientHeaders()
        {
            userClient.DefaultRequestHeaders.Clear();

            if (TokenAvalible)
                userClient.DefaultRequestHeaders.Add("Authorization", _tokens[CurrentServer]);
        }

        private void OnCheckKey(object sender, EventArgs e)
        {
            var toSend = JsonSerializer.Serialize(new KeyRequest(Product, Key, _currentData.SelectedHardware));
            var response = userClient.PostAsync(KeyUrl, new StringContent(toSend, Encoding.UTF8, "application/json")).Result;

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
                authDialog = new AuthDialog(CurrentServer, OnAuth, savedData);
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
            var response = userClient.GetAsync(UserDataUrl).Result;
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
        }

        private void SwitchUpdateDeviceButton(bool state)
        {
            updateDevicesButton.Visible = state;
            clearDevicesButton.Visible = !state;
            keyField.Enabled = state;
        }

        internal void SetSelectedDeviceToken()
        {
            var token = _currentData.SelectedHardware.token;
            userClient.DefaultRequestHeaders.Clear();
            userClient.DefaultRequestHeaders.Add("Authorization", token);
            userClient.DefaultRequestHeaders.Add("auth-type", "OAUTH");
        }

        internal string DownloadJson(string url)
        {
            var request = userClient.GetAsync(CurrentServer + url).Result;
            using var reader = new StreamReader(request.Content.ReadAsStreamAsync().Result);
            return reader.ReadToEnd();
        }


        private class KeyRequest
        {
            public KeyRequest(string productName, string key, UserHardware userHardware)
            {
                username = key;
                password = "";
                product = productName;
                version = 0;
                hardware = new Hardware(userHardware);
                master = false;
                isTeacher = false;
            }

            public string username { get; set; }
            public string password { get; set; }
            public string product { get; set; }
            public int version { get; set; }
            public Hardware hardware { get; set; }
            public bool master { get; set; }
            public bool isTeacher { get; set; }
        }

        private class KeyResponse
        {
            public string value { get; set; }
            public string details { get; set; }
            public int delay { get; set; }
        }
    }
}

