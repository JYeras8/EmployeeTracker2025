﻿using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Salary
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public int Amount { get; set; }

    public int Year { get; set; }

    public int MonthId { get; set; }
}
