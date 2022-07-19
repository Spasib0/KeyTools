using KeyTools.Classes;
using KeyTools.Lessons.Requests;

namespace KeyTools.Lessons.Entities
{
    public class LessonsClient
    {
        private KeyToolsClient _client;

        private const string PUT = "PUT";

        public LessonsClient(KeyToolsClient client)
        {
            _client = client;
        }

        public string Call(ILessonsRequest request)
        {
            switch (request.Method)
            {
                case PUT:
                    return Put(request as PutLessonRequest);
                default:
                    return Get(request);
            }
        }

        private string Get(ILessonsRequest request)
        {
            return _client.GetRequest(request.Url);
        }

        private string Put(PutLessonRequest request)
        {
            return _client.PutRequest(request.Url, request.Data);
        }
    }
}
