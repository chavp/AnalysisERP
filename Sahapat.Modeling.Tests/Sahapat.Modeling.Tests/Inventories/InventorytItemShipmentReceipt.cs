using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.Inventories
{
    public class InventorytItemShipmentReceipt
    {
        public Guid InventorytItemShipmentReceiptId { get; set; }
        public Guid ToInventoryItemId { get; set; }

        public Guid ByShipmentReceiptId { get; set; }

    }
}
