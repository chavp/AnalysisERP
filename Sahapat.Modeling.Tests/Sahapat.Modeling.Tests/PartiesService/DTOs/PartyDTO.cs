﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.PartiesService.DTOs
{
    public class PartyDTO
    {
        public Guid PartyId { get; set; }

        public string PartyType { get; set; }
        public string PartyRole { get; set; }

        public PersonDTO Person { get; set; }
        public PersonDTO OrganizationDTO { get; set; }
    }
}
