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
using System.Linq;
using System.Windows.Forms;

namespace KeyCheckGui
{
    public partial class LessonsTests : UserControl
    {
        public static LessonsClient Client;
        private LessonsClient _client;
        private string[] currentProducts;
        private LessonsData keyLessons;
        private HasContentLinks hasContentLinksTest;
        private UpdateLesson updateLessonTest;
        

        public LessonsTests()
        {
            InitializeComponent();
            InitTests();
        }

        private void InitTests()
        {
            hasContentLinksTest = new HasContentLinks(keyLessonsTestLogLink);
            updateLessonTest = new UpdateLesson(updateLessonLink);
        }

        public void SetClient(KeyToolsClient client)
        {
            _client = new LessonsClient(client);
            Client = _client;
        }

        public void Update(string[] products)
        {
            Client.SetProducts(products);
            CheckModeratorRole();
        }

        public void CheckModeratorRole()
        {
            var data = System.Text.Json.JsonSerializer.Deserialize<UserKeyData>(_client.Call(new UserDataRequest()));
            SetModeratorTests(data.IsModerator);
        }

        private void TestKeyLessonsClick(object sender, EventArgs e)
        {
            keyLessons = new LessonsData(Client.Call(new SchoolLessonsRequest()));
            TestHasLessonsContenLinks(keyLessons.Data);
            //TestUpdateRandomLesson(lessons.StringIds[new Random().Next(lessons.Data.Count - 1)]);
            

            SetComboBox(keyLessonsComboBox, keyLessons.StringIds); //todo убрать
        }

        private void TestHasLessonsContenLinks(List<LessonResponseData> lessons)
        {
            SetHasContentLinksInfo(hasContentLinksTest.Test(lessons));
        }

        private void OnUpdateLesson(object sender, EventArgs e)
        {
            SetUpdateLessonInfo(updateLessonTest.Test(keyLessons.Data.Where(lesson => lesson.id.ToString().Equals(keyLessonsComboBox.SelectedItem)).ToList()));
        }

        //todo в какой-то другой класс можно
        private void SetHasContentLinksInfo(bool state)
        {
            SetTestLabel(keyLesonsTestIcon, state);
            keyLessonsTestLogLink.Visible = !state;
        }

        private void SetUpdateLessonInfo(bool state)
        {
            SetTestLabel(updateLessonTestIcon, state);
            updateLessonLink.Visible = !state;
        }

        private void SetTestLabel(Label label, bool state)
        {
            label.Text = state ? "OK" : "FAIL";
            label.ForeColor = state ? Color.Green : Color.Red;
        }

        private LessonResponseData GetLessonById(string id)
        {
            var lessonObj = (JObject)JsonConvert.DeserializeObject(Client.Call(new LessonByIdRequest(id)));
            return new SaveLessonResponse(lessonObj).data;
        }

        private LessonLinkedMedia GetLessonLinkedMedia(string id)
        {
            var lessonObj = (JObject)JsonConvert.DeserializeObject(Client.Call(new LessonWithContent(id)));
            return new LessonLinkedMedia(new SaveMediaLessonResponse(lessonObj).data.content.media);
        }

        private void OnAllWorldLessonsClick(object sender, EventArgs e)
        {
            var lessons = new LessonsData(Client.Call(new AllModeratorLessonsRequest()));
            allWorldLessonsCountLabel.Text = lessons.Count.ToString();
        }

        private void OnGetAuthorLessonsClick(object sender, EventArgs e)
        {
            var lessons = new LessonsData(Client.Call(new AuthorLessonsRequest()));
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
