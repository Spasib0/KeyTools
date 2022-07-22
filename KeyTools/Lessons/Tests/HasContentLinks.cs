using KeyTools.Classes;
using KeyTools.Lessons.Entities;
using KeyTools.Responces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KeyTools.Lessons.Tests
{
    class HasContentLinks
    {
        private Func<string, LessonLinkedMedia> _getLessonLinks;
        private const string LOG_NAME = "HasContentLinks";
        private Logger logger;

        public HasContentLinks(Func<string, LessonLinkedMedia> getLessonLinks, LinkLabel logLink)
        {
            _getLessonLinks = getLessonLinks;
            logLink.Click += OpenLog;
        }

        public bool Test(List<LessonResponseData> lessons)
        {
            logger = new Logger(LOG_NAME);
            var isPassed = lessons.All(lesson => TestLesson(lesson));
            logger.Save();
            return isPassed;
        }

        private void OpenLog(object sender, EventArgs e)
        {
            logger.Open();
        }

        private bool TestLesson(LessonResponseData data)
        {
            var lessonLinks = _getLessonLinks(data.id.ToString());
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
                logger.Add($"Lesson {data.id} has missing content links:\n");

                if(missingImages.Count > 0)
                {
                    logger.Add($"\tMissing Images: \n\t\t{string.Join("\n\t\t", missingImages)}");
                }

                if (missingSounds.Count > 0)
                {
                    logger.Add($"\tMissing Sounds: \n\t\t{string.Join("\n\t\t", missingSounds)}");
                }
            }

            return isPassed;
        }
    }
}
