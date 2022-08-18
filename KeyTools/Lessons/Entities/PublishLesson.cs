using System.Collections.Generic;

namespace KeyTools.Lessons.Entities
{
    public class PublishLesson
    {
        public long id;
        public bool personal;
        public HashSet<string> products;

        public PublishLesson(long lessonId, bool personal, HashSet<string> products)
        {
            id = lessonId;
            this.personal = personal;
            this.products = products;
        }
    }
}
