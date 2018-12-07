using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.PartiesService.DTOs
{
    public class PersonDTO
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Code { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
