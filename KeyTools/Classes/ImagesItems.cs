using System.Collections.Generic;

namespace KeyCheckGui
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