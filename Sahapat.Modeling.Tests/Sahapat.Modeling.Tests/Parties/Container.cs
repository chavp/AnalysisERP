using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.Parties
{
    public class Container
    {
        public Facility LocatedAt { get; set; }
    }

    public class Shelf: Container
    {
        public string Location { get; set; }
    }

    public class Bin : Container
    {
        public string Code { get; set; }
    }

    public class Room : Container
    {
        public string Number { get; set; }
        public string Floor { get; set; }
    }

    public class Region : Container
    {
        public string Name { get; set; }
        public string Position { get; set; }
    }
}
