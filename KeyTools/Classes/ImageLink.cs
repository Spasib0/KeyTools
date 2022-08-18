using System.Diagnostics;
using System.Windows.Forms;

namespace KeyTools.Classes
{
    internal class ImageLink
    {
        private LinkLabel link;
        private const string enable = "Link";
        private const string disable = "None";
        private string url;

        public ImageLink(LinkLabel link)
        {
            this.link = link;
            link.Click += Link_Click;
        }



        public void Set(string url = null)
        {
            this.url = url;
            Update();
        }

        public void Update()
        {
            link.Enabled = !string.IsNullOrEmpty(url);
            link.Text = string.IsNullOrEmpty(url) ? disable : enable;
        }

        private void Link_Click(object sender, System.EventArgs e)
        {
            var process = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };

            Process.Start(process);
        }
    }
}