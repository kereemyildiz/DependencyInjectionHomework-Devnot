using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW1_DI.Models
{
    public class EmailSenders : IEmailSender
    {
        public void SendMessage(Guid guid)
        {
            Console.WriteLine($"Email has been sent to {guid}");
        }
    }

    public class SMSSender : ISMSSender
    {
        public void SendMessage(Guid guid)
        {
            Console.WriteLine($"SMS has been sent to {guid}");
        }
    }
}
