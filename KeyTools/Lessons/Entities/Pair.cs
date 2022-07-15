using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KeyTools.Lessons.Entities
{
    [Serializable]
    public class Pair
    {
        [JsonRequired] protected string key;
        [JsonRequired] protected string value;

        [JsonIgnore]
        public string Key => key;
        [JsonIgnore]
        public string Value => value;

        public Pair(string key, string value)
        {
            this.key = key;
            this.value = value;
        }

        [JsonConstructor]
        public Pair(JToken jPair)
        {
            if (jPair == null)
            {
                key = "";
                value = "";
                return;
            }

            key = jPair.Value<JToken>("key")?.ToObject<string>() ?? "";
            value = jPair.Value<JToken>("value")?.ToObject<string>() ?? "";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            return obj is Pair data && key == data.key;
        }

        public override int GetHashCode()
        {
            return key.GetHashCode();
        }

        public void SetValue(string value)
        {
            this.value = value;
        }
    }
}