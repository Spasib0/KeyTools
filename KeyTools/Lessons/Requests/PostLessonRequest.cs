namespace KeyTools.Lessons.Requests
{
    internal class PostLessonRequest : PutLessonRequest
    {
        public override string Method => "POST";

        internal PostLessonRequest(string url, string data) : base(url, data) { } 
    }
}
