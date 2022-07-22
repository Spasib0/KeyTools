using KeyTools.Responces;
using Newtonsoft.Json;

namespace KeyTools.Lessons.Requests
{
    public class UpdateLessonRequest : PutLessonRequest
    {
        private const string URL = "/game/lesson/";
        public UpdateLessonRequest(string url, LessonResponseData data) : base (url, JsonConvert.SerializeObject(new SaveLessonRequest(data.content, data.personal))) { }
    }
}
