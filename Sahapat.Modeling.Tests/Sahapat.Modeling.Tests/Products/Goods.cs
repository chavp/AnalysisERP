using Sahapat.Modeling.Tests.Parties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.Products
{
    public class Goods : Product
    {
        public string Code { get; set; }
        public DateTime ManufacturedDate { get; set; }
        public PartyRole ManufacturedBy { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
