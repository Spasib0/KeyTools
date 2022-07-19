
namespace KeyTools.Lessons.Requests
{
    public class AuthorLessonsRequest : GetLessonsRequest
    {
        private const string URL = "/game/lessons/author/my";
        public AuthorLessonsRequest() : base(URL) { }
    }
}
