using KeyCheckGui;
using KeyTools.Lessons.Entities;
using KeyTools.Responces;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KeyTools.Lessons.Tests
{
    internal class CanDeleteLesson : LinkedLog
    {
        private Func<string, JObject> deleteLesson => LessonsTests.Client.DeleteLesson;
        private const string LOG_NAME = "CanDeleteLesson";

        public CanDeleteLesson(LinkLabel logLink) : base(logLink, LOG_NAME) { }

        public bool Test(List<LessonForDelete> lessons, Action<List<LessonForDelete>> onDelete)
        {
            bool testPassed = true;
            List<LessonForDelete> deletedLessons = new List<LessonForDelete>();

            foreach (var lesson in lessons)
            {
                var response = new SaveLessonResponse(deleteLesson(lesson.Id));

                if (!response.IsOk)
                {
                    Logger.Add($"Not deleted lesson {lesson.Id} ({lesson.Description}) - {response.details}\n");
                    testPassed = false;
                }
                else
                {
                    Logger.Add($"Lesson {lesson.Id} ({lesson.Description}) deleted\n");
                    deletedLessons.Add(lesson);
                }
            }

            onDelete(deletedLessons);

            Logger.Save();

            SetLink();

            return testPassed;
        }
    }
}
