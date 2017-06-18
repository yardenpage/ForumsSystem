using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumsSystem.Model
{
    class Security: Policy
    {

        bool showPassword;
        bool askForPassword;
        bool askForUserName;
        bool askForMail;
        bool showFriends;

        public Security getSP() {
            return new Security();
        }

    }
}
