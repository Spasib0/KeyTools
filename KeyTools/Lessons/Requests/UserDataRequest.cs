namespace KeyTools.Lessons.Requests
{
    internal class UserDataRequest : GetLessonRequest
    {
        private const string URL = "/game/my";

        public UserDataRequest() : base(URL) { }
    }
}
