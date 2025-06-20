using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Employee
{
    public int Id { get; set; }

    public int EmployeeNo { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string ImagePath { get; set; } = null!;

    public int DepartmentId { get; set; }

    public int PositionId { get; set; }

    public Position Position { get; set; } //use this for casade

    public int Salary { get; set; }

    public DateTime Birthday { get; set; }

    public string? Address { get; set; }

    public string? Password { get; set; }

    public bool? IsAdmin { get; set; }
}
