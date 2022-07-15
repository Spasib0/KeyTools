using Newtonsoft.Json;
using System;

namespace KeyTools.Lessons.Entities
{
    public class PupilSlideData : ICreateInstanceDelegate<PupilSlideData>
    {
        public readonly bool textAnswer;
        public readonly bool pictureAnswer;
        public readonly bool soundAnswer;

        [JsonIgnore] private Func<PupilSlideData, PupilSlideData> createInstance;

        [JsonIgnore]
        public Func<PupilSlideData, PupilSlideData> CreateInstance
        {
            get { return createInstance ??= instance => new PupilSlideData(instance); }
        }

        public PupilSlideData(PupilSlideData data)
        {
            textAnswer = data.textAnswer;
            pictureAnswer = data.pictureAnswer;
            soundAnswer = data.soundAnswer;
        }

        [JsonConstructor]
        public PupilSlideData(bool textAnswer, bool pictureAnswer, bool soundAnswer)
        {
            this.textAnswer = textAnswer;
            this.pictureAnswer = pictureAnswer;
            this.soundAnswer = soundAnswer;
        }

        public override int GetHashCode()
        {
            return textAnswer.GetHashCode() ^ pictureAnswer.GetHashCode() ^ soundAnswer.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is PupilSlideData data))
                return false;

            return data.pictureAnswer == pictureAnswer && data.soundAnswer == soundAnswer && data.textAnswer && textAnswer;
        }
    }
}