using Newtonsoft.Json.Linq;
using System;
using System.Globalization;

namespace KeyTools.Responces
{
    public class BaseLessonResponseData
    {
        internal long id;
        internal string author;
        internal string school;
        internal string updated;
        internal bool personal;
        internal string origin;
        internal int forks;
        internal int views;
        internal DateTime checkedTime;

        public BaseLessonResponseData()
        {

        }

        public BaseLessonResponseData(JToken jLessonResponseObj)
        {
            id = jLessonResponseObj.Value<long>("id");
            author = jLessonResponseObj.Value<string>("author");
            school = jLessonResponseObj.Value<string>("school");
            updated = jLessonResponseObj.Value<string>("updated");
            personal = jLessonResponseObj.Value<bool>("personal");
            origin = jLessonResponseObj.Value<string>("origin");
            forks = jLessonResponseObj.Value<int>("forks");
            views = jLessonResponseObj.Value<int>("views");
            checkedTime = jLessonResponseObj.Value<string>("checked") != null ? DateTime.Parse(jLessonResponseObj.Value<string>("checked"), CultureInfo.InvariantCulture) : BaseResponse.CUSTOM_DATE_TIME;
        }
    }
}
