using KeyTools.Classes;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace KeyTools.Dialogs
{
    public partial class CheckedImagesIdsDialog : Form
    {
        private readonly IResultData _data;
        private readonly ImageLink _svgLink;
        private readonly ImageLink _pngLink;

        public CheckedImagesIdsDialog(IResultData data)
        {
            InitializeComponent();
            _data = data;
            _svgLink = new ImageLink(svgLink);
            _pngLink = new ImageLink(pngLink);
            resultTypeBox.DataSource = data.Result.Keys.ToList();
            resultTypeBox.SelectedIndexChanged += UpdateResultList;
            resultList.SelectedIndexChanged += ResultList_SelectedIndexChanged;
            resultList.Items.AddRange(_data.Result[resultTypeBox.SelectedItem.ToString()]);
        }

        private void ResultList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = resultList.SelectedItem as IResultItem;
            UpdateViewData(selected);
        }

        private void UpdateViewData(IResultItem item)
        {
            _svgLink.Set((item as NotUsedImage).SvgLink);
            _pngLink.Set((item as NotUsedImage).PngLink);

            bool used = item is UsedImage;

            if (used)
            {
                testsList.Items.Clear();
                testsList.Items.AddRange((item as UsedImage).Tests.Select(test => $"{test._id} [{test.dlc}]").ToArray());
                factsList.Items.Clear();
                factsList.Items.AddRange((item as UsedImage).Facts.Select(fact => $"{fact._id} [{fact.dlc}]").ToArray());
            }
            else
            {
                testsList.Items.Clear();
                factsList.Items.Clear();
            }

            testsList.Enabled = used;
            factsList.Enabled = used;

        }

        private void UpdateResultList(object sender, EventArgs e)
        {
            resultList.Items.Clear();
            resultList.Items.AddRange(_data.Result[resultTypeBox.SelectedItem.ToString()]);
        }

        private void OnPngImageButton_Click(object sender, EventArgs e)
        {
            string id = resultList.SelectedItem.ToString();
            new PngImageDialog(id, DownloadImage(id));

        }

        private void OnSvgImageButton_Click(object sender, EventArgs e)
        {
            string id = resultList.SelectedItem.ToString();

        }

        private Image DownloadImage(string url)
        {
            using (System.Net.WebClient webClient = new System.Net.WebClient())
            {
                using (Stream stream = webClient.OpenRead(url))
                {
                    return Image.FromStream(stream);
                }
            }
        }
    }
}
