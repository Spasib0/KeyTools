using KeyTools.Classes;
using KeyTools.Lessons.Entities;
using KeyTools.Lessons.Infos;
using KeyTools.Lessons.Requests;
using KeyTools.Lessons.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KeyTools.Lessons
{
    public partial class LessonsTests : UserControl
    {
        public static LessonsClient Client;

        private Action<Label, bool> SetIcon => KeyTools.SetIcon;

        private LessonsClient _client;
        private LessonsData keyLessons;
        private HasContentLinks hasContentLinksTest;
        private CanUpdateLessons updateLessonTest;
        private AuthorLessons authorLessonsInfo;
        private KeyLessons keyLessonsInfo;
        private ForkGet ForkGetTest;
        private ForkPost ForkPostTest;
        private CanDeleteLesson canDeleteLessonsTest;
        private CanCreateNewLesson canCreateNewLessonTest;
        private LessonsSearch lessonsSearch;

        private List<LessonForDelete> lessonsForDelete;

        public LessonsTests()
        {
            InitializeComponent();
            InitTests();
            InitInfos();
            InitSearch();
        }

        private void InitTests()
        {
            hasContentLinksTest = new HasContentLinks(keyLessonsTestLogLink);
            updateLessonTest = new CanUpdateLessons(updateLessonLink);
            ForkGetTest = new ForkGet(forkGetLink);
            ForkPostTest = new ForkPost(forkPostLink);
            canDeleteLessonsTest = new CanDeleteLesson(canDeleteLessonLink);
            canCreateNewLessonTest = new CanCreateNewLesson(canCreateNewLessonLink);
        }

        private void InitInfos()
        {
            keyLessonsInfo = new KeyLessons(keyLessonsLink);
            authorLessonsInfo = new AuthorLessons(authorLessonsLink);
        }

        private void InitSearch()
        {
            lessonsSearch = new LessonsSearch(searchLessonsLink);
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
            SetModeratorControl(data.IsModerator);
        }

        private void TestKeyLessonsClick(object sender, EventArgs e)
        {
            keyLessons = keyLessonsInfo.Update();
            TestHasLessonsContenLinks();
            TestUpdatLessons();

            TestForkGet();
            TestForkPost();

            TestCanCreateNewLesson();
            TestDeleteLessons();
            CheckAuthorLessons();
        }

        private void TestUpdatLessons()
        {
            SetUpdateLessonInfo(updateLessonTest.Test(keyLessons.Lessons));
        }

        private void TestHasLessonsContenLinks()
        {
            SetHasContentLinksInfo(hasContentLinksTest.Test(keyLessons.Lessons));
        }

        private string TestForkGet()
        {
            var forkId = ForkGetTest.Test(lessonsSearch.Avalible().Lessons.FirstOrDefault(lesson => !lesson.personal));
            var isPassed = forkId != "-1";

            SetIcon(forkGetIcon, isPassed);

            if (isPassed)
            {
                AddLessonForDelete(forkId, "Created fork (get)");
            }

            return forkId;
        }

        private string TestForkPost()
        {
            var forkId = ForkPostTest.Test(lessonsSearch.Avalible().Lessons.FirstOrDefault(lesson => !lesson.personal));
            var isPassed = forkId != "-1";

            SetIcon(forkPostIcon, isPassed);

            if (isPassed)
            {
                AddLessonForDelete(forkId, "Created fork (post)");
            }

            return forkId;
        }

        private void TestDeleteLessons()
        {
            SetIcon(canDeleteLessonsIcon, canDeleteLessonsTest.Test(lessonsForDelete, RemoveLessonForDelete));
        }

        private void TestCanCreateNewLesson()
        {
            var lessonId = canCreateNewLessonTest.Test();
            var isPassed = lessonId != "-1";

            if (isPassed)
            {
                AddLessonForDelete(lessonId, "Created new lesson");
            }

            SetIcon(canCreateNewLessonIcon, isPassed);
        }

        private void CheckAuthorLessons()
        {
            SetAuthorsLessonsInfoLink(authorLessonsInfo.Update());
        }

        private void OnSearchLessonsClick(object sender, EventArgs e)
        {
            lessonsSearch.ByLabel(lessonsSearchTextBox.Text);
        }

        private void AddLessonForDelete(string id, string description)
        {
            if (lessonsForDelete == null)
                lessonsForDelete = new List<LessonForDelete>();

            lessonsForDelete.Add(new LessonForDelete(id, description));
        }

        private void RemoveLessonForDelete(List<LessonForDelete> lessons)
        {
            foreach (var lesson in lessons)
            {
                lessonsForDelete.Remove(lesson);
            }
        }

        //todo в какой-то другой класс можно
        private void SetHasContentLinksInfo(bool state)
        {
            SetIcon(keyLesonsTestIcon, state);
            keyLessonsTestLogLink.Visible = !state;
        }

        private void SetUpdateLessonInfo(bool state)
        {
            SetIcon(updateLessonTestIcon, state);
            updateLessonLink.Visible = !state;
        }

        private void SetAuthorsLessonsInfoLink(bool state)
        {
            updateLessonLink.Enabled = state;
        }

        private void SetModeratorControl(bool state)
        {
            moderatorGroupBox.Enabled = state;
        }
    }
}
