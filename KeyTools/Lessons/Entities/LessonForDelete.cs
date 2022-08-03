
namespace KeyTools.Lessons.Entities
{
    internal class LessonForDelete
    {
        public string Id => _id;
        public string Description => _description;
        private string _id;
        private string _description;

        public LessonForDelete(string id, string description)
        {
            _id = id;
            _description = description;
        }
    }
}
