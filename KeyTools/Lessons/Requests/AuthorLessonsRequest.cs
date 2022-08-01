
namespace KeyTools.Lessons.Requests
{
    internal class AuthorLessonsRequest : GetLessonsRequest
    {
        private const string URL = "/game/lessons/author/my";
        public AuthorLessonsRequest() : base(URL) { }
    }
}
