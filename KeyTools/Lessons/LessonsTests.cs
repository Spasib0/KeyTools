using KeyTools.Classes;
using KeyTools.Lessons.Entities;
using KeyTools.Lessons.Infos;
using KeyTools.Lessons.Requests;
using KeyTools.Lessons.Tests;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace KeyCheckGui
{
    public partial class LessonsTests : UserControl
    {
        public static LessonsClient Client;
        private LessonsClient _client;
        private LessonsData keyLessons;
        private HasContentLinks hasContentLinksTest;
        private CanUpdateLessons updateLessonTest;
        private AuthorLessons authorLessonsInfo;
        private KeyLessons keyLessonsInfo;
        private HasPublishedLessons hasPublishedLessonsTest;
        private CanForkPublished canForkPublishedTest;
        private CanDeleteLesson canDeleteLessonTest;


        public LessonsTests()
        {
            InitializeComponent();
            InitTests();
            InitInfos();
        }

        private void InitTests()
        {
            hasContentLinksTest = new HasContentLinks(keyLessonsTestLogLink);
            updateLessonTest = new CanUpdateLessons(updateLessonLink);
            hasPublishedLessonsTest = new HasPublishedLessons(hasPublishedLessonsLink);
            canForkPublishedTest = new CanForkPublished(canForkPublishedLink);
            canDeleteLessonTest = new CanDeleteLesson(canDeleteLessonLink);
        }

        private void InitInfos()
        {
            keyLessonsInfo = new KeyLessons(keyLessonsLink);
            authorLessonsInfo = new AuthorLessons(authorLessonsLink);
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
            keyLessons = keyLessonsInfo.Update();
            TestHasLessonsContenLinks();
            TestUpdatLessons();

            if (TestHasPublishedLesson())
            {
                var forkId = TestCreateForkPublished();

                if (forkId != "-1")
                {
                    TestDeleteLessonById(forkId);
                }
            }

            CheckAuthorLessons();


            SetComboBox(keyLessonsComboBox, keyLessons.StringIds); //todo убрать
        }


        private void TestUpdatLessons()
        {
            SetUpdateLessonInfo(updateLessonTest.Test(keyLessons.Data));
        }

        private void TestHasLessonsContenLinks()
        {
            SetHasContentLinksInfo(hasContentLinksTest.Test(keyLessons.Data));
        }

        private bool TestHasPublishedLesson()
        {
            var isPassed = hasPublishedLessonsTest.Test(keyLessons.Data);
            SetHasPublishedLessonsInfo(isPassed);
            return isPassed;
        }

        private string TestCreateForkPublished()
        {
            var forkId = canForkPublishedTest.Test(keyLessons.Data.FirstOrDefault(lesson => !lesson.personal).id.ToString());
            SetTestIcon(canForkPublishedIcon, forkId != "-1");
            return forkId;
        }


        private void TestDeleteLessonById(string id)
        {
            SetTestIcon(canDeleteLessonIcon, canDeleteLessonTest.Test(id));
        }

        private void CheckAuthorLessons()
        {
            SetAuthorsLessonsInfoLink(authorLessonsInfo.Update());
        }

        private void OnCreateFork(object sender, EventArgs e)
        {
            var res = Client.CreateFork(keyLessonsComboBox.SelectedItem.ToString());
        }

        //todo в какой-то другой класс можно
        private void SetHasContentLinksInfo(bool state)
        {
            SetTestIcon(keyLesonsTestIcon, state);
            keyLessonsTestLogLink.Visible = !state;
        }

        private void SetUpdateLessonInfo(bool state)
        {
            SetTestIcon(updateLessonTestIcon, state);
            updateLessonLink.Visible = !state;
        }

        private void SetHasPublishedLessonsInfo(bool state)
        {
            SetTestIcon(hasPublishedLessonsIcon, state);
            hasPublishedLessonsLink.Visible = true;
        }

        private void SetAuthorsLessonsInfoLink(bool state)
        {
            updateLessonLink.Enabled = state;
        }
        

        private void SetTestIcon(Label label, bool state)
        {
            label.Text = state ? "OK" : "FAIL";
            label.ForeColor = state ? Color.Green : Color.Red;
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
