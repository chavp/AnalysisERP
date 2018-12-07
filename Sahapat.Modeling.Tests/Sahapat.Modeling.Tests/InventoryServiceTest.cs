using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sahapat.Modeling.Tests
{
    [TestClass]
    public class InventoryServiceTest
    {
        // InventoryService
        // -> ReceivedStockByPackageCode :: OperationResultDTO

        // InventoryService
        // -> AdjustedStockByOrderCode :: OperationResultDTO

        // ShipmentService
        // -> GetShipmentPackagesByOrderCode :: List<ShipmentPackageDTO>
        // -> ReceivedShipmentByOrderCode :: OperationResultDTO

         
        [TestMethod]
        public void GetShipmentPackagesByOrderCode(string orderCode)
        {

        }

        [TestMethod]
        public void ReceivedStockByPackageCode(string packageCode, double quantityRejected)
        {

        }

        [TestMethod]
        public void ReceivedShipmentByOrderCode(string orderCode)
        {

        }

        [TestMethod]
        public void AdjustedStockByOrderCode(string orderCode)
        {

        }
    }

    public class OperationResultDTO
    {
        public List<string> Errors { get; set; }
    }

    public class ReceivedPackagingContentResult : OperationResultDTO
    {
        public Guid ShipmentReceiptId { get; set; }
    }
}
