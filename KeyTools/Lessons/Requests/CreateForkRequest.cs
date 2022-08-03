
namespace KeyTools.Lessons.Requests
{
    internal class CreateForkRequest : GetLessonRequest
    {
        private const string URL = "/game/lessons/fork/";
        public CreateForkRequest(string lessonId) : base(URL + lessonId) { }
    }
}
