using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class PermissionState
{
    public int Id { get; set; }

    public string StateName { get; set; } = null!;
}
