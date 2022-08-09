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
        
        public LessonsData(string responce)
        {
            var objData = (JArray)JsonConvert.DeserializeObject(responce);
            _lessons = objData == null
                ? new List<LessonResponseData>()
                : objData.Select(lessonResponse => new LessonResponseData(lessonResponse)).ToList();
        }
    }
}