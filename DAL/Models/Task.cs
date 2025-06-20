﻿using System;
using System.Collections.Generic;


namespace DAL.Models;

public partial class Task
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public string TaskTitle { get; set; } = null!;

    public string? TaskContent { get; set; }

    public DateTime TaskStartDate { get; set; }

    public DateTime TaskDeliveryDate { get; set; }

    public int? TaskState { get; set; }
}
