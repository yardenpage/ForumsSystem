using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumsSystem.Model
{
    class Account
    {
        string uniqueName;
        string password;
        Forum forum;
        Member mem;
        public Account(Member m, string uniqueName, string password, Forum f) { }

    }
}
