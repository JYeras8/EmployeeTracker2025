using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Month
{
    public int Id { get; set; }

    public string MonthName { get; set; } = null!;
}
