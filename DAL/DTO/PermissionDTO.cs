﻿using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class PermissionDTO
    {
        public List<Department> Departments { get; set; }
        public List<PositionDTO> Positions { get; set; }

        public List<PermissionState> States { get; set; }

        public List<PermissionDetailDTO> Permission { get; set; }
    }
}
