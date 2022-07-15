using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace KeyTools.Lessons.Entities
{
    public class SerializablePicturesData<T> : SerializablePicturesData where T : class, ICreateInstanceDelegate<T>
    {
        [JsonRequired] private readonly T entity;
        [JsonIgnore] public T Entity => entity;

        public SerializablePicturesData(SerializablePicturesData<T> data) : base(data)
        {
            entity = data.entity.CreateInstance(data.entity);
        }

        public SerializablePicturesData(string _id, string type, string label, List<string> images, List<string> customImages, List<string> sounds, T data) : base(_id, type, label, images, customImages, sounds)
        {
            entity = data.CreateInstance(data);
        }

        [JsonConstructor]
        public SerializablePicturesData(SerializablePicturesData data, T entityData) : base(data)
        {
            entity = entityData.CreateInstance(entityData);
        }

        public override int GetHashCode()
        {
            return _id.GetHashCode() ^ images.GetHashCode() ^ sounds.GetHashCode() ^ entity.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is SerializablePicturesData<T> data))
                return false;

            var baseEquals = _id == data._id
                             && label == data.label;

            if (!baseEquals)
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

            return entity.Equals(data.entity); // todo вероятно проверка должна быть менее жесткой // Todo 2 ДА ЭТО ЖЕСТКО!(с)
        }
    }
}