namespace KeyTools.Lessons.Requests
{
    public class UserDataRequest : GetLessonsRequest
    {
        private const string URL = "/game/my";

        public UserDataRequest() : base(URL) { }
    }
}
