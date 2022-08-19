using KeyTools.Lessons.Entities;
using KeyTools.Responces;
using Newtonsoft.Json.Linq;
using System;
using System.Windows.Forms;

namespace KeyTools.Lessons.Tests
{
    internal class PersonalState : LinkedLog
    {
        private const string LOG_NAME = "ChangePersonalState";
        private Func<RejectLesson, JObject> updateState => LessonsTests.Client.UpdateLessonPublishState;

        public PersonalState(LinkLabel logLink) : base (logLink, LOG_NAME) { }

        private bool Send(long id, bool state, RejectReason reason)
        {
            var toSend = new RejectLesson(id, state, reason, null);
            var res = updateState(toSend);
            return false;
        }

        public bool Publish(LessonResponseData lesson)
        {
            return Send(lesson.id, false, lesson.content.Review.CheckRejected ? RejectReason.PublishedAfterReject() : RejectReason.Published());
        }

        public bool Reject(LessonResponseData lesson)
        {
            return Send(lesson.id, false, RejectReason.Reject());
        }
    }
}
