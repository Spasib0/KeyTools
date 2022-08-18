using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KeyTools.Classes
{
    public class ImagesUsageData : CheckedData
    {
        public override Dictionary<string, IResultItem[]> Result => _resultData;  
        private Dictionary<string, IResultItem[]> _resultData;
        private const string notUsedImageResultTypeText = "Not used images";
        private const string usedImageResultTypeText = "Used images";
        private List<NotUsedImage> _notUsedImages;
        private List<UsedImage> _usedImages;

        public ImagesUsageData(List<UsedImage> usedImages, List<NotUsedImage> notUsedImages)
        {
            _usedImages = usedImages;
            _notUsedImages = notUsedImages;
            _resultData = GetResultData();
        }

        private object OnSelectItem(string type, string id) //todo
        {
            object res; 
            switch (type)
            {
                case usedImageResultTypeText:
                    res = _usedImages.FirstOrDefault(item => item.Id == id);
                    break;
                default:
                    res = _notUsedImages.FirstOrDefault(item => item.Id == id);
                    break;
            }

            return res;
        }

        private Dictionary<string, IResultItem[]> GetResultData()
        {
            return new Dictionary<string, IResultItem[]>()
            {
                { notUsedImageResultTypeText, _notUsedImages.ToArray() },
                { usedImageResultTypeText, _usedImages.ToArray() }
            };
        }
    }
}