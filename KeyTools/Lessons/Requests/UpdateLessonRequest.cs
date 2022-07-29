using KeyTools.Responces;
using Newtonsoft.Json;

namespace KeyTools.Lessons.Requests
{
    public class UpdateLessonRequest : PutLessonRequest
    {
        private const string URL = "/game/lesson/";
        public UpdateLessonRequest(LessonResponseData data) : base (URL + data.id, JsonConvert.SerializeObject(new SaveLessonRequest(data.content, data.personal))) { }
    }
}
