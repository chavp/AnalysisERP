using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.Parties
{
    public class PartyContact
    {
        public DateTime? EffectiveFromDate { get; set; }
        public DateTime? EffectiveToDate { get; set; }

        public Party ContactOf { get; set; }
    }

    public class Fax : PartyContact
    {
        public string Number { get; set; }
    }

    public class Phone : PartyContact
    {
        public string Number { get; set; }
    }

    public class PostalAddress : PartyContact
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Number { get; set; }
        public string Street { get; set; }
        public string Khet { get; set; }
        public string Province { get; set; }
        public string PostCode { get; set; }
        public string Tumbon { get; set; }
        public string Aumper { get; set; }
    }
}
