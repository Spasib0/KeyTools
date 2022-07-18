using KeyTools.Classes;
using KeyTools.Lessons.Entities;
using KeyTools.Lessons.Requests;
using System;
using System.Text.Json;
using System.Windows.Forms;

namespace KeyCheckGui
{
    public partial class LessonsTests : UserControl
    {
        private LessonsClient _client;

        public LessonsTests()
        {
            InitializeComponent();
        }

        public void SetClient(KeyToolsClient client)
        {
            _client = new LessonsClient(client);
        }
        public void CheckModeratorRole()
        {
            var data = JsonSerializer.Deserialize<UserKeyData>(_client.Call(new UserDataRequest()));
            SetModeratorTests(data.IsModerator);
        }

        private void OnGetKeyLessonsClick(object sender, EventArgs e)
        {
            var lessons = new LessonsData(_client.Call(new SchoolLessonsRequest()));
            keyLessonsCountLabel.Text = lessons.Count.ToString();
        }

        private void OnAllWorldLessonsClick(object sender, EventArgs e)
        {
            var lessons = new LessonsData(_client.Call(new AllModeratorLessonsRequest()));
            allWorldLessonsCountLabel.Text = lessons.Count.ToString();
        }

        private void SetModeratorTests(bool state)
        {
            moderatorTestsGroupBox.Enabled = state;
        }
    }
}
