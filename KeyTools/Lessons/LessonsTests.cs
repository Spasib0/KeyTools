using KeyTools.Classes;
using KeyTools.Lessons.Entities;
using KeyTools.Lessons.Requests;
using KeyTools.Lessons.Tests;
using KeyTools.Responces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KeyCheckGui
{
    public partial class LessonsTests : UserControl
    {
        private LessonsClient _client;
        private HasContentLinks hasContentLinksTest;

        public LessonsTests()
        {
            InitializeComponent();
            InitTests();
        }

        private void InitTests()
        {
            hasContentLinksTest = new HasContentLinks(GetLessonLinkedMedia, keyLessonsTestLogLink);
        }

        public void SetClient(KeyToolsClient client)
        {
            _client = new LessonsClient(client);
        }

        public void CheckModeratorRole()
        {
            var data = System.Text.Json.JsonSerializer.Deserialize<UserKeyData>(_client.Call(new UserDataRequest()));
            SetModeratorTests(data.IsModerator);
        }

        private void OnGetKeyLessonsClick(object sender, EventArgs e)
        {
            var lessons = new LessonsData(_client.Call(new SchoolLessonsRequest()));
            SetHasContentLinksInfo(hasContentLinksTest.Test(lessons.Data));

            SetComboBox(keyLessonsComboBox, lessons.StringIds); //todo убрать
        }

        private void SetHasContentLinksInfo(bool state)
        {
            SetTestLabel(keyLesonsTestIcon, state);
            keyLessonsTestLogLink.Visible = !state;
        }

        private void SetTestLabel(Label label, bool state)
        {
            label.Text = state ? "OK" : "FAIL";
            label.ForeColor = state ? Color.Green : Color.Red;
        }



        private void OnGetLessonByIdClick(object sender, EventArgs e)
        {
            var lessonObj = (JObject)JsonConvert.DeserializeObject(_client.Call(new LessonByIdRequest(keyLessonsComboBox.SelectedItem.ToString())));
            var lesson = new SaveLessonResponse(lessonObj).data;
        }

        private LessonLinkedMedia GetLessonLinkedMedia(string id)
        {
            var lessonObj = (JObject)JsonConvert.DeserializeObject(_client.Call(new LessonWithContent(id)));
            return new LessonLinkedMedia(new SaveMediaLessonResponse(lessonObj).data.content.media);
        }

        private void OnAllWorldLessonsClick(object sender, EventArgs e)
        {
            var lessons = new LessonsData(_client.Call(new AllModeratorLessonsRequest()));
            allWorldLessonsCountLabel.Text = lessons.Count.ToString();
            
        }

        private void OnGetAuthorLessonsClick(object sender, EventArgs e)
        {
            var lessons = new LessonsData(_client.Call(new AuthorLessonsRequest()));
            authorLessonsCountLabel.Text = lessons.Count.ToString();
            
        }

        private void SetComboBox(ComboBox comboBox, string[] values)
        {
            var hasValues = values.Length > 0;

            comboBox.Enabled = hasValues;
            comboBox.Items.Clear();

            if(hasValues)
                comboBox.Items.AddRange(values);
        }

        private void SetModeratorTests(bool state)
        {
            moderatorTestsGroupBox.Enabled = state;
        }
    }
}
