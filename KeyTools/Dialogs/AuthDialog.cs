using KeyTools.Classes;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;



namespace KeyCheckGui
{
    public partial class AuthDialog : Form
    {
        private string login;
        private string password;
        private KeyToolsClient _client;
        private Action<string> _onAuth;
        private readonly SavedData _savedData;
        
        private string Url => Text + AUTH_URL;
        private const string AUTH_ERROR = "Не удалось авторизоваться";
        private const string AUTH_URL = "pub/admin/login";

        public AuthDialog(KeyToolsClient client, Action<string> onAuth, SavedData savedData) 
        {
            InitializeComponent();
            _client = client;
            _onAuth = onAuth;
            _savedData = savedData;
            
            SetData(client.CurrentServer);
        }

        private void SetData(string serverName)
        {
            Text = serverName;
            login = _savedData["login"];
            loginField.Text = login;

            if (saveCheckBox.Checked = !string.IsNullOrEmpty(login))
            {
                ////////////////////////////////////////
                passwordField.Text = "r69706970";
                authButton.Select();
                //passwordField.Select();
            }
        }

        private void OnLoginChanged(object sender, EventArgs e)
        {
            login = loginField.Text;
        }

        private void OnPasswordChanged(object sender, EventArgs e)
        {
            password = passwordField.Text;
        }

        private void OnAuthClick(object sender, EventArgs e)
        {
            var request = new LoginRequest(login, password);
            var toSend = JsonSerializer.Serialize(request);

            var responce = _client.PostAsync(Url, new StringContent(toSend, Encoding.UTF8, "application/json")).Result; //todo убрать в KeyToolsClient

            if (!responce.IsSuccessStatusCode)
            {
                MessageBox.Show(responce.StatusCode.ToString(), AUTH_ERROR, MessageBoxButtons.OK);
            }
            else
            {
                var loginResponce = JsonSerializer.Deserialize<LoginResponse>(responce.Content.ReadAsStringAsync().Result);
                _onAuth(loginResponce.token);

                if (saveCheckBox.Checked)
                {
                    _savedData["login"] = loginField.Text;
                }

                Close();
            }
        }

        private class LoginRequest
        {
            public LoginRequest(string login, string pass)
            {
                username = login;
                password = pass;
                browser = new Browser();
            }

            public string username { get; set; }
            public string password { get; set; }
            public Browser browser { get; set; }
        }

        private class Browser
        {
            public Browser()
            {
                browser = "KeyChekGuiApp";
                os = "Windows";
                userAgent = "KeyChekGuiApp version 1.01";
                language = "Russian";
                ip = "0.0.0.0";
            }

            public string browser { get; set; }
            public string language { get; set; }
            public string os { get; set; }
            public string userAgent { get; set; }
            public string ip { get; set; }
        }

        private class LoginResponse
        {
            public string token { get; set; }
            public string refreshToken { get; set; }
            public string[] authorities { get; set; }
        }
    }
}
