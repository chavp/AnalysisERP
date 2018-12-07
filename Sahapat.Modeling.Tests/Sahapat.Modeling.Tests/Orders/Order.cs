using Sahapat.Modeling.Tests.Models;
using Sahapat.Modeling.Tests.Parties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.Orders
{
    public class Order : Entity
    {
        public OrderType Type { get; set; }
        public string OrderCode { get; set; }
        public DateTime OrderDate { get; set; }

        public PartyRole PlacedBy { get; set; }
        public PartyRole Fullfiler { get; set; }
        public PartyRole BilledTo { get; set; }
        public DateTime? RequiredDeliveryDate { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }
}
