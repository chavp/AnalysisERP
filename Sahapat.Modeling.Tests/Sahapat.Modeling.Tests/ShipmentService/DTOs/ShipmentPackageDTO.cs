using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.ShipmentServiceModels
{
    public class ShipmentPackageDTO
    {
        public Guid ShipmentId { get; set; }
        public Guid ShipmentPackageId { get; set; }
        public string PackageCode { get; set; }
        public DateTime PackageDateCreated { get; set; }

        public Guid OrderId { get; set; }

        public string ShipmentNumber { get; set; }
        public string ShipmentPackageNumber { get; set; }

        public List<PackageContainDTO> PackageContainList { get; set; }
    }
}
