using KeyTools.Lessons.Entities;
using KeyTools.Responces;
using Newtonsoft.Json.Linq;
using System;
using System.Windows.Forms;

namespace KeyTools.Lessons.Tests
{
    internal class ForkGet : LinkedLog
    {
        private Func<long, JObject> createFork => LessonsTests.Client.CreateForkGet;
        private const string LOG_NAME = "ForkGet";
        public ForkGet(LinkLabel logLink) : base(logLink, LOG_NAME) { }

        public string Test(LessonResponseData lesson)
        {
            var forkId = "-1";

            if (lesson != null)
            {
                var response = new SaveLessonResponse(createFork(lesson.id));

                if (!response.IsOk)
                {
                    Logger.Add($"Not create fork for {lesson.id} - {response.details}");
                }
                else
                {
                    forkId = response.data.id.ToString();
                    Logger.Add($"Created fork for {lesson.id} with id: {forkId}");
                }
            }
            else
            {
                Logger.Add("The user has no lessons(published) available to fork");
            }

     

            Logger.Save();

            SetLink();

            return forkId;
        }
    }
}
