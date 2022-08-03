using KeyTools.Responces;
using Newtonsoft.Json;

namespace KeyTools.Lessons.Requests
{
    internal class CreateLessonRequest : PostLessonRequest
    {
        private const string URL = "/game/lesson/";
        public CreateLessonRequest(LessonResponseData lesson) : base(URL, JsonConvert.SerializeObject(new SaveLessonRequest(lesson.content, lesson.personal))) { }
    }
}
