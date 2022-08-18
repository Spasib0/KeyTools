using System.Collections.Generic;

namespace KeyTools.Classes
{
    public class ImagesItems
    {
        public List<ImageItem> items { get; set; }


        public class ImageItem
        {
            public string key { get; set; }
            public string value { get; set; }

        }
    }
}