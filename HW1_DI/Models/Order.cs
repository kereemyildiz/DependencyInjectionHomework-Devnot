using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW1_DI.Models
{
    public class Order
    {
        public List<OrderItem> order;

        public Guid customerGuid;
        public CreditCardInfo Card{ get; set; }

    }
}
