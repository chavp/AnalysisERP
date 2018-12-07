using Sahapat.Modeling.Tests.Parties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.Products
{
    public class Service
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public PartyRole Provider { get; set; }
    }
}
