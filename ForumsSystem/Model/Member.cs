using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumsSystem.Model
{
    class Member
    {
        String uniqeid;
        ArrayList groups = new ArrayList(); //the groups of the member
        ArrayList accounts = new ArrayList();
        ArrayList friends = new ArrayList(); //the friends of the member
        ArrayList subForums = new ArrayList(); //the subforums of the member
        ArrayList messages = new ArrayList(); //the messages of the member
        ArrayList  notifications = new ArrayList(); //the notification of the member
        ArrayList  complaints = new ArrayList(); //the complaint of the member

        public Member(string uniqeid, string password, int forumid) {
                }

        public void SendNotification(ArrayList mem) { }

    }
}
