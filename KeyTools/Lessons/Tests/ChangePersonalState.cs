using KeyTools.Lessons.Entities;
using KeyTools.Responces;
using Newtonsoft.Json.Linq;
using System;
using System.Windows.Forms;

namespace KeyTools.Lessons.Tests
{
    internal class ChangePersonalState : LinkedLog
    {
        private const string LOG_NAME = "ChangePersonalState";
        private Func<RejectLesson, JObject> changeState => LessonsTests.Client.ChangeLessonPublishedState;

        public ChangePersonalState(LinkLabel logLink) : base (logLink, LOG_NAME) { }

        public LessonResponseData Update(LessonResponseData lesson)
        {
            var newState = !lesson.personal;
            var rejectReason = newState ? RejectReason.Reject() : lesson.content.Review.CheckRejected ? RejectReason.PublishedAfterReject() : RejectReason.Published();

            var toSend = new RejectLesson(lesson.id, newState, rejectReason, null);

            var res = changeState(toSend);
            return lesson;
        }
    }
}
