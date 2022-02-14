using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace KeyCheckGui.Dialogs
{
    public partial class CheckedImagesIdsDialog : Form
    {
        private readonly IResultData _data;

        public CheckedImagesIdsDialog(IResultData data)
        {
            InitializeComponent();
            _data = data;
            resultTypeBox.DataSource = data.Result.Keys.ToList();
            resultTypeBox.SelectedIndexChanged += UpdateResultList;
            resultList.SelectedIndexChanged += ResultList_SelectedIndexChanged;
            resultList.Items.AddRange(_data.Result[resultTypeBox.SelectedItem.ToString()]);
        }

        private void ResultList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = resultList.SelectedItem as IResultItem;
        }

        private void UpdateResultList(object sender, EventArgs e)
        {
            resultList.Items.AddRange(_data.Result[resultTypeBox.SelectedItem.ToString()]);
        }

        private void OnSvgLink_LinkClick(object sender, LinkLabelLinkClickedEventArgs e)
        {

            var process = new ProcessStartInfo
            {
                FileName = ((LinkLabel)sender).Text,
                UseShellExecute = true
            };

            Process.Start(process);
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
