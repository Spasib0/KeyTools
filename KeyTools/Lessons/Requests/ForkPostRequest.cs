
namespace KeyTools.Lessons.Requests
{
    internal class ForkPostRequest : PostLessonRequest
    {
        private const string URL = "/game/lesson/fork/";
        public ForkPostRequest(long lessonId, string data) : base(URL + lessonId, data) { }
    }
}
