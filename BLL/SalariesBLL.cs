using DAL.DTO;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using SalaryModel = DAL.Models.Salary;

namespace BLL
{
    public class SalariesBLL
    {


        public static SalaryDTO GetSalaryData()
        {
            SalaryDTO dto = new SalaryDTO();

            using (var db = new PersonnelDbContext())

            {
                //Get Months
                dto.Months = db.Months.ToList();

                // Get Departments
                dto.Departments = db.Departments.ToList();

                //Get Positions
                dto.Positions = (from p in db.Positions
                                 join d in db.Departments on p.DeparmentId equals d.Id
                                 select new PositionDTO
                                 {
                                     Id = p.Id,
                                     PositionName = p.PositionName,
                                     DepartmentName = d.DepartmentName,
                                     DepartmentId = d.Id
                                 }).OrderBy(x => x.Id).ToList();


                // Get Employees — if you already have EmployeeDetailDTO mapped, use it.
                dto.Employees = (from e in db.Employees
                                 join d in db.Departments on e.DepartmentId equals d.Id
                                 join p in db.Positions on e.PositionId equals p.Id
                                 select new EmployeeDetailDTO
                                 {
                                     ID = e.Id,
                                     EmployeeNo = e.EmployeeNo,
                                     FirstName = e.FirstName,
                                     LastName = e.LastName,
                                     DepartmentID = e.DepartmentId,
                                     PositionID = e.PositionId,
                                     ImagePath = e.ImagePath,
                                     Salary = e.Salary,


                                 }).OrderBy(x => x.EmployeeNo).ToList();

                // Get Salaries
                dto.Salaries = (from s in db.Salaries
                                join e in db.Employees on s.EmployeeId equals e.EmployeeNo
                                join m in db.Months on s.MonthId equals m.Id
                                join d in db.Departments on e.DepartmentId equals d.Id
                                join p in db.Positions on e.PositionId equals p.Id
                                select new SalaryDetailDTO
                                {
                                    EmployeeNo = e.EmployeeNo,
                                    ID = e.Id,
                                    FirstName = e.FirstName,
                                    LastName = e.LastName,
                                    DepartmentID = e.DepartmentId,
                                    DepartmentName = d.DepartmentName,
                                    PositionID = e.PositionId,
                                    PositionName = p.PositionName,
                                    ImagePath = e.ImagePath,
                                    SalaryAmount = s.Amount,
                                    SalaryYear = s.Year,
                                    SalaryID = s.Id,
                                    OldSalary = e.Salary,
                                    MonthID = s.MonthId,
                                    MonthName = m.MonthName
                                }).ToList();
            }

            return dto;
        }
        public static void AddSalary(SalaryModel salary, bool control)
        {
            try
            {
                using (PersonnelDbContext db = new PersonnelDbContext())
                {
                    db.Salaries.Add(salary);

                    // Only update employee salary if control flag is true
                    if (control)
                    {
                        Employee emp = db.Employees.FirstOrDefault(e => e.EmployeeNo == salary.EmployeeId);
                        if (emp != null)
                        {
                            emp.Salary = salary.Amount;
                        }
                    }

                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void UpdateSalary(SalaryModel salary, bool control)
        {
            try
            {
                using (PersonnelDbContext db = new PersonnelDbContext())
                {
                    SalaryModel sl = db.Salaries.First(x => x.Id == salary.EmployeeId);

                    sl.Amount = salary.Amount;
                    sl.Year = salary.Year;
                    sl.MonthId = salary.MonthId;

                    // Only update employee salary if control flag is true
                    if (control)
                    {
                        Employee emp = db.Employees.FirstOrDefault(e => e.EmployeeNo == salary.EmployeeId);
                        if (emp != null)
                        {
                            emp.Salary = salary.Amount;
                        }
                    }

                    db.SaveChanges(); // for LINQ-to-SQL
                }
            }
            catch (Exception)
            {
                throw; // You could also log here if needed
            }
        }

        public static void DeleteSalary(int salaryID)
        {
            using (PersonnelDbContext db = new PersonnelDbContext())
            { 
                try
                {
                    SalaryModel salary = db.Salaries.First(x => x.Id == salaryID);
                    db.Salaries.Remove(salary);
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
