using KeyCheckGui;
using KeyTools.Lessons.Entities;
using KeyTools.Responces;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace KeyTools.Lessons.Tests
{
    internal class CanCreateNewLesson : LinkedLog
    {
        private Func<LessonResponseData, JObject> createLesson => LessonsTests.Client.CreateLesson;
        private const string LOG_NAME = "CanCreateNewLesson";
        private const string ELEMENT_ID = "keytools_element_id";
        private const string ELEMENT_TYPE = "FactRequest";
        private const string ELEMENT_LABEL = "KeyTools element";
        private const string LESSON_LABEL = "KeyTools test lesson";
        private const string LESSON_LOGO = "fact_pic_395.svg";
        public CanCreateNewLesson(LinkLabel logLink) : base(logLink, LOG_NAME) { }

        public string Test()
        {
            var lessonData = CardsAppLessonData.CreateNewLesson();
            lessonData.AddElementToLesson(new SerializablePicturesData(ELEMENT_ID, ELEMENT_TYPE, ELEMENT_LABEL, new List<string> { LESSON_LOGO }, new List<string>(), new List<string>()), 0);
            lessonData.SetLabel(LESSON_LABEL);
            lessonData.SetLogo(LESSON_LOGO);

            var res = new SaveLessonResponse(createLesson(new LessonResponseData(lessonData)));
            Logger.Add($"Created lesson - {res.data.id}");
            Logger.Save();

            SetLink();

            return res.data.id.ToString();
        }
    }
}
