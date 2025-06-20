using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class EmployeeDetailDTO
    {
        public int EmployeeNo { get; set; }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DepartmentName { get; set; }
        public string PositionName { get; set; }
        public int DepartmentID { get; set; }
        public int PositionID { get; set; }
        public int Salary { get; set; }
        public string ImagePath { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public DateTime? Birthday { get; set; }
        public bool IsAdmin { get; set; }

    }
}
