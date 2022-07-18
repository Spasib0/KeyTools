using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace KeyTools.Lessons.Requests
{
    public class GetLessonsRequest : ILessonsRequest
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
