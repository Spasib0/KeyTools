using KeyCheckGui;
using KeyTools.Responces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace KeyTools.Lessons.Tests
{
    internal class UpdateLesson : LoggedTest
    {
        private Func<LessonResponseData, string> updateLesson => LessonsTests.Client.UpdateLesson;
        private const string LOG_NAME = "UpdateLesson";

        public UpdateLesson(LinkLabel logLink) : base(logLink, LOG_NAME) { }

        public bool Test(List<LessonResponseData> lessons)
        {
            foreach(var lesson in lessons)
            {
                var responce = updateLesson(lesson);
            }

            return false;
        }
    }
}
