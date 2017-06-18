using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumsSystem.Model
{
    class Discussion
    {
        string subject;
        SubForum m_subForums;
        ArrayList updates = new ArrayList(); //the updates of the discussion
        ArrayList messages = new ArrayList(); //the messages of the discussion
        int openMessage;// first message Of discassion
        int iD;
        public void addByOpenMessage(Message m) { }
        public void addAsOpenMessage(Message m) { }
        public Message GetOpen() { }

    }
}
