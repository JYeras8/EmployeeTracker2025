using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.DTO
{
    public class PositionDTO
    {
        public int Id { get; set; }
        public string PositionName { get; set; }
        public string DepartmentName { get; set; }
        public int DepartmentId { get; set; }

        public int OldDeparmentID { get; set; }
    }
}
