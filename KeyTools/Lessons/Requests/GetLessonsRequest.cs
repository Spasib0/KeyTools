using System;
namespace KeyTools.Lessons.Requests
{
    internal class GetLessonsRequest : ILessonsRequest
    {
        public string Url => _url;
        public virtual string Method => "GET";

        private string _url;

        internal GetLessonsRequest(string url)
        {
            _url = url;
        }
    }
}
