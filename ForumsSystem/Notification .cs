using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumsSystem
{
    class Notification
    {
        int Id;
        string IdSender;
        string content;
        ArrayList recivers = new ArrayList(); //the recivers of the notification
        int subForum;
        int discussionId;
    }
}
