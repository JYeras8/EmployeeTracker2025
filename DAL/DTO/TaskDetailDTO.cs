using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.DTO
{
    public class TaskDetailDTO
    {
        public int EmployeeNo { get; set; }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DepartmentName { get; set; }
        public string PositionName { get; set; }
        public int DepartmentID { get; set; }
        public int PositionID { get; set; }
        public int TaskID { get; set; }
        public string Title { get; set; }

        public string Content { get; set; }

        public string taskStateName { get; set; }

        public DateTime? TaskStartDate { get; set; }

        public DateTime? TaskDeliveryDate { get; set; }

        public int taskStateID { get; set; }
    }
}
