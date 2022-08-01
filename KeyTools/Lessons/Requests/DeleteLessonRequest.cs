
namespace KeyTools.Lessons.Requests
{
    class DeleteLessonRequest : GetLessonsRequest
    {
        private const string URL = "/game/lessons/del/";
        public DeleteLessonRequest(string lessonId) : base(URL + lessonId) { }
    }
}
