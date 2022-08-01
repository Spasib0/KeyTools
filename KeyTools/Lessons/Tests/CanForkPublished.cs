using KeyCheckGui;
using KeyTools.Lessons.Entities;
using KeyTools.Responces;
using Newtonsoft.Json.Linq;
using System;
using System.Windows.Forms;

namespace KeyTools.Lessons.Tests
{
    internal class CanForkPublished : LinkedLog
    {
        private Func<string, JObject> createFork => LessonsTests.Client.CreateFork;
        private const string LOG_NAME = "CanForkPublished";
        public CanForkPublished(LinkLabel logLink) : base(logLink, LOG_NAME) { }

        public string Test(string lessonId)
        {
            var response = new SaveLessonResponse(createFork(lessonId));
            var forkId = "-1";

            if (!response.IsOk)
            {
                Logger.Add($"Not create fork for {lessonId} - {response.details}");
            }
            else
            {
                forkId = response.data.id.ToString();
                Logger.Add($"Created fork for {lessonId} with id: {forkId}");
            }

            Logger.Save();

            SetLink();

            return forkId;
        }
    }
}
