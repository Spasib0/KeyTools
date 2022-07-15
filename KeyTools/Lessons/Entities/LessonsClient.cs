using KeyTools.Classes;
using Newtonsoft.Json;
using System;


namespace KeyTools.Lessons.Entities
{
    public class LessonsClient
    {
        private KeyToolsClient _client;

        private const string KEY_LESSONS_URL = "game/lessons/author/my";
        private const string ALL_WORLD_LESSONS_URL = "game/lessons/new";

        public LessonsClient(KeyToolsClient client)
        {
            _client = client;
        }

        public LessonsData GetKeyLessons()
        {
            var response = _client.GetRequest(KEY_LESSONS_URL);
            return new LessonsData(response);
        }

        public LessonsData GetAllWorldLessons()
        {
            var response = _client.PutRequest(ALL_WORLD_LESSONS_URL, JsonConvert.SerializeObject(ModeratorSearchRequest.SearchAllLessons(true, 99)));
            return new LessonsData(response);
        }
    }
}
