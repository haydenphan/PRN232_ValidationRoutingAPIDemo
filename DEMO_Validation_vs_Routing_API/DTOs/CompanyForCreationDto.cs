﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class CompanyForCreationDto : CompanyForManipulationDto
    {
        public IEnumerable<EmployeeForCreationDto> Employees { get; set; }
    }

}
