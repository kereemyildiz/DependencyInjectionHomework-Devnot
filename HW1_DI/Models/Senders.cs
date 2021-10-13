using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW1_DI.Models
{
    public class EmailSenders : IEmailSender
    {
        public void SendMessage()
        {
            Console.WriteLine($"Email has been sent");
        }
    }

    public class SMSSender : ISMSSender
    {
        public void SendMessage()
        {
            Console.WriteLine($"SMS has been sent");
        }
    }
}
