﻿using KeyTools.Classes;
using KeyTools.Lessons.Entities;
using KeyTools.Lessons.Infos;
using KeyTools.Lessons.Requests;
using KeyTools.Lessons.Tests;
using Newtonsoft.Json;
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
        private LessonsData keyLessons;
        private HasContentLinks hasContentLinksTest;
        private CanUpdateLessons updateLessonTest;
        private AuthorLessons authorLessonsInfo;
        private KeyLessons keyLessonsInfo;
        private HasPublishedLessons hasPublishedLessonsTest;
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
            hasPublishedLessonsTest = new HasPublishedLessons(forkPostLink);
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
            lessonsSearch = new LessonsSearch(lessonsSearchLink);
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

        private bool TestHasPublishedLesson()
        {
            var isPassed = hasPublishedLessonsTest.Test(keyLessons.Lessons);
            SetHasPublishedLessonsInfo(isPassed);
            return isPassed;
        }

        private string TestForkGet()
        {
            var forkId = ForkGetTest.Test(lessonsSearch.Avalible().Lessons.FirstOrDefault(lesson => !lesson.personal));
            var isPassed = forkId != "-1";

            SetTestIcon(forkGetIcon, isPassed);

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

            SetTestIcon(forkPostIcon, isPassed);

            if (isPassed)
            {
                AddLessonForDelete(forkId, "Created fork (post)");
            }

            return forkId;
        }

        private void TestDeleteLessons()
        {
            SetTestIcon(canDeleteLessonsIcon, canDeleteLessonsTest.Test(lessonsForDelete, RemoveLessonForDelete));
        }

        private void TestCanCreateNewLesson()
        {
            var lessonId = canCreateNewLessonTest.Test();
            var isPassed = lessonId != "-1";

            if (isPassed)
            {
                AddLessonForDelete(lessonId, "Created new lesson");
            }

            SetTestIcon(canCreateNewLessonIcon, isPassed);
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
            SetTestIcon(forkPostIcon, state);
            forkPostLink.Visible = true;
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

        private void SetModeratorTests(bool state)
        {
            moderatorTestsGroupBox.Enabled = state;
        }
    }
}
