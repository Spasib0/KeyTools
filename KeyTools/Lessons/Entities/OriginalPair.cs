using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KeyTools.Lessons.Entities
{
    public class OriginalPair : Pair
    {
        [JsonRequired] protected string original;

        [JsonIgnore]
        public string Original => original;

        public OriginalPair(string key, string value, string original) : base(key, value)
        {
            this.original = original;
        }

        public string GetSpeechLink()
        {
            return string.IsNullOrEmpty(original) ? value : original; //TODO тут логика потеряна
        }

        [JsonConstructor]
        public OriginalPair(JToken jPair) : base(jPair)
        {
            if (jPair == null)
            {
                original = "";
                return;
            }
            original = jPair.Value<JToken>("original")?.ToObject<string>() ?? "";
        }
    }
}