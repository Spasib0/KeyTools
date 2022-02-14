using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace KeyCheckGui
{
    public class Content
    {
        // Content[product]
        public Dictionary<StatisticsProduct, ProductContent> items;
        public int TestsCount => _tests.Count;
        public int FactsCount => _facts.Count;
        public int ImagesCount => _svgImages.Count;
        public int DataCount => TestsCount + FactsCount + ImagesCount;

        private List<TestData> _tests;
        private List<Fact> _facts;
        private Dictionary<string, string> _svgImages;
        private Dictionary<string, string> _pngImages;
        private Dictionary<string, string> _my_svg_images;
        private string IMAGES_SVG_LINKS_URL = "course/resources/images";
        private string IMAGES_URL = "res/images";
        private string MY_IMAGES_URL = "res/images/my";
        private string MY_PNG_IMAGES_URL = "res/images/my/png";

        public Content(StatisticsProduct[] products, Func<string, string> getData)
        {
            items = new Dictionary<StatisticsProduct, ProductContent>();
            _facts = new List<Fact>();
            _tests = new List<TestData>();
            SetContent(products, getData);
        }


        public ImagesUsageData GetImagesUsage(string[] ids)
        {
            List<NotUsedImage> notUsedImages = new List<NotUsedImage>();
            List<UsedImage> usedImages = new List<UsedImage>();

            foreach (string imageID in ids)
            {
                var testsWithImage = _tests.Where(test => test.images.Any(image => image.Equals(imageID))).ToList();
                var factsWithImage = _facts.Where(fact => fact.image.Equals(imageID) || fact.slides != null && fact.slides.Any(image => image.Equals(imageID))).ToList();

                if (testsWithImage.Count == 0 && factsWithImage.Count == 0)
                {
                    notUsedImages.Add(new NotUsedImage(imageID, GetSvgImageLink(imageID), GetPngImageLink(imageID)));
                }
                else
                {
                    usedImages.Add(new UsedImage(imageID, testsWithImage, factsWithImage, GetSvgImageLink(imageID), GetPngImageLink(imageID)));
                }
            }

            return new ImagesUsageData(usedImages, notUsedImages);
        }





        private void SetContent(StatisticsProduct[] products, Func<string, string> getData)
        {
            _svgImages = JsonSerializer.Deserialize<ImagesData>(getData(IMAGES_SVG_LINKS_URL)).values;

            foreach (var product in products)
            {
                items[product] = new ProductContent(product, getData);
            }
            
            UnionData();
            GetImages(getData);
            SetMyImagesSvg(getData);
            SetMyImagesPng(getData);
        }

        private void UnionData()
        {
            foreach(var data in items.Values)
            {
                _tests = _tests.Union(data.Tests).ToList();
                _facts = _facts.Union(data.Facts).ToList();
            }
        }

        private void GetImages(Func<string, string> getData)
        {
            var res = JsonSerializer.Deserialize<ImagesData>(getData(IMAGES_URL));
        }

        private void SetMyImagesSvg(Func<string, string> getData)
        {
            var res = getData(MY_IMAGES_URL);
            _my_svg_images = JsonSerializer.Deserialize<ImagesItems>(res).items.ToDictionary(item => item.key, item => item.value);

        }

        private void SetMyImagesPng(Func<string, string> getData)
        {
            var res = getData(MY_PNG_IMAGES_URL);
            _pngImages = JsonSerializer.Deserialize<ImagesItems>(res).items.ToDictionary(item => item.key, item => item.value);
        }

        internal Image GetPngImage(string id)
        {
            //return DownloadImage(GetPngImageLink(id));
            return null;
        }

        private string GetPngImageLink(string id)
        {
            var pngId = id.Split('.')[0] + ".png";

            if (_pngImages.ContainsKey(pngId))
                return _pngImages[pngId];
            else
                return "Has not png image for " + pngId;
        }

        public string GetSvgImageLink(string id)
        {
            if(_svgImages.ContainsKey(id))
                return _svgImages[id];
            else
                return "Has not svgmage for " + id;
        }



        public class ProductContent
        {
            internal StatisticsProduct id;
            internal List<TestData> Tests => _tests.items;
            internal List<Fact> Facts => _facts.items;
            private string _testJson;
            private string _factJson;
            private TestsObject _tests;
            private FactsObject _facts;

            private string TESTS_URL => $"game/course/knowledge/tests/object/{id}";
            private string FACTS_URL => $"game/course/knowledge/facts/object/{id}";

            public ProductContent(StatisticsProduct id, Func<string, string> getJson)
            {
                this.id = id;
                SetData(getJson);
            }

            private void SetData(Func<string, string> getJson)
            {
                _testJson = getJson(TESTS_URL);
                _factJson = getJson(FACTS_URL);
                _tests = GetObject<TestsObject>(_testJson);
                _facts = GetObject<FactsObject>(_factJson);
            }

            private T GetObject<T>(string json)
            {
                return JsonSerializer.Deserialize<T>(json);
            }
        }
    }
}