using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KeyTools.Dialogs
{
    public partial class PngImageDialog : Form
    {
        public PngImageDialog(string id, Image image)
        {
            InitializeComponent();
            Text = id;
            imageBox.Image = image;
        }
    }
}
