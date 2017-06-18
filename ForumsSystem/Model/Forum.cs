using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumsSystem.Model
{
    class Forum
    {
        int foromId;
        Account c_acoount;
        Policy[] policy;
        ArrayList subforums = new ArrayList(); //the subForums of the forum.
        ArrayList MangerID = new ArrayList();      //The ID of all the admins of the forum.
        ArrayList membersID = new ArrayList();     //The ID of all the member of the forum.

        public void addMember(Account a, Member m) { }
        public void addSubForum(SubForum sb) { }

        public Leader getLeader(string leaderId) { }
        public Admin getAdmin(string adminId) { }
        public Complaint getComplaint(string complaintId) { }

    }
}
