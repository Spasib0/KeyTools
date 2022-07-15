using KeyTools.Classes;
using KeyTools.Lessons.Entities;
using System;
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

        private void OnGetKeyLessonsClick(object sender, EventArgs e)
        {
            var lessons = _client.GetKeyLessons();
            keyLessonsCountLabel.Text = lessons.Count.ToString();
        }

        private void OnAllWorldLessonsClick(object sender, EventArgs e)
        {
            var lessons = _client.GetAllWorldLessons();
            allWorldLessonsCountLabel.Text = lessons.Count.ToString();
        }
    }
}
