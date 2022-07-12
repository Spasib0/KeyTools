using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KeyCheckGui
{
    //LESSON TOOLS PART
    partial class KeyTools
    {
        private const string KEY_LESSONS_URL = "game/lessons/author/my";
        private const string ALL_WORLD_LESSONS_URL = "game/lessons/new";


        private void OnGetMyLessonsClick(object sender, EventArgs e)
        {
            SetSelectedDeviceToken();
            var response = GetRequest(KEY_LESSONS_URL);
            var lessonsData = new LessonsData(response);
        }

        private void OnGetAllWorldLessonsClick(object sender, EventArgs e)
        {
            var response = PutRequest(ALL_WORLD_LESSONS_URL, JsonConvert.SerializeObject(ModeratorSearchRequest.SearchAllLessons(true, 99)));
            var lessonsData = new LessonsData(response);
        }
    }
}
