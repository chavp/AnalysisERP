using Sahapat.Modeling.Tests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.Parties
{
    public class Party : Entity
    {
        public PostalAddress Address { get; set; }
    }
}
