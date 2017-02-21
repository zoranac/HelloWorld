using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.Server.Models
{
    public class Message
    {

        private string _messageText;

        public string MessageText
        {
            get { return _messageText; }
            set { _messageText = value; }
        }

        public Message(string text)
        {
            MessageText = text;
        }
    }
}