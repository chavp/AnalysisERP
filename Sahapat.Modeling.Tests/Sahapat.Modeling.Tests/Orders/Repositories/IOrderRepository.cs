using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.Orders.Repositories
{
    public interface IOrderRepository
    {
        Order GetById(Guid id);
    }
}
