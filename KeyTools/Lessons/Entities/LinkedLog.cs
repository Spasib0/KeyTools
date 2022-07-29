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

        protected LinkedLog(LinkLabel link, string name)
        {
            _logger = new Logger(name);
            _link = link;
            _link.Click += OpenLog;
        }

        protected void SetEnabled(bool state)
        {
            _link.Enabled = state;
        }

        protected void SetLinkText(string text)
        {
            _link.Text = text;
        }

        private void OpenLog(object sender, EventArgs e)
        {
            Logger.Open();
        }
    }
}
