using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.ShipmentService.DTOs
{
    public class ShipmentReceiptDTO
    {
        public Guid ShipmentReceiptId { get; set; }
        public DateTime DateReceived { get; set; }
        public double QuantityAccepted { get; set; }
        public double QuantityRejected { get; set; }
    }
}
