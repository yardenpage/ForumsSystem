using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumsSystem.Model
{
    class Message
    {
        public enum messageKind
        {
            open,
            comment
        }
        Discussion m_discussion;
        Member m_member;
        Notification c_notification;
        Message[] messages;
        string title;
        string content;
        int Id;
        string Sender;
        string reciver;
        DateTime date;
        public Message(string subject, string content, messageKind mk, string title) { }
    }
}
