using KeyTools.Classes;
using KeyTools.Lessons.Requests;
using KeyTools.Responces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace KeyTools.Lessons.Entities
{
    public class LessonsClient
    {
        private KeyToolsClient _client;
        private string[] products;

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

        public void SetProducts(string[] newProducts)
        {
            products = newProducts;
        }

        public LessonsData GetKeyLessons()
        {
            return new LessonsData(Call(new SchoolLessonsRequest()));
        }

        public LessonLinkedMedia GetLessonLinkedMedia(string id)
        {
            var lessonObj = (JObject)JsonConvert.DeserializeObject(Call(new LessonWithContent(id)));
            return new LessonLinkedMedia(new SaveMediaLessonResponse(lessonObj).data.content.media);
        }

        public JObject UpdateLesson(LessonResponseData lesson)
        {
            lesson.content.SetProducts(products);
            var lessonObj = (JObject)JsonConvert.DeserializeObject(Call(new UpdateLessonRequest(lesson)));
            return lessonObj;
        }

        public LessonsData GetAuthorLessons()
        {
            return new LessonsData(Call(new AuthorLessonsRequest()));
        }

        public JObject CreateFork(string id)
        {
            return (JObject)JsonConvert.DeserializeObject(Call(new CreateForkRequest(id)));
        }

        public JObject DeleteLesson(string id)
        {
            return (JObject)JsonConvert.DeserializeObject(Call(new DeleteLessonRequest(id)));
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
