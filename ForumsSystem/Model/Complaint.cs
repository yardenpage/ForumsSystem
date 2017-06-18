using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumsSystem.Model
{
    class Complaint
    {
        string content;
        int Id;
        int SubForum;
        Admin Admin;
        Leader[] leaders;
        Member member;
    }
}
