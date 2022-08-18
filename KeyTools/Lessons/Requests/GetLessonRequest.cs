namespace KeyTools.Lessons.Requests
{
    internal class GetLessonRequest : ILessonsRequest
    {
        public string Url => _url;
        public virtual string Method => "GET";

        private string _url;

        internal GetLessonRequest(string url)
        {
            _url = url;
        }
    }
}
