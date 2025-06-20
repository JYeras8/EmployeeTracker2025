using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Permission
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public DateOnly PermissionStartDate { get; set; }

    public DateOnly PermissionEndDate { get; set; }

    public int PermissionState { get; set; }

    public string? PermissionExplain { get; set; }

    public int PermissionDay { get; set; }



}
