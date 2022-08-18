using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KeyTools.Dialogs
{
    public partial class SvgImageDialog : Form
    {
        public SvgImageDialog(string url)
        {
            webView21.Update();
            webView21.Source = new Uri(url);
            InitializeComponent();
        }

    }
}
