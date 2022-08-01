using System;
using System.Collections.Generic;
using System.Text;

namespace KeyTools.Lessons.Requests
{
    internal class LessonWithContent : GetLessonsRequest
    {
        private const string URL = "/game/lessons/content/{0}/russian";

        public LessonWithContent(string id) : base(string.Format(URL, id)) { }
    }
}
