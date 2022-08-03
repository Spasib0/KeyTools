using System;
using System.Collections.Generic;
using System.Text;

namespace KeyTools.Lessons.Requests
{
    internal class SchoolLessonsRequest : GetLessonRequest
    {
        private const string URL = "game/lessons/school/my";
        public SchoolLessonsRequest() : base(URL) { }
    }
}
