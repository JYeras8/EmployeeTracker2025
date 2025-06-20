using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Department
{
    public int Id { get; set; }

    public string DepartmentName { get; set; } = null!;
}
