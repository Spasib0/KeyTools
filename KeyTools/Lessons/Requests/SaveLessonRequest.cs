using KeyTools.Lessons.Entities;
using Newtonsoft.Json;

namespace KeyTools.Lessons.Requests
{
    public class SaveLessonRequest
    {
        public CardsAppLessonData content;
        public bool personal;

        [JsonConstructor]
        public SaveLessonRequest(CardsAppLessonData lesson, bool personal)
        {
            content = lesson;
            this.personal = personal;
        }
    }
}
