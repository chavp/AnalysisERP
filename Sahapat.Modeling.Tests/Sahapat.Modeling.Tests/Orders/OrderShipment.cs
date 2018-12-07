using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.Orders
{
    public class OrderShipment
    {
        public double Quantity { get; set; }

        public OrderItem ShippedVia { get; set; }

    }
}
