using KeyCheckGui;
using KeyTools.Lessons.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace KeyTools.Lessons.Infos
{
    class KeyLessons : LinkedLog
    {
        private Func<LessonsData> getKeyLessons => LessonsTests.Client.GetKeyLessons;
        private const string LOG_NAME = "KeyLessons";
        public KeyLessons(LinkLabel logLink) : base(logLink, LOG_NAME) { }

        public LessonsData Update()
        {
            var lessons = getKeyLessons();
            var hasLessons = lessons.Count > 0;

            if (hasLessons)
            {
                Logger.Add(string.Join("\n", lessons.Data.Select(lesson => $"{lesson.id} {lesson.content.Label}")));
                Logger.Save();
            }

            SetLink(hasLessons, hasLessons ? $"{lessons.Count} lessons" : "None");

            return lessons;
        }
    }
}
