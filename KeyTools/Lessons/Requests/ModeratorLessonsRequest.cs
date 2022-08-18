using Newtonsoft.Json;

namespace KeyTools.Lessons.Requests
{
    internal class ModeratorLessonsRequest : PutLessonRequest
    {
        private const string URL = "/game/lessons/new";
        public ModeratorLessonsRequest(ModeratorSearchRequest request) : base(URL, JsonConvert.SerializeObject(request)) { }
    }
}
