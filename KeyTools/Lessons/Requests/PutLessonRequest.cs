
namespace KeyTools.Lessons.Requests
{
    internal class PutLessonRequest : GetLessonRequest, IPutLessonsRequest
    {
        public override string Method => "PUT";
        public string Data => _data;
        protected string _data;
        internal PutLessonRequest(string url, string data) : base(url)
        {
            _data = data; 
        }
    }
}
