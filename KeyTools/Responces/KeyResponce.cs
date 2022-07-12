using System;
using System.Collections.Generic;
using System.Text;

namespace KeyCheckGui
{
    public class KeyResponse
    {
        public string value { get; set; }
        public string details { get; set; }
        public int delay { get; set; }

        public Auth auth{ get; set; }

        public class Auth
        {
            public string token { get; set; }
        }
    }


}
