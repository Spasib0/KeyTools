using KeyTools.Classes;
using KeyTools.Lessons.Entities;
using KeyTools.Lessons.Requests;
using KeyTools.Lessons.Tests;
using KeyTools.Responces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
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

        private void TestKeyLessonsClick(object sender, EventArgs e)
        {
            var lessons = new LessonsData(_client.Call(new SchoolLessonsRequest()));
            TestHasLessonsContenLinks(lessons.Data);
            TestUpdateRandomLesson(lessons.StringIds[new Random().Next(lessons.Data.Count - 1)]);

            SetComboBox(keyLessonsComboBox, lessons.StringIds); //todo убрать
        }

        private void TestUpdateRandomLesson(string lessonId)
        {
            var lesson = GetLessonById(lessonId);
        }

        private void TestHasLessonsContenLinks(List<LessonResponseData> data)
        {
            SetHasContentLinksInfo(hasContentLinksTest.Test(data));
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



        private LessonResponseData GetLessonById(string id)
        {
            var lessonObj = (JObject)JsonConvert.DeserializeObject(_client.Call(new LessonByIdRequest(id)));
            return new SaveLessonResponse(lessonObj).data;
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
