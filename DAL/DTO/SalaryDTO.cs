﻿using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class SalaryDTO
    {
        public List<SalaryDetailDTO> Salaries { get; set; }
        public List<EmployeeDetailDTO> Employees { get; set; }

        public List<Month> Months { get; set; }

        public List<Department> Departments { get; set; }

        public List<PositionDTO> Positions {  get; set; }



    }
}
