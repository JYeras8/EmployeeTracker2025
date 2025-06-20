using DAL;
using DAL.DTO;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PermissionBLL
    {
        public static void AddPermission(Permission permission)
        {
            using (PersonnelDbContext db = new PersonnelDbContext())
            {
                db.Permissions.Add(permission);
                db.SaveChanges();
            }
        }

        public static void DeletePermission(int permissionID)
        {
            using (var db = new PersonnelDbContext())
            {
                try
                {
                    Permission pr = db.Permissions.First(x => x.Id == permissionID);
                    db.Permissions.Remove(pr);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static PermissionDTO GetPermissions()
        {
            PermissionDTO dto = new PermissionDTO();

            using (var db = new PersonnelDbContext())
            {
                dto.Departments = db.Departments.ToList();

                dto.Positions = (from p in db.Positions
                                 join d in db.Departments on p.DeparmentId equals d.Id
                                 select new PositionDTO
                                 {
                                     Id = p.Id,
                                     PositionName = p.PositionName,
                                     DepartmentName = d.DepartmentName,
                                     DepartmentId = d.Id
                                 }).OrderBy(x => x.Id).ToList();

                dto.States = db.PermissionStates.ToList();

                dto.Permission = (from p in db.Permissions
                                  join s in db.PermissionStates on p.PermissionState equals s.Id
                                  join e in db.Employees on p.EmployeeId equals e.Id
                                  join d in db.Departments on e.DepartmentId equals d.Id
                                  join pos in db.Positions on e.PositionId equals pos.Id
                                  select new
                                  {
                                      p.Id,                            // This is the true Permission ID
                                      p.PermissionState,              // Actual permission state
                                      p.PermissionStartDate,
                                      p.PermissionEndDate,
                                      p.PermissionDay,
                                      p.PermissionExplain,

                                      e.EmployeeNo,
                                      e.FirstName,
                                      e.LastName,
                                      e.ImagePath,
                                      e.DepartmentId,
                                      e.PositionId,

                                      StateName = s.StateName,
                                      DepartmentName = d.DepartmentName,
                                      PositionName = pos.PositionName
                                  })
                  .AsEnumerable()
                  .Select(x => new PermissionDetailDTO
                  {
                      PermissionID = x.Id,
                      PermissionState = x.PermissionState,

                      PermissionStateDisplay = x.PermissionState == 1 ? "On Employee" :
                         x.PermissionState == 2 ? "Approved" :
                         x.PermissionState == 3 ? "Denied" : "Unknown",

                      StartDate = x.PermissionStartDate.ToDateTime(new TimeOnly(0, 0)),
                      CompleteDate = x.PermissionEndDate.ToDateTime(new TimeOnly(0, 0)),
                      PermissionDayAmount = x.PermissionDay,
                      Explaination = x.PermissionExplain,

                      EmployeeNo = x.EmployeeNo,
                      FirstName = x.FirstName,
                      LastName = x.LastName,
                      ImagePath = x.ImagePath,
                      DepartmentID = x.DepartmentId,
                      PositionID = x.PositionId,

                      StateName = x.StateName,
                      DepartmentName = x.DepartmentName,
                      PositionName = x.PositionName
                  })
                  .OrderBy(x => x.StartDate)
                  .ToList();
            }
            return dto;
        }

        //Update via Update button on Permission List
        public static void UpdatePermission(Permission permission)
        {
            try
            {
                using (var db = new PersonnelDbContext())
                {
                    var pr = db.Permissions.FirstOrDefault(x => x.Id == permission.Id);
                    if (pr != null)
                    {
                        pr.PermissionStartDate = permission.PermissionStartDate;
                        pr.PermissionEndDate = permission.PermissionEndDate;
                        pr.PermissionExplain = permission.PermissionExplain;
                        pr.PermissionDay = permission.PermissionDay;
                        pr.PermissionState = permission.PermissionState;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Update permission via Approved button in permisions list
        public static void UpdatePermission(int permissionID, int approved)
        {
            try
            {
                using (var db = new PersonnelDbContext())
                {
                    var pr = db.Permissions.FirstOrDefault(x => x.Id == permissionID);
                    if (pr != null)
                    {
                        pr.PermissionState = approved;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    
}