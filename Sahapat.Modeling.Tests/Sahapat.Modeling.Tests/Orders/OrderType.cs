using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.Orders
{
    public class OrderType
    {
        /// <summary>
        /// Example. SalesOrder, PurchaseOrder, WorkOrder
        /// </summary>
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
