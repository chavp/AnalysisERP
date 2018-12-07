using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.Shipments.Repositories
{
    public interface IShipmentReceiptRepository
    {
        int Insert(ShipmentReceipt newItem);
    }
}
