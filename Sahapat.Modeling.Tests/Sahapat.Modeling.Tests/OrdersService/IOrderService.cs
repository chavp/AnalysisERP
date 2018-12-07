using Sahapat.Modeling.Tests.OrderService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.OrderService
{
    public interface IOrderService
    {
        IList<OrderDTO> GetShipmentPackagesByOrderCode(Guid orderId);
    }
}
