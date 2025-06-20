// Hard-debugging version using auto-generated columns and inspection of data binding
using BLL;
using DAL.DTO;
using DAL.Models;
using PersonelTracking.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PersonelTracking
{
    public partial class FrmTaskList : Form
    {
        public FrmTaskList()
        {
            InitializeComponent();
        }

        TaskDTO dto = new TaskDTO();
        private bool combofull = false;

        void fillAllData()
        {
            // hide for admin, not sure if we should use this yet.
            //pnlForAdmin.Hide();
            dto = TaskBLL.GetTaskData();

            if (!UserStatic.IsAdmin)
                dto.Task = dto.Task.Where(x => x.EmployeeNo == UserStatic.EmployeeNo).ToList();

            //MessageBox.Show($"Tasks loaded: {dto.Task.Count}");

            dataGridView1.RowEnter -= dataGridView1_RowEnter;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoGenerateColumns = true;
            General.StyleDataGridView(dataGridView1);

            dataGridView1.DataSource = dto.Task;
            dataGridView1.RowEnter += dataGridView1_RowEnter;

            // Hide unused columns in DataGridView
            string[] visibleCols =
            {
    "FirstName",
    "LastName",
    "DepartmentName",
    "Title",
    "TaskStartDate",
    "TaskDeliveryDate"
};

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.Visible = visibleCols.Contains(col.DataPropertyName);
            }

            // MessageBox.Show($"Grid Rows: {dataGridView1.Rows.Count}, Columns: {dataGridView1.Columns.Count}");

            if (dataGridView1.Rows.Count > 0)
            {
                var firstRow = dataGridView1.Rows[0];
                string debugValues = "";
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    debugValues += $"{col.HeaderText}: {firstRow.Cells[col.Index].Value}\n";
                }
                //MessageBox.Show(debugValues, "Row 0 Data");
            }
            else
            {
                //MessageBox.Show("No rows rendered. Data binding or visibility issue.");
            }

            General.styleTextBox(tasknameTxt);
            General.styleTextBox(taskStateTxt);
            General.styleRichTextBox(taskContentTxt);

            if (!UserStatic.IsAdmin)
            {
                btnNew.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                btnExit.Location = new Point(506, 18);

                pnlForAdmin.Hide();
                btnApproved.Text = "Delivery";

                Font silkscreenFont = new Font("Silkscreen", 9, FontStyle.Bold);
                btnApproved.Font = silkscreenFont;
            }
        }



        private void FrmTaskList_Load(object sender, EventArgs e)
        {
            fillAllData();
            lblSaved.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e) => this.Close();
        private void useridTxt_KeyDown(object sender, KeyEventArgs e) => General.isUserIdText(useridTxt, "User ID");
        private void useridTxt_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = General.isNumber(useridTxt, e, "User ID");
        private void txtName_KeyPress(object sender, KeyPressEventArgs e) => General.isAnyText(txtName, "First Name");
        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e) => General.isAnyText(txtLastName, "Last Name");

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmTask frm = new FrmTask();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            fillAllData();
            ClearFilters();

            // Refresh the data after dialog closes
            dto = TaskBLL.GetTaskData();
            dataGridView1.DataSource = dto.Task;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.TaskID == 0)
            {
                General.UserMessage(lblSaved, "Please Select a task on table", Color.Red, "Error2.wav");

            }
            else
            {
                FrmTask frm = new FrmTask();
                frm.isUpdate = true;
                frm.detailDTO = detail;
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
                fillAllData();
                ClearFilters();

                // Refresh the data after dialog closes
                dto = TaskBLL.GetTaskData();
                dataGridView1.DataSource = dto.Task;
            }

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        TaskDetailDTO detail = new TaskDetailDTO();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows.Count > e.RowIndex)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                var content = row.Cells["Content"].Value?.ToString();
                var title = row.Cells["Title"].Value?.ToString();
                var state = row.Cells["taskStateName"].Value?.ToString();

                taskContentTxt.Text = content;
                tasknameTxt.Text = title;
                taskStateTxt.Text = state;

                detail.FirstName = dataGridView1.Rows[e.RowIndex].Cells["FirstName"].Value?.ToString();
                detail.LastName = dataGridView1.Rows[e.RowIndex].Cells["LastName"].Value?.ToString();
                detail.EmployeeNo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["EmployeeNo"].Value?.ToString());
                detail.TaskID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["TaskID"].Value?.ToString());
                detail.taskStateID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["taskStateID"].Value?.ToString());
                detail.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value?.ToString());
                detail.TaskStartDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["TaskStartDate"].Value?.ToString());
                detail.TaskDeliveryDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["TaskDeliveryDate"].Value?.ToString());
                detail.Title = dataGridView1.Rows[e.RowIndex].Cells["Title"].Value?.ToString();
                detail.Content = dataGridView1.Rows[e.RowIndex].Cells["Content"].Value?.ToString();

            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            {
                // Search Filters
                List<TaskDetailDTO> list = dto.Task;

                // UserID filter
                if (useridTxt.Text != "" && useridTxt.Text != "User ID")
                {
                    int userId;
                    if (int.TryParse(useridTxt.Text, out userId))
                        list = list.Where(x => x.EmployeeNo == userId).ToList();
                }

                // FirstName filter
                if (txtName.Text != "" && txtName.Text != "First Name")
                    list = list.Where(x => x.FirstName.Contains(txtName.Text)).ToList();

                // LastName filter
                if (txtLastName.Text != "" && txtLastName.Text != "Last Name")
                    list = list.Where(x => x.LastName.Contains(txtLastName.Text)).ToList();

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

                if (rdbStartDate.Checked)
                    list = list.Where(x => x.TaskStartDate > Convert.ToDateTime(dpStartDate.Value) &&
                    x.TaskStartDate < Convert.ToDateTime(dpComplete.Value)).ToList();

                if (rdbDeliveryDate.Checked)
                    list = list.Where(x => x.TaskDeliveryDate > Convert.ToDateTime(dpStartDate.Value) &&
                    x.TaskDeliveryDate < Convert.ToDateTime(dpComplete.Value)).ToList();

                if (cmbTaskState.SelectedIndex != -1)
                    list = list.Where(x => x.taskStateID == Convert.ToInt32(cmbTaskState.SelectedValue)).ToList();
                dataGridView1.DataSource = list;

            }
        }

        void ClearFilters()
        {

            useridTxt.Text = "User ID";
            useridTxt.ForeColor = Color.DarkGray;

            txtName.Text = "First Name";
            txtName.ForeColor = Color.DarkGray;

            txtLastName.Text = "Last Name";
            txtLastName.ForeColor = Color.DarkGray;

            rdbDeliveryDate.Checked = false;
            rdbStartDate.Checked = false;
            cmbTaskState.SelectedIndex = -1;

            combofull = false;


            // Reset Combo Boxes
            //Deparment ComboBox
            cmbDeparments.DataSource = null;
            cmbDeparments.DataSource = dto.Departments;
            cmbDeparments.DisplayMember = "DepartmentName";
            cmbDeparments.ValueMember = "Id";
            cmbDeparments.SelectedIndex = -1;
            cmbDeparments.Text = "Select Department";

            //Position Combobox
            cmbPosition.Enabled = false;
            cmbPosition.DataSource = null;
            cmbPosition.Text = "Select Position";
            General.ComboBoxStyleHelper.ApplyCMBDisabledStyle(cmbPosition);

            combofull = true;

            dataGridView1.DataSource = dto.Task;
        }
        private void btn_Clean_Vlick(object sender, EventArgs e)
        {
            ClearFilters();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            General.YNCheck("Are you Sure?", MessageBoxButtons.YesNo);
            DialogResult = DialogResult.Yes;
            {
                TaskBLL.DeleteTask(detail.TaskID);
                General.UserMessage(lblSaved, "Task Deleted!", Color.Lime, "Button.wav");
                fillAllData();
                ClearFilters();
            }
        }

        private void btnApproved_Click(object sender, EventArgs e)
        {
            if (UserStatic.IsAdmin && detail.taskStateID == TaskStates.onEmployee && detail.ID != UserStatic.ID)
                General.UserMessage(lblSaved, "Before approving a task employee has to deliver a task!", Color.Red, "Error2.wav");
            else if (UserStatic.IsAdmin && detail.taskStateID == TaskStates.Approved)
                General.UserMessage(lblSaved, "This task is already approved!", Color.Red, "Error2.wav");
            else if (!UserStatic.IsAdmin && detail.taskStateID == TaskStates.Delivered)
                General.UserMessage(lblSaved, "This task is already delivered!", Color.Red, "Error2.wav");
            else if (!UserStatic.IsAdmin && detail.taskStateID == TaskStates.Approved)
                General.UserMessage(lblSaved, "This task is already approved!", Color.Red, "Error2.wav");
            else
            {
                TaskBLL.ApproveTask(detail.TaskID, UserStatic.IsAdmin);
                General.UserMessage(lblSaved, "Task was updated!", Color.Red, "Button.wav");
                fillAllData();
                ClearFilters();

            }
        }

        private void bntExport_Click(object sender, EventArgs e)
        {
            ExcelExporter.ExportDataGridView(dataGridView1, "Tasks", "TaskList");
        }
    }

}
