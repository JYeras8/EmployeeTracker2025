using DAL.DTO;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace BLL
{
    public class EmployeeBLL
    {
        public static EmployeeDTO GetEmployeeData()
        {
            EmployeeDTO dto = new EmployeeDTO();

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

                var employees = db.Employees.ToList();
                var departments = db.Departments.ToList();
                var positions = db.Positions.ToList();
                var salaries = db.Salaries.ToList();

                var latestSalaries = salaries
                    .GroupBy(s => s.EmployeeId)
                    .Select(g => new
                    {
                        EmployeeId = g.Key,
                        LatestAmount = g
                            .OrderByDescending(x => x.Year * 100 + x.MonthId)
                            .FirstOrDefault()?.Amount ?? 0
                    })
                    .ToList();

                dto.Employees = (from e in employees
                                 join d in departments on e.DepartmentId equals d.Id
                                 join p in positions on e.PositionId equals p.Id
                                 join s in latestSalaries on e.Id equals s.EmployeeId into salGroup
                                 from salary in salGroup.DefaultIfEmpty()
                                 select new EmployeeDetailDTO
                                 {
                                     EmployeeNo = e.EmployeeNo,
                                     FirstName = e.FirstName,
                                     LastName = e.LastName,
                                     ID = e.Id,
                                     DepartmentID = e.DepartmentId,
                                     PositionID = e.PositionId,
                                     DepartmentName = d.DepartmentName,
                                     PositionName = p.PositionName,
                                     Salary = salary != null ? salary.LatestAmount : 0,
                                     ImagePath = e.ImagePath,
                                     Birthday = e.Birthday,
                                     Address = e.Address,
                                     IsAdmin = e.IsAdmin ?? false,
                                     Password = e.Password
                                 }).OrderBy(x => x.FirstName).ToList();
            }

            return dto;
        }

        public void AddEmployee(Employee employee)
        {
            try
            {
                using (var db = new PersonnelDbContext())
                {
                    db.Employees.Add(employee);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;  // this exactly matches your teacher
            }
        }

        public static bool IsIDUnique(int v)
        {
            using (var db = new PersonnelDbContext())
            {
                return !db.Employees.Any(x => x.EmployeeNo == v);
            }
        }
        public static List<Employee> GetEmployees(int userNo, string password)
        {
            using (var db = new PersonnelDbContext())
            {
                return db.Employees
                         .Where(e => e.EmployeeNo == userNo && e.Password == password)
                         .ToList();
            }
        }

        public static void UpdateEmployee(Employee employee)
        {
            try
            {
                using (var db = new PersonnelDbContext())
                {
                    var emp = db.Employees.First(x => x.Id == employee.Id);
                    emp.EmployeeNo = employee.EmployeeNo;
                    emp.FirstName = employee.FirstName;
                    emp.LastName = employee.LastName;
                    emp.Password = employee.Password;
                    emp.IsAdmin = employee.IsAdmin;
                    emp.Birthday = employee.Birthday;
                    emp.Address = employee.Address;
                    emp.DepartmentId = employee.DepartmentId;
                    emp.PositionId = employee.PositionId;
                    emp.Salary = employee.Salary;
                    emp.ImagePath = employee.ImagePath;

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdateEmployee(Position position)
        {
            using (var db = new PersonnelDbContext())
            {
                List<Employee> list = db.Employees
                                        .Where(x => x.PositionId == position.Id)
                                        .ToList();

                foreach (var item in list)
                {
                    item.DepartmentId = position.DeparmentId;
                }

                db.SaveChanges(); // Use SaveChanges() for Entity Framework
            }
        }

        public static void DeleteEmployee(int iD)
        {
            using (var db = new PersonnelDbContext())
            {
                try
                {
                    Employee emp=db.Employees.First(x => x.Id == iD);
                    db.Employees.Remove(emp);
                    db.SaveChanges();
                    List<DAL.Models.Task> task = db.Tasks.Where(x => x.Id == iD).ToList();
                    db.Tasks.RemoveRange(task);
                    db.SaveChanges();

                    List<Salary> salaries = db.Salaries.Where(x=> x.EmployeeId == iD).ToList();
                    db.Salaries.RemoveRange(salaries);
                    db.SaveChanges();

                    List<Permission> permissions = db.Permissions.Where(x => x.Id == iD).ToList();
                    db.Permissions.RemoveRange(permissions);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }

    }