using KeyTools.Lessons.Entities;
using Newtonsoft.Json;

namespace KeyTools.Lessons.Requests
{
    internal class PublishStateLessonRequest : PutLessonRequest
    {
        private const string URL = "/game/lessons/publish";

        public PublishStateLessonRequest(RejectLesson data) : base(URL, JsonConvert.SerializeObject(data)) { }
    }
}
