using HW1_DI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW1_DI.Service
{
    public class CreditCardService : ICreditCardService
    {
        public CreditCardInfo Card { get; set; }
        public CreditCardInfo GetCreditCardInfo()
        {
            return Card;
        }
    }
}
