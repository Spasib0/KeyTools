using System.Collections.Generic;

namespace KeyCheckGui
{
    public class Fact
    {
        public string _id { get; set; }
        public string dlc { get; set; }
        public int version { get; set; }
        public string label { get; set; }
        public string type { get; set; }
        public List<string> tags { get; set; }
        public string sound { get; set; }
        public int repetitions { get; set; }
        public string image { get; set; }
        public string speech { get; set; }
        public int order { get; set; }
        public string status { get; set; }
        public string comment { get; set; }
        public List<string> resources { get; set; }
        public List<FactSlide> slides { get; set; }
        public string require { get; set; }
    }

    public class FactSlide
    {
        public float time { get; set; }
        public string[] pictures { get; set; }
        public List<LanguageTime> times { get; set; }
        public string text { get; set; }

        public struct LanguageTime
        {
            public Language language { get; set; }
            public float time { get; set; }
        }
    }

    public class Language
    {
    }
}