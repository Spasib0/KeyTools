using KeyCheckGui;
using KeyTools.Classes;
using KeyTools.Lessons.Entities;
using KeyTools.Responces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KeyTools.Lessons.Tests
{
    internal class HasContentLinks : LinkedLog
    {
        private Func<string, LessonLinkedMedia> getLessonLinks => LessonsTests.Client.GetLessonLinkedMedia;
        private const string LOG_NAME = "HasContentLinks";

        public HasContentLinks(LinkLabel logLink) : base(logLink, LOG_NAME) { }

        public bool Test(List<LessonResponseData> lessons)
        {
            var isPassed = lessons.All(lesson => TestLesson(lesson));
            Logger.Save();
            return isPassed;
        }


        private bool TestLesson(LessonResponseData data)
        {
            var lessonLinks = getLessonLinks(data.id.ToString());
            List<string> missingImages = new List<string>();
            List<string> missingSounds = new List<string>();

            foreach (var item in data.content.ObjectsInLesson)
            {
                foreach (var image in item.customImages)
                {
                    if (!lessonLinks.HasImage(image))
                    {
                        missingImages.Add(image);
                    }
                }

                foreach (var sound in item.sounds)
                {
                    if (!lessonLinks.HasSound(sound))
                    {
                        missingSounds.Add($"Not have link to sound - {sound}");
                    }
                }
            }

            var isPassed = missingImages.Count == 0 && missingSounds.Count == 0;

            if (!isPassed)
            {
                Logger.Add($"Lesson {data.id} has missing content links:\n");

                if(missingImages.Count > 0)
                {
                    Logger.Add($"\tMissing Images: \n\t\t{string.Join("\n\t\t", missingImages)}");
                }

                if (missingSounds.Count > 0)
                {
                    Logger.Add($"\tMissing Sounds: \n\t\t{string.Join("\n\t\t", missingSounds)}");
                }
            }

            return isPassed;
        }
    }
}
