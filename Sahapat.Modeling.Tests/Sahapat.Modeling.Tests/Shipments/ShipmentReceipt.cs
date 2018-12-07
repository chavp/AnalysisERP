using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.Shipments
{
    public class ShipmentReceipt
    {
        public Guid ShipmentReceiptId { get; set; }
        public Guid PackagingContentId { get; set; }

        public DateTime DateDateReceived { get; set; }
        public double QuantityAccepted { get; set; }
        public double QuantityRejected { get; set; }

        public Guid StoredIntoInventoryItemId { get; set; }
        public Guid ProductId { get; set; }
    }
}
