using KeyCheckGui;
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

        public void ByLabel(string label)
        {
            var result = searchByLabel(label);
            var hasLessons = result.Count > 0;

            if (hasLessons)
            {
                Logger.Add(string.Join("\n", result.Data.Select(lesson => $"{lesson.id} {lesson.content.Label}")));
                Logger.Save();
            }

            SetLink(hasLessons, hasLessons ? $"{result.Count} lessons" : "None");
        }
    }
}
