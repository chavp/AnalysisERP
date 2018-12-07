using Sahapat.Modeling.Tests.ShipmentService.DTOs;
using Sahapat.Modeling.Tests.ShipmentServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.ShipmentService
{
    public interface IShipmentQueryService
    {
        IList<ShipmentPackageDTO> GetShipmentPackagesByOrderCode(string orderCode);
        IList<ShipmentReceiptDTO> GetShipmentReceiptByPackageCode(string packageCode);

        OperationResultDTO ReceivedStockByPackageCode(string packageCode, double quantityRejected);
    }
}
