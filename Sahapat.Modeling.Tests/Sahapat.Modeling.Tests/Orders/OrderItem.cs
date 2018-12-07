using Sahapat.Modeling.Tests.Inventories;
using Sahapat.Modeling.Tests.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.Orders
{
    public class OrderItem
    {
        public string Code { get; set; }
        public int Seq { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public UnitOfMesure Currency { get; set; }
        public string ShippingInstructions { get; set; }
        public DateTime EstimatedDeliveryDate { get; set; }

        public Order Order { get; set; }

        public Product Product { get; set; }
        public InventoryItem InventoryItem { get; set; }

        public OrderShipment ShippedVia { get; set; }
    }
}