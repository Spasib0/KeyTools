using KeyTools.Lessons.Entities;
using Newtonsoft.Json;

namespace KeyTools.Lessons.Requests
{
    public class AllModeratorLessonsRequest : PutLessonRequest
    {
        private const string URL = "/game/lessons/new";
        public AllModeratorLessonsRequest() : base(URL, JsonConvert.SerializeObject(ModeratorSearchRequest.SearchAllLessons(true, 99))) { }
    }
}
