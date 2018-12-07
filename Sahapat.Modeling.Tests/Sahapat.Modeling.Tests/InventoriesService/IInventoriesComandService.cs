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
    }

    public class TransferShipmentsCommandDTO
    {
        public Guid ToInventoryItemId { get; set; }
        public Guid ByShipmentReceiptId { get; set; }
    }
}
