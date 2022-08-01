
namespace KeyTools.Lessons.Requests
{
    internal class PutLessonRequest : GetLessonsRequest, IPutLessonsRequest
    {
        public override string Method => "PUT";
        public string Data => _data;
        private string _data;
        internal PutLessonRequest(string url, string data) : base(url)
        {
            _data = data; 
        }
    }
}
