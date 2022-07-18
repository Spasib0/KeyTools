using System;
using System.Collections.Generic;
using System.Text;

namespace KeyTools.Lessons.Requests
{
    public class SchoolLessonsRequest : GetLessonsRequest
    {
        private const string URL = "game/lessons/author/my";
        public SchoolLessonsRequest() : base(URL) { }
    }
}
