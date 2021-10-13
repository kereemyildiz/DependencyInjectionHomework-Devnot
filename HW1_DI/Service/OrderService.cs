using HW1_DI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW1_DI.Service
{
    public class OrderService : IOrderService
    {
        private List<OrderItem> order;
        private readonly IUserGuidGenerator customerGuid;

        public OrderService(List<OrderItem> order, IUserGuidGenerator customerGuid)
        {
            this.order = order;
            this.customerGuid = customerGuid;
        }
        public List<OrderItem> GetOrders()
        {
            return order;
        }

        public void Add(OrderItem newOrder)
        {
            this.order.Add(newOrder);
        }
    }
}
