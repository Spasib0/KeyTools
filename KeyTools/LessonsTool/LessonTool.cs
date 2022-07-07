using System;
using System.Collections.Generic;

namespace KeyCheckGui
{
    //LESSON TOOLS PART
    partial class KeyTools
    {
        private const string KEY_LESSONS_URL = "game/lessons/author/my";
        
        private void OnGetMyLessonsClick(object sender, EventArgs e)
        {
            SetSelectedDeviceToken();
            var responce = DownloadJson(KEY_LESSONS_URL);
            var lessonsData = new LessonsData(responce);
        }
    }
}