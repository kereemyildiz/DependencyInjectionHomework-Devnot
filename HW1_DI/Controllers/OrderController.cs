using HW1_DI.Models;
using HW1_DI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW1_DI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ISMSSender smsSender;
        private readonly IOrderService orderService;
        private readonly ICreditCardService credit;
        private readonly IUserGuidGenerator guid;
        private readonly IOrderDbService dbService;

        public OrderController(ISMSSender smsSender, IOrderService orderService, ICreditCardService credit, IUserGuidGenerator guid, IOrderDbService dbService )
        {
            this.smsSender = smsSender;
            this.orderService = orderService;
            this.credit = credit;
            this.guid = guid;
            this.dbService = dbService;
        }

        [HttpPost]
        public IActionResult Add([FromBody] Order order)
        {
            if(ModelState.IsValid)
            {
                orderService.Add(order.order[0]);
                //dbService.Add ... db operations
                // ...
                smsSender.SendMessage(guid.Guid);
                return Ok();
            }
            return BadRequest(ModelState);
        }
    }
}
