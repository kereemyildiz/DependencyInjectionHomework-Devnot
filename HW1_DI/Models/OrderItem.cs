using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW1_DI.Models
{

    public class OrderItem
    {
        public string Food { get; set; }
        public int Price { get { return Price; } set { Price = 50; } }
    }
}
