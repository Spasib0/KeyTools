using Newtonsoft.Json;

namespace KeyTools.Lessons.Requests
{
    internal class LessonsSearchRequest : PutLessonRequest
    {
        private const string URL = "/game/lessons/search";
        public LessonsSearchRequest(string label) : base(URL, JsonConvert.SerializeObject(SearchLessonsRequest.SearchByLabel(label))) { }
    }
}
