using DAL.Models;
using DAL.DTO; // You need to add this so you can use PositionDTO
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PositionBLL
    {
        public List<PositionDTO> GetPositions()
        {
            using (var db = new PersonnelDbContext())
            {
                var list = (from p in db.Positions
                            join d in db.Departments on p.DeparmentId equals d.Id
                            select new PositionDTO
                            {
                                Id = p.Id,
                                PositionName = p.PositionName,
                                DepartmentName = d.DepartmentName,
                                DepartmentId = d.Id
                            }).OrderBy(x => x.Id).ToList();

                return list;
            }
        }

        public void AddPosition(Position position)
        {
            try
            {
                using (var db = new PersonnelDbContext())
                {
                    db.Positions.Add(position);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdatePosition(Position position, bool control)
        {
            if (control)
            {
                try
                {
                    using (var db = new PersonnelDbContext())
                    {
                        Position pst = db.Positions.First(x => x.Id == position.Id);
                        pst.PositionName = position.PositionName;
                        pst.DeparmentId = position.DeparmentId;
                        EmployeeBLL.UpdateEmployee(position);
                        db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        
        }

        public static void DeletePosition(int id)
        {
            using (var db = new PersonnelDbContext())
            {
                try
                {
                    Position pst = db.Positions.First(x => x.Id == id);
                    db.Positions.Remove(pst);
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
