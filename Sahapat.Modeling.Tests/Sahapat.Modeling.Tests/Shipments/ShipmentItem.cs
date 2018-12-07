using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.Shipments
{
    public class ShipmentItem
    {
        public int Seq { get; set; }
        public double Quantity { get; set; }
        public string ShipmentContentDescription { get; set; }

        public Guid FromInventoryItemId { get; set; }
        public Guid ToInventoryItemId { get; set; }
    }
}
