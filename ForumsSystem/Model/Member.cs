using System;
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
        ArrayList accounts = new ArrayList()
 ArrayList friends = new ArrayList(); //the friends of the member
        ArrayList<String> subForums = new ArrayList(); //the subforums of the member
        ArrayList<message> messages = new ArrayList<message>(); //the messages of the member
        ArrayList<notification> notifications = new ArrayList<notification>(); //the notification of the member
        ArrayList<complaint> complaints = new ArrayList<complaint>(); //the complaint of the member

        public member(String uniqeid, String password, int forumid) { }

        public void SendNotification(ArrayList<member> mem) { }

    }
}
