using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.Models
{
    public abstract class Entity 
        : Version
    {
        public Guid Id { get; set; }
    }
}
