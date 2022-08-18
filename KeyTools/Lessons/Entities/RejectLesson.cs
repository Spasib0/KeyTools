using System.Collections.Generic;

namespace KeyTools.Lessons.Entities
{
    public class RejectLesson : PublishLesson
    {
        public RejectReason review;

        public RejectLesson(long lessonId, bool personal, RejectReason rejectReason, HashSet<string> products) : base(lessonId, personal, products)
        {
            review = rejectReason;
        }
    }
}
