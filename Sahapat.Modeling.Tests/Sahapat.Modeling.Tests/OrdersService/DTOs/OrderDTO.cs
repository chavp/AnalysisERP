using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.OrderService.DTOs
{
    public class OrderDTO
    {
        public Guid OrderId { get; set; }
        public string OrderCode { get; set; }
        public DateTime OrderDate { get; set; }

        public string OrderStatus { get; set; }
        public string OrderType { get; set; }

        public Guid PlacedByPartyId { get; set; }
        public Guid FulfillerPartyId { get; set; }
        public Guid BillToPartyId { get; set; }

        public List<OrderItemDTO> OrderItemList { get; set; }
    }
}