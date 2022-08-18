using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KeyTools.Lessons.Entities
{
    public class RejectReason
    {
        private const string PUBLISHED = "Published with KeyTools";
        private const string PUBLISHED_AFTER_REJECT = "Published after rejected with KeyTools";
        private const string REJECTED = "Rejected with KeyTools";

        public string review;
        public bool forbidden;
        public bool trash;

        [JsonIgnore] public bool CheckRejected => forbidden || trash;
        [JsonIgnore] public bool PublishedAfterRejected => review == PUBLISHED_AFTER_REJECT;

        [JsonConstructor]
        public RejectReason(string review, bool forbidden, bool trash)
        {
            this.review = review;
            this.forbidden = forbidden;
            this.trash = trash;
        }

        public RejectReason(RejectReason rejectReason)
        {
            review = rejectReason.review;
            forbidden = rejectReason.forbidden;
            trash = rejectReason.trash;
        }

        public RejectReason(JObject jLessonResponseObj)
        {
            review = jLessonResponseObj.Value<string>("review");
            forbidden = jLessonResponseObj.Value<bool>("forbidden");
            trash = jLessonResponseObj.Value<bool>("trash");
        }

        public static RejectReason Published() => new RejectReason(PUBLISHED, false, false);
        public static RejectReason PublishedAfterReject() => new RejectReason(PUBLISHED_AFTER_REJECT, false, false);
        public static RejectReason Empty() => new RejectReason("", false, false);
        public static RejectReason Reject() => new RejectReason(REJECTED, false, false);
    }
}