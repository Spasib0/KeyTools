using KeyCheckGui;
using KeyTools.Lessons.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace KeyTools.Lessons.Infos
{
    internal class AuthorLessons : LinkedLog
    {
        private Func<LessonsData> getAuthorLessons => LessonsTests.Client.GetAuthorLessons;
        private const string LOG_NAME = "AuthorLessons";
        public AuthorLessons(LinkLabel logLink) : base(logLink, LOG_NAME) { }

        public bool Update()
        {
            var lessons = getAuthorLessons().Data;
            var hasLessons = lessons.Count > 0;

            if (hasLessons)
            {
                Logger.Add(string.Join("\n", lessons.Select(lesson => lesson.id)));
                Logger.Save();
            }

            SetLink(hasLessons, hasLessons ? $"{lessons.Count} lessons" : "None");

            return hasLessons;
        }
    }
}
