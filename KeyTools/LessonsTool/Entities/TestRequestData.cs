using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyCheckGui
{
    public class TestRequestData : ICreateInstanceDelegate<TestRequestData>
    {
        [JsonRequired] internal readonly string testType;
        [JsonRequired] internal readonly List<int> rightAnswers;
        [JsonRequired] internal readonly List<int> placedImages;

        [JsonIgnore] private Func<TestRequestData, TestRequestData> createInstance;

        [JsonIgnore]
        public Func<TestRequestData, TestRequestData> CreateInstance
        {
            get
            {
                if (createInstance == null)
                {
                    createInstance = instance => new TestRequestData(instance);
                }
                return createInstance;
            }
        }

        public TestRequestData(TestRequestData data)
        {
            rightAnswers = new List<int>(data.rightAnswers);
            testType = data.testType;
            placedImages = data.placedImages;
        }

        public TestRequestData(string testType, List<int> rightAnswers, List<int> placedImages)
        {
            this.rightAnswers = new List<int>(rightAnswers);
            this.testType = testType;
            this.placedImages = placedImages;
        }

        [JsonConstructor]
        public TestRequestData(JObject jData)
        {
            rightAnswers = new List<int>(jData.Value<JArray>("rightAnswers")?.ToObject<List<int>>() ?? new List<int>());
            testType = jData.Value<string>("testType");
            placedImages = new List<int>(jData.Value<JArray>("placedImages")?.ToObject<List<int>>() ?? new List<int>());
        }

        public override int GetHashCode()
        {
            return testType.GetHashCode() ^ rightAnswers.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is TestRequestData requestData))
                return false;

            var baseEquals = testType == requestData.testType && rightAnswers.Count == requestData.rightAnswers.Count;

            if (baseEquals)
            {
                return rightAnswers.SequenceEqual(requestData.rightAnswers)
                    && placedImages.SequenceEqual(requestData.placedImages);
            }

            return false;
        }
    }

    public interface ICreateInstanceDelegate<T> where T : class
    {
        [JsonIgnore]
        Func<T, T> CreateInstance { get; }
    }
}