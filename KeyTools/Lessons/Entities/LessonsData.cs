using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace KeyTools.Lessons.Entities
{
    public class LessonsData
    {
        public int Count => _data.Count;
        private List<LessonResponseData> _data;
        
        public LessonsData(string responce)
        {
            var objData = (JArray)JsonConvert.DeserializeObject(responce);
            _data = objData == null
                ? new List<LessonResponseData>()
                : objData.Select(lessonResponse => new LessonResponseData(lessonResponse)).ToList();
        }
    }
}