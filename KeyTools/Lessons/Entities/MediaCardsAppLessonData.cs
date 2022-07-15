using Newtonsoft.Json.Linq;

namespace KeyTools.Lessons.Entities
{
    public class MediaCardsAppLessonData : CardsAppLessonData
    {
        public readonly Media media;
        public MediaCardsAppLessonData(JObject jLessonObject) : base(jLessonObject)
        {
            media = new Media(jLessonObject.Value<JObject>("media"));
        }

        public class Media
        {
            public readonly OriginalPair[] speeches;
            public readonly Pair[] images;
            public readonly Pair[] sounds;

            public Media(JObject jObject)
            {
                var jSpeeches = jObject.Value<JArray>("speeches");
                var jImages = jObject.Value<JArray>("images");
                var jSounds = jObject.Value<JArray>("sounds");

                speeches = new OriginalPair[jSpeeches.Count];
                images = new Pair[jImages.Count];
                sounds = new Pair[jSounds.Count];

                for (var i = 0; i < jSpeeches.Count; i++)
                {
                    speeches[i] = new OriginalPair(jSpeeches[i]);
                }

                for (var i = 0; i < jImages.Count; i++)
                {
                    images[i] = new Pair(jImages[i]);
                }

                for (var i = 0; i < jSounds.Count; i++)
                {
                    sounds[i] = new Pair(jSounds[i]);
                }
            }
        }
    }
}
