using System;
using System.Collections.Generic;


namespace DAL.Models;

public partial class TaskState
{
    public int Id { get; set; }

    public string StateName { get; set; } = null!;
}
