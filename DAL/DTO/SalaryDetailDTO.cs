using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class SalaryDetailDTO
    {
        public int EmployeeNo { get; set; }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DepartmentName { get; set; }
        public string PositionName { get; set; }
        public int DepartmentID { get; set; }
        public int PositionID { get; set; }

        public string ImagePath { get; set; }

        public string MonthName { get; set; }
        public int SalaryYear { get; set; }

        public int MonthID { get; set; }

        public int SalaryAmount { get; set; }

        public int SalaryID {  get; set; }

        public int OldSalary {  get; set; }




    }
}
