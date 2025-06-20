using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class PermissionDetailDTO
    {
        public int EmployeeNo { get; set; }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DepartmentName { get; set; }
        public string PositionName { get; set; }
        public int DepartmentID { get; set; }
        public int PositionID { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime CompleteDate { get; set; }

        public int PermissionDayAmount { get; set; }

        public int StateID { get; set; }

        public string StateName { get; set; }

        public int State {  get; set; }

        public string Explaination { get; set; }

        public string ImagePath { get; set; }
        public int PermissionID { get; set; }
        public int PermissionState { get; set; }
        public string PermissionStateDisplay { get; set; }
    }
}
