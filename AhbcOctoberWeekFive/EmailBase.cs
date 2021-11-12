using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcOctoberWeekFive
{
    public abstract class EmailBase
    {
        private string message;

        private string ToAddress { get; set; }
        private string Message { get; set; }

        public abstract void SendEmail();

        public virtual string GetReturn()
        {
            return "";
        }

        public void LogMessage()
        {
            // Log Message
            CreateMessage("stuff");
        }

        private string CreateMessage(string info)
        {
            message = message + info;
            return message;
        }
    }
}
