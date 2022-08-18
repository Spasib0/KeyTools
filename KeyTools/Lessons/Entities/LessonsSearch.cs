using System;
using System.Linq;
using System.Windows.Forms;

namespace KeyTools.Lessons.Entities
{
    internal class LessonsSearch : LinkedLog
    {
        private Func<string, LessonsData> searchByLabel => LessonsTests.Client.SearchByLabel;
        private const string name = "LessonsSearch";
        public LessonsSearch(LinkLabel link) : base(link, name) { }

        public LessonsData ByLabel(string label)
        {
            var lessonsData = searchByLabel(label);
            var hasLessons = lessonsData.Count > 0;

            if (hasLessons)
            {
                Logger.Add(string.Join("\n", lessonsData.Lessons.Select(lesson => $"{lesson.id} {lesson.content.Label}")));
                Logger.Save();
            }

            SetLink(hasLessons, hasLessons ? $"{lessonsData.Count} lessons" : "None");

            return lessonsData;
        }

        public LessonsData Avalible()
        {
            return ByLabel("");
        }
    }
}
