
namespace KeyTools.Lessons.Requests
{
    internal class ForkGetRequest : GetLessonRequest
    {
        private const string URL = "/game/lessons/fork/";
        public ForkGetRequest(long lessonId) : base(URL + lessonId) { }
    }
}
