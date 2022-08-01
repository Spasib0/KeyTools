using KeyTools.Lessons.Entities;
using KeyTools.Responces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeyTools.Lessons.Tests
{
    internal class HasPublishedLessons : LinkedLog
    {
        private const string LOG_NAME = "HasPublishedLessons";
        public HasPublishedLessons(LinkLabel logLink) : base(logLink, LOG_NAME) { }

        public bool Test(List<LessonResponseData> lessons)
        {
            var publishedLessons = lessons.Where(lesson => !lesson.personal).ToList();
            var hasPublished = publishedLessons.Count > 0;

            if (!hasPublished)
            {
                Logger.Add("Not have avalible published lessons");
            }
            else
            {
                Logger.Add(string.Join("\n", publishedLessons.Select(lesson => lesson.id)));
            }

            Logger.Save();

            SetLink(true, hasPublished ? $"{publishedLessons.Count} lessons" : OPEN_LOG);

            return hasPublished;
        }
    }
}
