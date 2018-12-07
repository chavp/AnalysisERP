using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.ShipmentServiceModels
{
    public class PackageContainDTO
    {
        public Guid PackageContainId { get; set; }
        public double ContainQuantity { get; set; }

        public Guid ShipmentItemId { get; set; }
        public Guid ProductId { get; set; }
        public Guid OrderShipmentId { get; set; }
        public Guid OrderItemId { get; set; }

    }
}
