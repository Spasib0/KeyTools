using KeyCheckGui;
using KeyTools.Lessons.Entities;
using KeyTools.Responces;
using Newtonsoft.Json.Linq;
using System;
using System.Windows.Forms;

namespace KeyTools.Lessons.Tests
{
    internal class CanDeleteLesson : LinkedLog
    {
        private Func<string, JObject> deleteLesson => LessonsTests.Client.DeleteLesson;
        private const string LOG_NAME = "CanDeleteLesson";

        public CanDeleteLesson(LinkLabel logLink) : base(logLink, LOG_NAME) { }

        public bool Test(string lessonId)
        {
            var response = new SaveLessonResponse(deleteLesson(lessonId));
            if (!response.IsOk)
            {
                Logger.Add($"Not deleted lesson {lessonId} - {response.details}");
            }
            else
            {
                Logger.Add($"Lesson {lessonId} deleted");
            }

            Logger.Save();

            SetLink();

            return response.IsOk;
        }
    }
}
