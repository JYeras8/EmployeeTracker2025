using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Position
{
    public int Id { get; set; }

    public string PositionName { get; set; } = null!;

    public List<Employee> Employees { get; set; } // Navigation property

    public int DeparmentId { get; set; }
}
