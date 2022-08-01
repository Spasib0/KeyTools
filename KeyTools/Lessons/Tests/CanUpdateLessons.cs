using KeyCheckGui;
using KeyTools.Lessons.Entities;
using KeyTools.Responces;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KeyTools.Lessons.Tests
{
    internal class CanUpdateLessons : LinkedLog
    {
        private Func<LessonResponseData, JObject> updateLesson => LessonsTests.Client.UpdateLesson;
        private const string LOG_NAME = "UpdateLesson";

        public CanUpdateLessons(LinkLabel logLink) : base(logLink, LOG_NAME) { }

        public bool Test(List<LessonResponseData> lessons)
        {
            var isPassed = lessons.Select(lesson => TestUpdateLesson(lesson)).ToArray().All(item => item);
            Logger.Save();
            return isPassed;
        }

        private bool TestUpdateLesson(LessonResponseData lesson)
        {
            var JResponce = updateLesson(lesson);

            if (JResponce["value"].ToString() != "ok")
            {
                Logger.Add($"№ {lesson.id} - details: {JResponce["details"]}\n");
                return false;
            }

            return true;
        }
    }
}
