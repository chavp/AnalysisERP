using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.Parties.Repositories
{
    public interface PartyRepository
    {
        Party GetById(Guid id);
    }
}
