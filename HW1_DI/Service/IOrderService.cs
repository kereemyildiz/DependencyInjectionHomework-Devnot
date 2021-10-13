using HW1_DI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW1_DI.Service
{
    public interface IOrderService
    {
        List<OrderItem> GetOrders();
        void Add(OrderItem newOrderItem);
    }
}
