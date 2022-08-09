using KeyCheckGui;
using KeyTools.Lessons.Entities;
using KeyTools.Lessons.Requests;
using KeyTools.Responces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Windows.Forms;

namespace KeyTools.Lessons.Tests
{
    internal class ForkPost : LinkedLog
    {
        private Func<long, string, JObject> createFork => LessonsTests.Client.CreateForkPost;
        private const string LOG_NAME = "CanPost";
        public ForkPost(LinkLabel logLink) : base(logLink, LOG_NAME) { }

        public string Test(LessonResponseData lesson)
        {
            var forkId = "-1";

            if (lesson != null)
            {
                var newContent = lesson.content;
                newContent.SetLabel(lesson.id + "_kt_fork");
                var response = new SaveLessonResponse(createFork(lesson.id, JsonConvert.SerializeObject(new SaveLessonRequest(newContent, lesson.personal))));

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
