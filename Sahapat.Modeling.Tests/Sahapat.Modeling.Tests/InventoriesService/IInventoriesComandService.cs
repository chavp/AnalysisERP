using Sahapat.Modeling.Tests.InventoriesService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.InventoriesService
{
    public interface IInventoriesComandService
    {
        OperationResultDTO TransferShipments(List<TransferShipmentsCommandDTO> requests);

        OperationResultDTO AdjustedInventory(Guid inventorytItemShipmentReceiptId);

        OperationResultDTO InventoryPhysicalCount(Guid inventoryId, Guid productId, double actualQuantity);
    }

    
}
