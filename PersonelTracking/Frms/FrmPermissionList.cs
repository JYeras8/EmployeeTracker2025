using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.DTO;
using DAL;
using BLL;
using SysTask = System.Threading.Tasks.Task;
using PersonelTracking.Helpers;

namespace PersonelTracking
{
    public partial class FrmPermissionList : Form
    {
        public FrmPermissionList()
        {
            InitializeComponent();
        }



        private void txtDop_KeyDown(object sender, KeyEventArgs e)
        {
            General.isUserIdText(txtDop, "Days of Permission");
        }

        private void txtDop_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = General.isNumber(txtDop, e, "Days of Permission");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void useridTxt_KeyDown(object sender, KeyEventArgs e)
        {
            General.isUserIdText(useridTxt, "User ID");
        }

        private void useridTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = General.isNumber(useridTxt, e, "User ID");
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                General.isAnyText(txtName, "First Name");
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                General.isAnyText(txtLastName, "Last Name");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            // Optionally clear the image
            if (pbProfilePic.Image != null)
            {
                pbProfilePic.Image.Dispose();
                pbProfilePic.Image = null;
            }

            frmPermission frm = new frmPermission();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;

            FillAllData();
            cleanFilters();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.PermissionID == 0)
                General.UserMessage(lblSaved, "Please select a permission", Color.Red, "Error2.wav");

            else if (detail.State == PermissionStates.Approved || detail.State == PermissionStates.Denied)
                General.UserMessage(lblSaved, "You cannot update any approved or denied permission", Color.Red, "Error2.wav");




            else
            {
                frmPermission frm = new frmPermission();
                frm.isUpdate = true;
                frm.detailDTO = detail;
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;

                FillAllData();
                cleanFilters();

            }

        }

        PermissionDTO dto = new PermissionDTO();

        // Flag to indicate if ComboBoxes are ready for interaction
        private bool combofull = false;
        private void FrmPermissionList_Load(object sender, EventArgs e)
        {
            FillAllData();
            lblSaved.Text = "";
        }

        PermissionDetailDTO detail = new PermissionDetailDTO();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {



            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                /*
                useridTxt.Text = row.Cells[0].Value?.ToString() ?? "";
                txtName.Text = row.Cells[1].Value?.ToString() ?? "";
                txtLastName.Text = row.Cells[2].Value?.ToString() ?? "";
                */

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Search Filters
            List<PermissionDetailDTO> list = dto.Permission;

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
                list = list.Where(x => x.StartDate < Convert.ToDateTime(dpComplete.Value) &&
                x.StartDate > Convert.ToDateTime(dpStartDate.Value)).ToList();

            else if (rdbDeliveryDate.Checked)
            {
                list = list.Where(x => x.CompleteDate < dpComplete.Value &&
                                       x.CompleteDate > dpStartDate.Value).ToList();
            }

            // Give the list to the grid to be the data source.
            dataGridView1.DataSource = list;
        }

        void FillAllData()
        {

            // ✅ Refresh the data BEFORE assigning it to DataGridView
            dto = PermissionBLL.GetPermissions();

            if (!UserStatic.IsAdmin)
                dto.Permission = dto.Permission.Where(x => x.EmployeeNo == UserStatic.EmployeeNo).ToList();

            dataGridView1.DataSource = dto.Permission;
            // Enable ComboBox behavior
            combofull = false;

            // Hide specific columns
            dataGridView1.Columns["EmployeeNo"].Visible = false;
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["PositionName"].Visible = false;
            dataGridView1.Columns["DepartmentName"].Visible = false;
            dataGridView1.Columns["DepartmentID"].Visible = false;
            dataGridView1.Columns["PositionID"].Visible = false;
            dataGridView1.Columns["StateID"].Visible = false;
            dataGridView1.Columns["StateName"].Visible = false;
            dataGridView1.Columns["ImagePath"].Visible = false;
            dataGridView1.Columns["State"].Visible = false;

            dataGridView1.Columns["PermissionDayAmount"].HeaderText = "Days";


            dataGridView1.Columns["Explaination"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["FirstName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView1.Columns["LastName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView1.Columns["StartDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["CompleteDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns["PermissionState"].Visible = false;
            dataGridView1.Columns["PermissionID"].Visible = false;

            dataGridView1.Columns["PermissionStateDisplay"].HeaderText = "Status";
            dataGridView1.Columns["PermissionStateDisplay"].Visible = true;
            dataGridView1.Columns["PermissionStateDisplay"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            General.StyleDataGridView(dataGridView1);

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

            // Combo boxes (if you have cmbDepartment and cmbPosition on this form)
            cmbDeparments.DataSource = dto.Departments;
            cmbDeparments.DisplayMember = "DepartmentName";
            cmbDeparments.ValueMember = "Id";
            cmbDeparments.SelectedIndex = -1;

            // Setup Position ComboBox
            cmbPosition.DataSource = dto.Positions;
            cmbPosition.DisplayMember = "PositionName";
            cmbPosition.ValueMember = "Id";
            cmbPosition.SelectedIndex = -1;

            cmbState.DataSource = dto.States;
            cmbState.DisplayMember = "StateName";
            cmbState.ValueMember = "Id";
            cmbState.SelectedIndex = -1;
            cmbState.Text = "State";


            // Enable ComboBox behavior
            combofull = true;

            dataGridView1.DataSource = dto.Permission;

            if (!UserStatic.IsAdmin)
            {
                pnlForAdmin.Hide();
                btnDelete.Hide();
                btnDenied.Hide();
                btnApproved.Hide();
            }
        }

        void cleanFilters()
        {
            useridTxt.Text = "User ID";
            useridTxt.ForeColor = Color.DarkGray;

            txtName.Text = "First Name";
            txtName.ForeColor = Color.DarkGray;

            txtLastName.Text = "Last Name";
            txtLastName.ForeColor = Color.DarkGray;

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

            cmbState.DataSource = null;
            cmbState.DataSource = dto.States;
            cmbState.DisplayMember = "StateName";

            cmbState.ValueMember = "Id";
            cmbState.SelectedIndex = -1;



            rdbDeliveryDate.Checked = false;
            rdbStartDate.Checked = false;
            txtDop.Clear();

            combofull = true;

            cmbState.Text = "State";
            txtDop.Text = "Days Of Permission";

            dataGridView1.DataSource = dto.Permission;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cleanFilters();

        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                detail.PermissionID = Convert.ToInt32(row.Cells["PermissionID"].Value);
                detail.StartDate = Convert.ToDateTime(row.Cells["StartDate"].Value);
                detail.CompleteDate = Convert.ToDateTime(row.Cells["CompleteDate"].Value);
                detail.Explaination = row.Cells["Explaination"].Value?.ToString() ?? string.Empty;
                detail.EmployeeNo = Convert.ToInt32(row.Cells["EmployeeNo"].Value);
                detail.State = Convert.ToInt32(row.Cells["StateID"].Value);
                detail.PermissionDayAmount = Convert.ToInt32(row.Cells["PermissionDayAmount"].Value);
            }
        }

        private void Approved_Click(object sender, EventArgs e)
        {
            PermissionBLL.UpdatePermission(detail.PermissionID, PermissionStates.Approved);

            General.UserMessage(lblSaved, "Approved!", Color.Lime, "Button.wav");
            dto = PermissionBLL.GetPermissions();
            FillAllData();
            cleanFilters();
        }

        private void btnDenied_Click(object sender, EventArgs e)
        {
            PermissionBLL.UpdatePermission(detail.PermissionID, PermissionStates.Denied);
            General.UserMessage(lblSaved, "Denied!", Color.Lime, "Button.wav");
            dto = PermissionBLL.GetPermissions();
            FillAllData();
            cleanFilters();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            General.YNCheck("Are you Sure?", MessageBoxButtons.YesNo);
            DialogResult = DialogResult.Yes;
            {
                if (detail.State == PermissionStates.Approved || detail.State == PermissionStates.Denied)
                    General.UserMessage(lblSaved, "You cannot delete approved or denied permission!", Color.Red, "Error2.wav");
                else
                {
                    PermissionBLL.DeletePermission(detail.PermissionID);
                    General.UserMessage(lblSaved, "Permission Deleted!", Color.Lime, "Button.wav");
                    FillAllData();
                    cleanFilters();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bntExport_Click(object sender, EventArgs e)
        {
            ExcelExporter.ExportDataGridView(dataGridView1, "Permissions", "PermissionList");
        }
    }
}
