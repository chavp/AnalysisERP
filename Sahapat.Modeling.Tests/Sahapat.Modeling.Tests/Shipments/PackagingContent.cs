using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.Shipments
{
    public class PackagingContent
    {
        public double Quantity { get; set; }

        public ShipmentItem ContainOf { get; set; }
        public ShipmentPackage InPackage { get; set; }
    }
}
