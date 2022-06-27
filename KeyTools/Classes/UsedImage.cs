using System.Collections.Generic;
using System.Linq;

namespace KeyCheckGui
{
    public class UsedImage : NotUsedImage
    {
        private List<TestData> _tests;
        private List<Fact> _facts;

        
        public List<TestData> Tests => _tests;
        public List<Fact> Facts => _facts;

        public UsedImage(string id, List<TestData> tests, List<Fact> facts, string svgLink, string pngLink) : base (id, svgLink, pngLink)
        {
            _tests = tests;
            _facts = facts;
        }
    }
}