using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumsSystem.Model
{
    class SubForum
    {
        int Id;
        string subject;
        int forumId;
        ArrayList leaders = new ArrayList(); //the leaders of the subForum
        ArrayList groups = new ArrayList(); //the leaders of the subForum
        ArrayList complains = new ArrayList(); //the leaders of the subForum

        public void getGroup(int groupId) { }
        public void createSubForum(string subject, ArrayList leaders) { }
        public void addComplainToLeader(string userName) { }
        public int getNumOfComplainToLeader(string userName) {
            return 7;
        }
        public void removeLeader(string userName) { }

    }
}
