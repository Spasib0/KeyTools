﻿namespace KeyTools.Lessons.Requests
{
    internal class LessonByIdRequest : GetLessonsRequest
    {
        private const string URL = "/game/lessons/";
        private string _id;

        public LessonByIdRequest(string id) : base (URL + id) 
        {
            _id = id;
        }
    }
}
