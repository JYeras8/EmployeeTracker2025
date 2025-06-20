using BLL;
using DAL;
using DAL.DTO;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskModel = DAL.Models.Task;
using SysTask = System.Threading.Tasks.Task;
using System.Runtime.CompilerServices;
using PersonelTracking.Helpers;


namespace PersonelTracking
{

    

    public partial class FrmTask : Form
    {
        // Flag to indicate if ComboBoxes are ready for interaction
        private bool combofull = false;

        private void SetupDataGridViewColumns()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            // Define column name + header text pairs
            var columns = new (string PropertyName, string HeaderText)[]
            {
        ("EmployeeNo", "User No"),
        ("FirstName", "First Name"),
        ("LastName", "Last Name"),
        ("ImagePath", "Image Path"),


            };
            // Add columns
            foreach (var col in columns)
            {
                dataGridView1.Columns.Add(col.PropertyName, col.HeaderText);
                dataGridView1.Columns[col.PropertyName].DataPropertyName = col.PropertyName;

            }

            General.StyleDataGridView(dataGridView1);




        }

        public FrmTask()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        TaskDTO dto = new TaskDTO();
        public bool isUpdate = false;
        public TaskDetailDTO detailDTO = new TaskDetailDTO();

        private void FrmTask_Load(object sender, EventArgs e)
        {

            dto = TaskBLL.GetTaskData();

            // Disconnect RowEnter
            dataGridView1.RowEnter -= dataGridView1_RowEnter;


            // Set DataGridView data source
            dataGridView1.DataSource = dto.Employees;

            General.ComboBoxStyleHelper.ApplyCMBDisabledStyle(cmbPosition);

            // Add columns manually
            SetupDataGridViewColumns();

            // Reconnect RowEnter
            dataGridView1.RowEnter += dataGridView1_RowEnter;

            //Style ComboBoxes
            cmbDeparments.DataSource = null;
            cmbDeparments.DataSource = dto.Departments;
            cmbDeparments.DisplayMember = "DepartmentName";
            cmbDeparments.ValueMember = "Id";
            cmbDeparments.Text = "Select Department";


            //Position Combobox
            cmbPosition.Enabled = false;
            cmbPosition.DataSource = null;
            cmbPosition.Text = "Select Position";

            General.ComboBoxStyleHelper.ApplyCMBDisabledStyle(cmbPosition);


            cmbTaskState.DataSource = dto.Taskstates;
            cmbTaskState.DisplayMember = "StateName";
            cmbTaskState.ValueMember = "Id";

            lblSaved.Text = string.Empty;

            // Enable ComboBox behavior
            combofull = true;

            if (isUpdate)
            {
                txtName.Text = detailDTO.FirstName;
                txtLastName.Text = detailDTO.LastName;
                useridTxt.Text = detailDTO.EmployeeNo.ToString();
                txtTaskTitle.Text = detailDTO.Title;  
                txtContent.Text = detailDTO.Content;

                // since we are pre-entering information, text should be colored.
                txtTaskTitle.ForeColor = Color.Lime;
                txtContent.ForeColor = Color.Lime;

                cmbTaskState.DataSource=dto.Taskstates;
                cmbTaskState.DisplayMember = "StateName";
                cmbTaskState.ValueMember = "Id";
                cmbTaskState.SelectedValue = detailDTO.taskStateID;

                //AutoSelect the person in the datagrid view who we are updating
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["EmployeeNo"].Value != null &&
                        Convert.ToInt32(row.Cells["EmployeeNo"].Value) == detailDTO.EmployeeNo)
                    {
                        row.Selected = true;
                        dataGridView1.CurrentCell = row.Cells[0]; // Optionally focus first cell
                        break;
                    }
                }
            }
        }



        private void cmbDeparments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDeparments.SelectedIndex != -1 && combofull && cmbDeparments.SelectedValue != null)
            {
                int selectedDepartmentId = (int)cmbDeparments.SelectedValue;

                var filteredPositions = dto.Positions
                    .Where(x => x.DepartmentId == selectedDepartmentId)
                    .ToList();



                cmbPosition.DataSource = filteredPositions;
                cmbPosition.DisplayMember = "PositionName";
                cmbPosition.ValueMember = "Id";

                List<EmployeeDetailDTO> list = dto.Employees;

                // Department filter 
                if (cmbDeparments.SelectedIndex != -1 && cmbDeparments.SelectedValue != null)
                {
                    int deptId = Convert.ToInt32(cmbDeparments.SelectedValue);
                    list = list.Where(x => x.DepartmentID == deptId).ToList();
                }

                // Position filter 
                if (cmbPosition.SelectedIndex != -1 && cmbPosition.SelectedValue != null)
                {
                    int posId = Convert.ToInt32(cmbPosition.SelectedValue);
                    list = list.Where(x => x.PositionID == posId).ToList();
                }

                // Give the list to the grid to be the data source.
                dataGridView1.DataSource = list;


                // Enable Position ComboBox now
                cmbPosition.Enabled = true;
                // Active color
                General.ComboBoxStyleHelper.ApplyCMBUniversalStyle(cmbDeparments);
                General.ComboBoxStyleHelper.ApplyCMBUniversalStyle(cmbPosition);

                // Auto-select first item
                if (filteredPositions.Count > 0)
                    cmbPosition.SelectedIndex = 0;
                else
                {
                    cmbPosition.SelectedIndex = -1;
                    cmbPosition.Text = "Select Position";
                }
            }
            else
            {
                cmbPosition.Enabled = false;
                cmbPosition.DataSource = null;
                cmbPosition.Text = "Select Position";

                //Disabled Color
                cmbPosition.BackColor = Color.DarkGray;
                cmbPosition.BackColor = Color.Black;
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                useridTxt.Text = row.Cells[0].Value?.ToString() ?? "";
                txtName.Text = row.Cells[1].Value?.ToString() ?? "";
                txtLastName.Text = row.Cells[2].Value?.ToString() ?? "";

                // Load image
                string imagePath = row.Cells["ImagePath"].Value?.ToString();
                if (!string.IsNullOrEmpty(imagePath))
                {
                    string fullImagePath = Path.Combine(@"C:\Users\JYSSD\Documents\Rider\PersonelTracking\PersonelTracking\bin\Debug\net9.0-windows\Images", imagePath);

                    if (File.Exists(fullImagePath))
                    {
                        if (pbProfilePic.Image != null)
                        {
                            pbProfilePic.Image.Dispose();
                            pbProfilePic.Image = null;
                        }
                        using (var stream = new MemoryStream(File.ReadAllBytes(fullImagePath)))
                        {
                            pbProfilePic.Image = Image.FromStream(stream);
                        }

                        pbProfilePic.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                        pbProfilePic.Image = null;
                    }
                }
                else
                {
                    pbProfilePic.Image = null;
                }
            }
        }

        private TaskModel task = new TaskModel();


        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (useridTxt.Text == "" || useridTxt.Text == "User ID")
            {
                General.UserMessage(lblSaved, "Please Select Employee", Color.Red, "Error2.wav");

            }

            else if (txtTaskTitle.Text == "" || txtTaskTitle.Text == "TaskTitle" || txtContent.Text == "" || txtContent.Text == "Task Description")
            
            {
                General.UserMessage(lblSaved, "Please Enter Task", Color.Red, "Error2.wav");

            }
            else

            {
                if (!isUpdate)
                {
                    // Fill task properties from your form
                    var selectedEmpNo = Convert.ToInt32(useridTxt.Text);
                    var employee = dto.Employees.FirstOrDefault(e => e.EmployeeNo == selectedEmpNo);
                    task.EmployeeId = employee.ID;
                    task.TaskTitle = txtTaskTitle.Text;
                    task.TaskContent = txtContent.Text;
                    task.TaskState = Convert.ToInt32(cmbTaskState.SelectedValue); // or 1 if default
                    task.TaskStartDate = DateTime.Today;



                    // Now save it
                    TaskBLL.AddTask(task);

                    General.UserMessage(lblSaved, "Task was added!", Color.Lime, "Button.wav");

                    // Clear textboxes
                    txtTaskTitle.Clear();
                    txtContent.Clear();

                    //Reset task title and content box.
                    txtTaskTitle.Text = "TaskTitle";
                    txtContent.Text = "Task Description";
                    txtTaskTitle.ForeColor = Color.Silver;
                    txtContent.ForeColor = Color.Silver;

                    task = new TaskModel(); // Reset task

                }
                else if (isUpdate)
                {
                    DialogResult result = MessageBox.Show("Are you sure?!", "Warning!!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        TaskModel update = new TaskModel(); //update task
                        update.Id = detailDTO.TaskID;
                        if(Convert.ToInt32(useridTxt.Text) != detailDTO.EmployeeNo)
                            update.EmployeeId=task.EmployeeId;
                        else
                            update.EmployeeId = detailDTO.ID;
                        update.TaskTitle = txtTaskTitle.Text;
                        update.TaskContent = txtContent.Text;
                        update.TaskState=Convert.ToInt32(cmbTaskState.SelectedValue);
                        TaskBLL.updateTask(update);
                        General.UserMessage(lblSaved, "Task was updated! Please wait...", Color.Lime, "Button.wav");

                        txtTaskTitle.ForeColor= Color.Silver;
                        txtContent.ForeColor= Color.Silver;
                        txtName.ForeColor= Color.Silver;
                        txtLastName.ForeColor= Color.Silver;
                        useridTxt.ForeColor= Color.Silver;
                        txtContent.ForeColor= Color.Silver;
                        txtTaskTitle.ForeColor=Color.Silver;
                        cmbTaskState.ForeColor = Color.Silver;


                        await SysTask.Delay(2000);
                        this.Close();
                    }

                }

            }

        }

        private void txtTaskTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            General.isAnyText(txtTaskTitle, "TaskTitle");
        }

        private void txtContent_KeyPress(object sender, KeyPressEventArgs e)
        {
            General.isAnyText(txtContent, "Task Description");
        }
    }
}
