using Newtonsoft.Json.Linq;

namespace KeyCheckGui
{
    public class MediaLessonResponseData : BaseLessonResponseData
    {
        internal MediaCardsAppLessonData content;

        public MediaLessonResponseData(JToken jLessonResponseObj) : base(jLessonResponseObj)
        {
            if (jLessonResponseObj.Value<JObject>("content") != null)
                content = new MediaCardsAppLessonData(jLessonResponseObj.Value<JObject>("content"));
        }
    }
}