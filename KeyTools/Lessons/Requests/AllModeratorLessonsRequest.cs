namespace KeyTools.Lessons.Requests
{
    class AllModeratorLessonsRequest : ModeratorLessonsRequest
    {
        public AllModeratorLessonsRequest(bool personal) : base(ModeratorSearchRequest.SearchAllLessons(personal, 99)) { }
    }
}
