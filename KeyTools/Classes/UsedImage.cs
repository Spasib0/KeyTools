using System.Collections.Generic;
using System.Linq;

namespace KeyCheckGui
{
    public class UsedImage : NotUsedImage
    {
        private List<TestData> _tests;
        private List<Fact> _facts;

        
        public string Tests => GetTestsUsages();
        public string Facts => GetFactUsages();

        public UsedImage(string id, List<TestData> tests, List<Fact> facts, string svgLink, string pngLink) : base (id, svgLink, pngLink)
        {
            _tests = tests;
            _facts = facts;
        }

        private string GetTestsUsages()
        {
            return string.Join('\n', _tests.Select(test => new string[] { test._id, test.label }));
        }

        private string GetFactUsages()
        {
            return string.Join('\n', _facts.Select(fact => new string[] { fact._id, fact.label }));
        }
    }
}