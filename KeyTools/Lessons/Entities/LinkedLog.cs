using KeyTools.Classes;
using System;
using System.Windows.Forms;

namespace KeyTools.Lessons.Entities
{
    abstract internal class LinkedLog
    {
        protected Logger Logger => _logger;
        private Logger _logger;
        private LinkLabel _link;
        protected const string OPEN_LOG = "Open log";

        protected LinkedLog(LinkLabel link, string name)
        {
            _logger = new Logger(name);
            _link = link;
            _link.Click += OpenLog;
        }

        protected void SetLink(bool state = true, string text = OPEN_LOG)
        {
            _link.Enabled = state;
            _link.Text = text;
        }


        private void OpenLog(object sender, EventArgs e)
        {
            Logger.Open();
        }
    }
}
