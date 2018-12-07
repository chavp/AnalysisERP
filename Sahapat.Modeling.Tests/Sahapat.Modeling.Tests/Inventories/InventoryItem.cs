using Sahapat.Modeling.Tests.Parties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.Inventories
{
    public class InventoryItem
    {
        public string Code { get; set; }
        public double QuantityOnHand { get; set; }

        public Facility LocatedAt { get; set; }
        public Container LocatedWithin { get; set; }

    }
}
