using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace KeyCheckGui
{
    public class LessonResponseData : BaseLessonResponseData
    {
        public CardsAppLessonData content;

        public static LessonResponseData CreateNewLesson()
        {
            return new LessonResponseData();
        }

        public LessonResponseData()
        {
            id = -1;
            author = "";
            school = "";
            updated = "";
            personal = false;
            origin = "";
            forks = 0;
            views = 0;
            checkedTime = new DateTime(2000, 1, 1, 12, 0, 0, DateTimeKind.Utc);
            content = CardsAppLessonData.CreateNewLesson();
        }

        public LessonResponseData(CardsAppLessonData content)
        {
            id = content.Id;
            author = "";
            school = "";
            updated = "";
            personal = false;
            origin = "";
            forks = 0;
            views = 0;
            checkedTime = new DateTime(2000, 1, 1, 12, 0, 0, DateTimeKind.Utc);
            this.content = content; // тут умышленно ссылка передаётся
        }

        [JsonConstructor]
        public LessonResponseData(long id, string author, string school, string updated, bool personal, string origin, int forks, int views, DateTime checkedTime, CardsAppLessonData content)
        {
            this.id = id;
            this.author = author;
            this.school = school;
            this.updated = updated;
            this.personal = personal;
            this.origin = origin;
            this.forks = forks;
            this.views = views;
            this.checkedTime = checkedTime;
            this.content = content; // тут умышленно ссылка передаётся. Выше в иерархии вызовов делаются новые экземпляры content
        }

        public LessonResponseData(JToken jLessonResponseObj) : base(jLessonResponseObj)
        {
            if (jLessonResponseObj.Value<JObject>("content") != null)
                content = new CardsAppLessonData(jLessonResponseObj.Value<JObject>("content"));
        }

        public LessonResponseData(LessonResponseData newData)
        {
            id = newData.id;
            author = newData.author;
            school = newData.school;
            updated = newData.updated;
            personal = newData.personal;
            origin = newData.origin;
            forks = newData.forks;
            views = newData.views;
            checkedTime = newData.checkedTime;
            content = new CardsAppLessonData(newData.content, newData.id);
        }

        public LessonResponseData(MediaLessonResponseData newData)
        {
            id = newData.id;
            author = newData.author;
            school = newData.school;
            updated = newData.updated;
            personal = newData.personal;
            origin = newData.origin;
            forks = newData.forks;
            views = newData.views;
            checkedTime = newData.checkedTime;
            content = new CardsAppLessonData(newData.content, newData.id);
        }

        public static LessonResponseData FromHddData(long id, CardsAppLessonData content)
        {
            return new LessonResponseData(id, "", "", "", false, "", 0, 0, new DateTime(2000, 1, 1, 12, 0, 0, DateTimeKind.Utc), content);
        }

        public void SetId(long newId)
        {
            id = newId;
            content.SetId(newId);
        }

        public void SetPersonal(bool personal)
        {
            this.personal = personal;
        }
    }
}