using System;
using System.Collections.Generic;

namespace KeyTools.Lessons.Entities
{
    [Serializable]
    public class SearchLessonsRequest : BaseSearchLessonsRequest
    {
        internal string label;
        internal string author;
        internal List<string> themes;
        internal List<string> tags;
        internal List<string> options;

        public SearchLessonsRequest(string label, string author, List<string> themes, List<string> tags, List<string> options, long offset, int limit) : base(offset, limit)
        {
            this.label = label;
            this.author = author;
            this.themes = new List<string>(themes);
            this.tags = tags != null ? new List<string>(tags) : new List<string>();
            this.options = options != null ? new List<string>(options) : new List<string>();
        }

        public static SearchLessonsRequest SearchByRecommendedLimit(string label, string author, List<string> themes, List<string> tags, List<string> options, long offset)
        {
            return new SearchLessonsRequest(label, author, themes, tags, options, offset, RECOMMENDED_LIMIT);
        }

        public static SearchLessonsRequest SearchAllLessonsInWorld(long offset)
        {
            return SearchByRecommendedLimit("", "", new List<string>(), new List<string>(), new List<string>(), offset);
        }
    }

    [Serializable]
    public class BaseSearchLessonsRequest
    {
        public int limit;
        public long offset;

        public const string INITIAL = "initial";
        public const string REVIEWED = "reviewed";
        public const string UPDATED = "updated";
        public const string ALL = "all";

        public const int RECOMMENDED_LIMIT = 99; // ДОЛЖНО РОВНО ДЕЛИТЬСЯ НА AllLessonsView.ViewElements.Count; Сейчас на 3

        public BaseSearchLessonsRequest(long offset, int limit)
        {
            this.limit = limit;
            this.offset = offset;
        }
    }

    [Serializable]
    public class ModeratorSearchRequest : BaseSearchLessonsRequest
    {
        public bool personal;
        public string status;

        public ModeratorSearchRequest(bool personal, string status, long offset, int limit) : base(offset, limit)
        {
            this.personal = personal;
            this.status = status;
        }

        public static ModeratorSearchRequest SearchInitialLessons(bool personal, long offset)
        {
            return new ModeratorSearchRequest(personal, INITIAL, offset, RECOMMENDED_LIMIT);
        }

        public static ModeratorSearchRequest SearchReviewedLessons(bool personal, long offset)
        {
            return new ModeratorSearchRequest(personal, REVIEWED, offset, RECOMMENDED_LIMIT);
        }

        public static ModeratorSearchRequest SearchUpdatedLessons(bool personal, long offset)
        {
            return new ModeratorSearchRequest(personal, UPDATED, offset, RECOMMENDED_LIMIT);
        }

        public static ModeratorSearchRequest SearchAllLessons(bool personal, long offset)
        {
            return new ModeratorSearchRequest(personal, ALL, offset, RECOMMENDED_LIMIT);
        }
    }
}
