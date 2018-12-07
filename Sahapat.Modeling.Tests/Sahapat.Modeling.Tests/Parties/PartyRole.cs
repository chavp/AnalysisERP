using Sahapat.Modeling.Tests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.Parties
{
    public class PartyRole : Entity
    {
        public Party RoleFor { get; set; }

        public DateTime? EffectiveFromDate { get; set; }
        public DateTime? EffectiveToDate { get; set; }
    }
}
