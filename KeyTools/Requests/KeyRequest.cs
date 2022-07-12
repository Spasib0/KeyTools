using System;
using System.Collections.Generic;
using System.Text;

namespace KeyCheckGui
{
    public class KeyRequest
    {
        public KeyRequest(string productName, string key, UserHardware userHardware)
        {
            username = key;
            password = "";
            product = productName;
            version = 0;
            hardware = new Hardware(userHardware);
            master = false;
            isTeacher = false;
        }

        public string username { get; set; }
        public string password { get; set; }
        public string product { get; set; }
        public int version { get; set; }
        public Hardware hardware { get; set; }
        public bool master { get; set; }
        public bool isTeacher { get; set; }
    }


}
