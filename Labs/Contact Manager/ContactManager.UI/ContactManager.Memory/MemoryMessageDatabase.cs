// Carlos Fuentes
// 11/4/2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ContactManager
{
    public class MemoryMessageDatabase : MessageSendDatabase

    {
        protected override void SendCore(Message message)
        {
            _items.Add(message);
        }

        //Abstracts message from where it sends from user
        protected override IEnumerable<Message> GetAllCore()
        {
            return from item in _items
                   select new Message()
                   {
                       MessageName = item.MessageName,
                       MessageEmailAddress = item.MessageEmailAddress,
                       MessageSubject = item.MessageSubject,
                       MessageContent = item.MessageContent,
                   };
        }

        private List<Message> _items = new List<Message>();
    }
}