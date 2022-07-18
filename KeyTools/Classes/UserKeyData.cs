using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KeyTools.Classes
{
    public class UserKeyData
    {
        public string username { get; set; }
        public string worker { get; set; }
        public string[] roles { get; set; }

        public bool IsModerator => roles != null && roles.Contains(MODERATOR);

        private const string MODERATOR = "ROLE_MODERATOR";
    }
}
