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

        public bool Check()
        {
            var lessons = getAuthorLessons().Data;

            if(lessons.Count > 0)
            {
                Logger.Add(string.Join("\n", lessons.Select(lesson => lesson.id)));
                Logger.Save();
                SetLink($"{lessons.Count} lessons");
                return true;
            }

            return false;
        }

        private void SetLink(string text)
        {
            SetLinkText(text);
            SetEnabled(true);
        }
    }
}
