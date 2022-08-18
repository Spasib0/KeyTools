using Newtonsoft.Json.Linq;

namespace KeyTools.Responces
{
    public class SaveLessonResponse : BaseResponse
    {
        internal LessonResponseData data;

        public SaveLessonResponse(JObject jLessonResponceObj)
        {
            value = jLessonResponceObj.Value<string>("value");
            details = jLessonResponceObj.Value<string>("details");
            delay = jLessonResponceObj.Value<int>("delay");
            data = IsOk && jLessonResponceObj.Value<JToken>("data") != null
                 ? new LessonResponseData(jLessonResponceObj.Value<JToken>("data"))
                 : null;
        }
    }
}
