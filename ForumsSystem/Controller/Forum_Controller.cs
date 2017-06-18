using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumsSystem.Controller
{
    class Forum_Controller
    {
        public Forum getForum(int forumid) { }
        public bool isaMember(int id) { }
        public Member getUser(string id) { }
        public void CreateNewMember(string username, string password, Forum f) { }
        public void AddNewAccount(string username, string password, int forumId) { }
        public void AddMessage(string subjest, string content, string m, MessageKind mk) { }
        public void notifyMemberAddedGroup(int gId, int mId) { }
        public void CreateNewSubForum(string subject, int forumid) { }
        public void removeLeader(string userName, int subForumId)

    }
}
