using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace KeyTools.Lessons.Requests
{
    public interface ILessonsRequest
    {
        public string Url { get; }
        public string Method { get; }
    }
}
