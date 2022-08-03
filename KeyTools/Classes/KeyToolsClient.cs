using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace KeyTools.Classes
{
    public class KeyToolsClient : HttpClient
    {
        public string CurrentServer => _serversList.Text;
        private ComboBox _serversList;
        public KeyToolsClient(ComboBox serversList)
        {
            _serversList = serversList;
        }

        public string GetRequest(string url)
        {
            var request = GetAsync(CurrentServer + url).Result;
            using var reader = new StreamReader(request.Content.ReadAsStreamAsync().Result);
            return reader.ReadToEnd();
        }

        public string PutRequest(string url, string data)
        {
            var request = PutAsync(CurrentServer + url, new StringContent(data, Encoding.UTF8, "application/json")).Result;
            using var reader = new StreamReader(request.Content.ReadAsStreamAsync().Result);
            return reader.ReadToEnd();
        }

        internal string PostRequest(string url, string data)
        {
            var request = PostAsync(CurrentServer + url, new StringContent(data, Encoding.UTF8, "application/json")).Result;
            using var reader = new StreamReader(request.Content.ReadAsStreamAsync().Result);
            return reader.ReadToEnd();
        }
    }
}
