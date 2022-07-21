using System;
using System.Linq;

namespace KeyTools.Lessons.Entities
{
    public class LessonLinkedMedia
    {
        private string[] _images;
        private string[] _sounds;
        private string[] _speeches;

        public LessonLinkedMedia(MediaCardsAppLessonData.Media data)
        {
            _images = GetKeys(data.images);
            _sounds = GetKeys(data.sounds);
            _speeches = GetKeys(data.speeches);
        }

        public bool HasImage(string id)
        {
            return _images.Contains(id);
        }

        public bool HasSound(string id)
        {
            return _sounds.Contains(id) || _speeches.Contains(id);
        }


        private string[] GetKeys(Pair[] pairs)
        {
            return pairs.Where(pair => !string.IsNullOrEmpty(pair.Value)).Select(pair => pair.Key).ToArray();
        }
    }
}
