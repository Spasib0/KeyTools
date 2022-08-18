namespace KeyTools.Lessons.Requests
{
    class DeleteLessonRequest : GetLessonRequest
    {
        private const string URL = "/game/lessons/del/";
        public DeleteLessonRequest(string lessonId) : base(URL + lessonId) { }
    }
}
