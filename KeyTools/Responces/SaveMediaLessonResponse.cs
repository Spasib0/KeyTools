using Newtonsoft.Json.Linq;

namespace KeyTools.Responces
{
    public class SaveMediaLessonResponse : BaseResponse
    {
        internal MediaLessonResponseData data;

        public SaveMediaLessonResponse(JObject jLessonResponceObj)
        {
            value = jLessonResponceObj.Value<string>("value");
            details = jLessonResponceObj.Value<string>("details");
            delay = jLessonResponceObj.Value<int>("delay");
            data = value == SERVER_RETURN_OK
                ? new MediaLessonResponseData(jLessonResponceObj.Value<JToken>("data"))
                : null;
        }
    }
}
