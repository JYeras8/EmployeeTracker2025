using DAL;
using DAL.DTO;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskModel = DAL.Models.Task;


namespace BLL
{
    public class TaskBLL
    {

        public static TaskDTO GetTaskData()
        {

            TaskDTO dto = new TaskDTO();

            using (var db = new PersonnelDbContext())
            {

                // Get Departments
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
                                     ImagePath = e.ImagePath
                                 }).OrderBy(x => x.EmployeeNo).ToList();




                // Get TaskStates
                dto.Taskstates = db.TaskStates.ToList();


                dto.Task = (from t in db.Tasks
                                      join s in db.TaskStates on t.TaskState equals s.Id
                                      join e in db.Employees on t.EmployeeId equals e.Id
                                      join d in db.Departments on e.DepartmentId equals d.Id
                                      join p in db.Positions on e.PositionId equals p.Id
                                      select new TaskDetailDTO
                                      {
                                          TaskID = t.Id,
                                          Title = t.TaskTitle,
                                          Content = t.TaskContent,

                                          TaskStartDate = t.TaskStartDate,
                                          TaskDeliveryDate = t.TaskDeliveryDate,

                                          taskStateName = s.StateName,
                                          taskStateID = s.Id,
                                          ID = e.Id,
                                          FirstName = e.FirstName,
                                          LastName = e.LastName,
                                          DepartmentName = d.DepartmentName,
                                          PositionID = p.Id,
                                          PositionName = p.PositionName,
                                          EmployeeNo = e.EmployeeNo
                                      }).OrderBy(x => x.TaskStartDate).ToList();


                return dto;

            }

        }
        public static void AddTask(TaskModel task)
        {
            using (PersonnelDbContext db = new PersonnelDbContext())
            {
                db.Tasks.Add(task);
                db.SaveChanges();
            }
        }

        public static void updateTask(TaskModel update)
        {
            try
            {
                using (PersonnelDbContext db = new PersonnelDbContext())
                {
                    TaskModel ts = db.Tasks.First(x => x.Id == update.Id);

                    ts.TaskTitle = update.TaskTitle;
                    ts.TaskContent = update.TaskContent;
                    ts.TaskState = update.TaskState;
                    ts.Id = update.Id;

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DeleteTask(int taskID)
        {
            using (PersonnelDbContext db = new PersonnelDbContext())
            {
                try
                {
                    TaskModel ts = db.Tasks.First(x => x.Id == taskID);
                    db.Tasks.Remove(ts);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }


        }

        public static void ApproveTask(int taskID, bool isAdmin)
        {
            using (PersonnelDbContext db = new PersonnelDbContext())
            {
                try
                {
                    TaskModel ts = db.Tasks.First(x => x.Id == taskID);
                    if (isAdmin)
                        ts.TaskState = TaskStates.Approved;
                    else
                        ts.TaskState = TaskStates.Delivered;
                    ts.TaskDeliveryDate = DateTime.Today;

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




