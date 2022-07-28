using KeyTools.Responces;
using Newtonsoft.Json;

namespace KeyTools.Lessons.Requests
{
    public class UpdateLessonRequest : PutLessonRequest
    {
        private const string URL = "/game/lesson/";
        public UpdateLessonRequest(LessonResponseData data) : base (data.id.ToString(), JsonConvert.SerializeObject(new SaveLessonRequest(data.content, data.personal))) { }
    }
}
