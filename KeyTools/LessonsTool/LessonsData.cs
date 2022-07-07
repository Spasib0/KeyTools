using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace KeyCheckGui
{
    public class LessonsData
    {
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