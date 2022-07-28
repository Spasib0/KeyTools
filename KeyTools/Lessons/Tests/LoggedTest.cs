using KeyTools.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace KeyTools.Lessons.Tests
{
    abstract internal class LoggedTest
    {
        protected Logger Logger => _logger;
        private Logger _logger;

        protected LoggedTest(LinkLabel link, string name)
        {
            _logger = new Logger(name);
            link.Click += OpenLog;
        }

        private void OpenLog(object sender, EventArgs e)
        {
            Logger.Open();
        }
    }
}
