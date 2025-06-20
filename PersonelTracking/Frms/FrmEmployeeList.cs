using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DAL.DTO;
using PersonelTracking.Helpers;

namespace PersonelTracking
{
    public partial class FrmEmployeeList : Form
    {
        public FrmEmployeeList()
        {
            InitializeComponent();


        }

        // Helper method to configure the DataGridView columns cleanly
        private void SetupDataGridViewColumns()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            // Define column name + header text pairs
            var columns = new (string PropertyName, string HeaderText)[]
            {
        ("EmployeeNo", "User No"),
        ("ID", "ID"),
        ("FirstName", "First Name"),
        ("LastName", "Last Name"),
        ("DepartmentName", "Department"),
        ("PositionName", "Position"),
        ("Salary", "Salary"),
        ("ImagePath", "Image Path"),
        ("Birthday", "Birthday"),
        ("Address", "Address"),
        ("Password", "Password"),
        ("IsAdmin", "Admin"),
        ("DepartmentID", "Dept ID"),
        ("PositionID", "Pos ID")
            };

            // Add columns
            foreach (var col in columns)
            {
                dataGridView1.Columns.Add(col.PropertyName, col.HeaderText);
                dataGridView1.Columns[col.PropertyName].DataPropertyName = col.PropertyName;
            }
        }


        // Exit button closes the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // UserID textbox should allow only numeric input
        private void useridTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = General.isNumber(useridTxt, e, "User ID");
            }
        }

        // First name textbox validation
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                General.isAnyText(txtName, "First Name");
            }
        }

        // Last name textbox validation
        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                General.isAnyText(txtLastName, "Last Name");
            }
        }

        // UserID textbox placeholder behavior
        private void useridTxt_KeyDown(object sender, KeyEventArgs e)
        {
            General.isUserIdText(useridTxt, "User ID");
        }

        // New button opens the FrmEmployee form for adding new employees

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmEmployee frm = new FrmEmployee();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            FillAllData();
            ClearFilter();

            // Refresh grid after returning from FrmEmployee
            dto = EmployeeBLL.GetEmployeeData();
            dataGridView1.DataSource = dto.Employees;
        }

        // Update button opens the FrmEmployee form (can be extended to load selected employee)
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detailDTO.EmployeeNo == 0)
            {
                General.UserMessage(lblSaved, "Please Select a Employee on table!", Color.Red, "Error2.wav");
            }
            else
            {
                FrmEmployee frm = new FrmEmployee();
                frm.isUpdate = true;
                frm.detailDTO = detailDTO;
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
                FillAllData();
                ClearFilter();

            }

        }

        // Employee data object (DTO)
        EmployeeDTO dto = new EmployeeDTO();

        // Flag to indicate if ComboBoxes are ready for interaction
        private bool combofull = false;

        EmployeeDetailDTO detailDTO = new EmployeeDetailDTO();

        // Form load event: load data and setup UI

        void FillAllData()
        {

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

            // Load full EmployeeDTO (Departments, Positions, Employees)
            dto = EmployeeBLL.GetEmployeeData();

            // Disconnect RowEnter
            dataGridView1.RowEnter -= datagridView1_RowEnter;

            // Set DataGridView data source
            dataGridView1.DataSource = dto.Employees;

            //Format the sheet to have ID row fixed at 60 and the rest of the columns fill.
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView1.Columns[0].Width = 50;
            General.StyleDataGridView(dataGridView1);

            // Apply custom DataGridView style
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            // Add columns manually
            SetupDataGridViewColumns();

            // Reconnect RowEnter
            dataGridView1.RowEnter += datagridView1_RowEnter;


            // Hide for nonadmin view

            //dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            //dataGridView1.Columns[10].Visible = false;
            //dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns["DepartmentID"].Visible = false;
            dataGridView1.Columns["PositionID"].Visible = false;



            // Optional: hide columns if needed
            // Example:
            // dataGridView1.Columns[7].Visible = false; // if you don't want to show ImagePath

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

            //clear label on load.
            lblSaved.Text = "";


            // Enable ComboBox behavior
            combofull = true;
        }
        private void FrmEmployeeList_Load(object sender, EventArgs e)
        {
            FillAllData();
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
            List<EmployeeDetailDTO> list = dto.Employees;

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

            // Give the list to the grid to be the data source.
            dataGridView1.DataSource = list;
        }

        void ClearFilter()
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

            combofull = true;

            dataGridView1.DataSource = dto.Employees;
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            ClearFilter();

        }

        private void datagridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            detailDTO.FirstName = dataGridView1.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
            detailDTO.LastName = dataGridView1.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
            detailDTO.EmployeeNo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["EmployeeNo"].Value);
            detailDTO.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
            detailDTO.Password = dataGridView1.Rows[e.RowIndex].Cells["Password"].Value.ToString();
            detailDTO.ImagePath = dataGridView1.Rows[e.RowIndex].Cells["ImagePath"].Value.ToString();
            detailDTO.Address = dataGridView1.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            detailDTO.IsAdmin = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells["isAdmin"].Value);
            detailDTO.Birthday = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["Birthday"].Value);
            detailDTO.DepartmentName = dataGridView1.Rows[e.RowIndex].Cells["DepartmentName"].Value.ToString();
            detailDTO.PositionName = dataGridView1.Rows[e.RowIndex].Cells["PositionName"].Value.ToString();
            detailDTO.Salary = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Salary"].Value);
            detailDTO.DepartmentID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["DepartmentID"].Value);
            detailDTO.PositionID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["PositionID"].Value);




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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            General.YNCheck("Are you Sure?", MessageBoxButtons.YesNo);
            DialogResult = DialogResult.Yes;
            {
                EmployeeBLL.DeleteEmployee(detailDTO.ID);

                General.UserMessage(lblSaved, "Employee Deleted!", Color.Lime, "Button.wav");
                FillAllData();
                ClearFilter();
            }
        }

        private void bntExport_Click(object sender, EventArgs e)
        {
            ExcelExporter.ExportDataGridView(dataGridView1, "Employees", "EmployeeList");
        }
    }
}
