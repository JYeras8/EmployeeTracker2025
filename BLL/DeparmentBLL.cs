using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace BLL
{
    public class DepartmentBLL
    {
        public List<Department> GetDepartments()
        {
            using (var db = new PersonnelDbContext())
            {
                return db.Departments.ToList();
            }
        }

        public void AddDepartment(Department department)
        {
            try
            {
                using (var db = new PersonnelDbContext())
                {
                    db.Departments.Add(department);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;  // this exactly matches your teacher
            }
        }

        public static void UpdateDepartment(Department department)
        {
            try 
            {
                using (var db = new PersonnelDbContext())
                {
                    Department dpt = db.Departments.First(x => x.Id == department.Id);
                    dpt.DepartmentName = department.DepartmentName;
                    db.SaveChanges();

                }
            }
            catch (Exception) 
            
            { 
                throw; 
            }  
        }

        public static void DeleteDeparment(int id)
        {
            try
            {
                using (var db = new PersonnelDbContext())
                {
                    Department dpt = db.Departments.First(x => x.Id == id);
                    db.Departments.Remove(dpt);
                    db.SaveChanges();


                }
            }
            catch (Exception)

            {
                throw;
            }
        }
    }


}


    


