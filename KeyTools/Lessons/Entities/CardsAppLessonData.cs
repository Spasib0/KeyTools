using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyTools.Lessons.Entities
{
    public class CardsAppLessonData
    {
        [JsonRequired] private long id;
        [JsonRequired] private string label;
        [JsonRequired] private string description;
        [JsonRequired] private string logo;
        [JsonRequired] private List<SerializablePicturesData> objectsInLesson;
        [JsonRequired] private List<string> themes;
        [JsonRequired] private List<MongoDbData> nextLessons;
        [JsonRequired] private List<string> options;
        [JsonRequired] private List<string> tags;
        [JsonRequired] private RejectReason review;
        [JsonRequired] private List<string> products;

        public const string FACT_ELEMENT_TYPE = "Fact";
        public const string TEST_ELEMENT_TYPE = "Test";
        public const string FACT_REQUEST_ELEMENT_TYPE = "FactRequest";
        public const string TEST_REQUEST_ELEMENT_TYPE = "TestRequest";
        public const string PUPIL_SLIDE = "PupilSlide";

        public const string SEARCH_PLAYER_KEY = "Player";
        public const string LESSON_PLAYER_DEFAULT = "DefaultPlayer";
        public const string LESSON_PLAYER_STRICT = "StrictPlayer";
        public const string LESSON_PLAYER_QUEST = "QuestPlayer";
        public const string LESSON_PLAYER_PRACTICE = "PracticePlayer";
        public const string LESSON_PLAYER_NONE = "NonePlayer";

        [JsonIgnore]
        public List<SerializablePicturesData> ObjectsInLesson => objectsInLesson;
        [JsonIgnore]
        public HashSet<string> Themes { get; private set; }
        [JsonIgnore]
        public HashSet<string> Tags { get; private set; }
        [JsonIgnore]
        public HashSet<MongoDbData> NextLessons { get; private set; }
        [JsonIgnore]
        public HashSet<string> Options { get; private set; }
        [JsonIgnore]
        public long Id => id;
        [JsonIgnore]
        public string Label => label;
        [JsonIgnore]
        public string Description => description;
        [JsonIgnore]
        public string Logo => logo;
        [JsonIgnore]
        public RejectReason Review => review;
        [JsonIgnore]
        public List<string> Products => products;
        [JsonIgnore]
        public string PlayerType
        {
            get
            {
                return Options.Any(option => option.Contains(SEARCH_PLAYER_KEY)) ? Options.First(option => option.Contains(SEARCH_PLAYER_KEY)) : LESSON_PLAYER_DEFAULT;
            }
        }

        [JsonIgnore]
        public bool QuestPracticeType
        {
            get
            {
                var playerType = PlayerType;
                return playerType == LESSON_PLAYER_QUEST || playerType == LESSON_PLAYER_PRACTICE;
            }
        }

        [JsonIgnore] 
        public bool IsWellFormedLesson => !QuestPracticeType || QuestPracticeElementsCount > 0;

        [JsonIgnore]
        public int QuestPracticeElementsCount => objectsInLesson.Count(obj => obj.type == TEST_ELEMENT_TYPE || obj.type == TEST_REQUEST_ELEMENT_TYPE || obj.type == PUPIL_SLIDE);

        public static CardsAppLessonData CreateNewLesson()
        {
            return new CardsAppLessonData();
        }

        private CardsAppLessonData()
        {
            id = -1;
            description = "";
            label = "";
            logo = "";
            objectsInLesson = new List<SerializablePicturesData>();
            tags = new List<string>();
            options = new List<string>();
            nextLessons = new List<MongoDbData>();
            themes = new List<string>();
            Options = new HashSet<string>();
            Themes = new HashSet<string>();
            Tags = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            NextLessons = new HashSet<MongoDbData>();
            review = RejectReason.Empty();
            products = new List<string>();
        }

        public CardsAppLessonData(CardsAppLessonData lessonData, long id) // тут даём айди от сущности хранящейся на сервере а не от местного айди
        {
            this.id = id;
            description = lessonData.description;
            label = lessonData.label;
            logo = lessonData.logo;
            objectsInLesson = new List<SerializablePicturesData>(lessonData.objectsInLesson);
            tags = new List<string>(lessonData.Tags);
            options = new List<string>(lessonData.Options);
            nextLessons = new List<MongoDbData>(lessonData.NextLessons);
            themes = new List<string>(lessonData.Themes);
            Options = new HashSet<string>(options);
            Themes = new HashSet<string>(themes);
            Tags = new HashSet<string>(tags, StringComparer.OrdinalIgnoreCase);
            NextLessons = new HashSet<MongoDbData>(nextLessons);
            review = new RejectReason(lessonData.review);
            products = new List<string>(lessonData.products);
        }

        [JsonConstructor]
        public CardsAppLessonData(JObject jLessonObject)
        {
            id = jLessonObject.Value<long>("id");
            description = jLessonObject.Value<string>("description");
            label = jLessonObject.Value<string>("label");
            logo = jLessonObject.Value<string>("logo");
            CreateObjectsInLesson(jLessonObject);
            tags = new List<string>(jLessonObject.Value<JArray>("tags")?.ToObject<List<string>>() ?? new List<string>());
            options = new List<string>(jLessonObject.Value<JArray>("options")?.ToObject<List<string>>() ?? new List<string>());
            nextLessons = new List<MongoDbData>(jLessonObject.Value<JArray>("nextLessons")?.ToObject<List<MongoDbData>>() ?? new List<MongoDbData>());
            themes = new List<string>(jLessonObject.Value<JArray>("themes")?.ToObject<List<string>>() ?? new List<string>());
            review = jLessonObject.Value<JObject>("review") != null ? new RejectReason(jLessonObject.Value<JObject>("review")) : RejectReason.Empty();
            products = new List<string>(jLessonObject.Value<JArray>("products")?.ToObject<List<string>>() ?? new List<string>());
            Options = new HashSet<string>(options);
            Themes = new HashSet<string>(themes);
            Tags = new HashSet<string>(tags, StringComparer.OrdinalIgnoreCase);
            NextLessons = new HashSet<MongoDbData>(nextLessons);
        }

        private void CreateObjectsInLesson(JToken jLessonObject)
        {
            objectsInLesson = new List<SerializablePicturesData>();

            foreach (var objData in jLessonObject.Value<JArray>("objectsInLesson"))
            {
                var pictureData = objData.ToObject<SerializablePicturesData>();

                switch (objData.Value<string>("type"))
                {
                    case TEST_REQUEST_ELEMENT_TYPE:
                        var testRequestData = objData.Value<JObject>("entity") != null ? new TestRequestData(objData.Value<JObject>("entity")) : new TestRequestData("", new List<int>(), new List<int>());
                        var pictureDataGeneric = new SerializablePicturesData<TestRequestData>(pictureData, testRequestData);

                        if (string.IsNullOrEmpty(testRequestData.testType) || testRequestData.rightAnswers?.Count < 1)
                        {
                            Console.WriteLine("Not valid data in lessonObject: " + pictureDataGeneric._id + " in lesson: " + id + " Not adding this element to lesson. Lesson is broken! Alarm! Go to support!");
                            break;
                        }

                        objectsInLesson.Add(pictureDataGeneric);
                        break;
                    case PUPIL_SLIDE:
                        var pupilSlideData = objData.Value<JObject>("entity")?.ToObject<PupilSlideData>() ?? new PupilSlideData(true, true, true);
                        var dataGeneric = new SerializablePicturesData<PupilSlideData>(pictureData, pupilSlideData);

                        objectsInLesson.Add(dataGeneric);
                        break;
                    default:
                        objectsInLesson.Add(pictureData);
                        break;
                }
            }
        }

        public void AddElementToLesson(SerializablePicturesData serializableData, int position)
        {
            var newData = CopyHiddenDataAndInstantiate(serializableData);
            AddElementByPosition(position, newData);
            //        Debug.Log("Add fact: " + serializableData._id + " in position: " + (objectsInLesson.Count - 1) + " in lesson: " + id);
        }

        public static SerializablePicturesData CopyHiddenDataAndInstantiate(SerializablePicturesData serializableData) // todo  попробовать избавиться от этого и попытаться научиться вытаскивать SerializablePicturesData<T>.Entity в абстракцию
        {
            switch (serializableData.type)
            {
                case TEST_REQUEST_ELEMENT_TYPE:
                    return new SerializablePicturesData<TestRequestData>(serializableData as SerializablePicturesData<TestRequestData>);
                case PUPIL_SLIDE:
                    return new SerializablePicturesData<PupilSlideData>(serializableData as SerializablePicturesData<PupilSlideData>);
                default:
                    return new SerializablePicturesData(serializableData);
            }
        }

        private void AddElementByPosition(int position, SerializablePicturesData data)
        {
            if (position < 0)
            {
                objectsInLesson.Add(data);
            }
            else
            {
                objectsInLesson.Insert(position, data);
            }
        }

        public void SetId(long newId)
        {
            id = newId;
        }

        public void SetProducts(string[] newProducts)
        {
            products = newProducts.ToList();
        }

        public void SetLabel(string newLabel)
        {
            label = newLabel;
        }

        public void SetLogo(string logoId)
        {
            logo = logoId;
        }
    }
}