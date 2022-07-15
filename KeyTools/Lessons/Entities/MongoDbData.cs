using Newtonsoft.Json;
using System;

namespace KeyTools.Lessons.Entities
{
    [Serializable]
    public class MongoDbData
    {
        public string _id;
        public int version;
        public string dlc;

        [JsonIgnore] public string Dlc => dlc;

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            return obj is MongoDbData data && _id == data._id;
        }

        public override int GetHashCode()
        {
            return _id.GetHashCode();
        }

        public string GetId()
        {
            return _id;
        }

        public int GetVersion()
        {
            return version;
        }

        public MongoDbData()
        {

        }

        public MongoDbData(string id, int version)
        {
            _id = id;
            this.version = version;
        }
    }
}