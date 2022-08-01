namespace KeyTools.Lessons.Requests
{
    internal class UserDataRequest : GetLessonsRequest
    {
        private const string URL = "/game/my";

        public UserDataRequest() : base(URL) { }
    }
}
