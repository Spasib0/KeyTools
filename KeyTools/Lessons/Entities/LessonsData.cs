using KeyTools.Responces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace KeyTools.Lessons.Entities
{
    public class LessonsData
    {
        public int Count => _lessons.Count;
        public string[] StringIds => _lessons.Select(lesson => lesson.id.ToString()).ToArray();
        public List<LessonResponseData> Lessons => _lessons;
        private List<LessonResponseData> _lessons;
        
        public LessonsData(string response)
        {
            var objData = (JArray)JsonConvert.DeserializeObject(response);
            _lessons = objData == null
                ? TryParseLesson(response)
                : objData.Select(lessonResponse => new LessonResponseData(lessonResponse)).ToList();
        }

        private List<LessonResponseData> TryParseLesson(string response)
        {
            var lesson = new LessonResponseData(((JToken)JsonConvert.DeserializeObject(response)).Value<JToken>("data"));

            return lesson == null ? new List<LessonResponseData>() : new List<LessonResponseData>{ lesson };
        }
    }
}