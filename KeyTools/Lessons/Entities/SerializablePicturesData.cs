using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace KeyTools.Lessons.Entities
{
    public class SerializablePicturesData
    {
        public readonly string _id;
        public readonly string type;
        public readonly string label; // у FactRequest здесь лежит hidden. Если вдруг захочется label настоящий, добавлять в конец названия hidden
        public List<string> images;
        public readonly List<string> customImages;
        public readonly List<string> sounds;
        public SerializablePicturesData(SerializablePicturesData data)
        {
            _id = data._id;
            type = data.type;
            label = data.label;

            if (data.images != null)
                images = new List<string>(data.images);
            if (data.sounds != null)
                sounds = new List<string>(data.sounds);
            if (data.customImages != null)
                customImages = new List<string>(data.customImages);
        }

        [JsonConstructor]
        public SerializablePicturesData(string _id, string type, string label, List<string> images, List<string> customImages, List<string> sounds)
        {
            this._id = _id;
            this.type = type;
            this.label = label;

            if (images != null)
                this.images = new List<string>(images);
            if (sounds != null)
                this.sounds = new List<string>(sounds);
            if (customImages != null)
                this.customImages = new List<string>(customImages);
        }

        public void UpdateImages(List<string> images)
        {
            this.images = new List<string>(images);
        }

        public override int GetHashCode()
        {
            if (type == CardsAppLessonData.FACT_REQUEST_ELEMENT_TYPE || type == CardsAppLessonData.TEST_REQUEST_ELEMENT_TYPE)
                return _id.GetHashCode() ^ type.GetHashCode() ^ images.GetHashCode() ^ sounds.GetHashCode();
            return _id.GetHashCode() ^ type.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is SerializablePicturesData))
                return false;

            var data = (SerializablePicturesData)obj;

            var baseEquals = _id == data._id && type == data.type && label == data.label;

            if (!baseEquals)
                return false;

            if (type == CardsAppLessonData.FACT_ELEMENT_TYPE || type == CardsAppLessonData.TEST_ELEMENT_TYPE)
                return true;

            if (images?.Count != data.images?.Count)
                return false;

            if (sounds?.Count != data.sounds?.Count)
                return false;

            if (images == null)
            {
                if (data.images != null)
                    return false;
            }
            else
            {
                if (data.images != null && !images.SequenceEqual(data.images))
                    return false;
            }

            if (sounds == null)
            {
                if (data.sounds != null)
                    return false;
            }
            else
            {
                if (data.sounds != null && !sounds.SequenceEqual(data.sounds))
                    return false;
            }

            return true;
        }
    }
}