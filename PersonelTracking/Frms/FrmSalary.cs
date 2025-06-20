using BLL;
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
using SysTask = System.Threading.Tasks.Task;
using SalaryModel = DAL.Models.Salary;
using PersonelTracking.Helpers;

namespace PersonelTracking
{
    public partial class FrmSalary : Form
    {
        // Flag to indicate if ComboBoxes are ready for interaction
        private bool combofull = false;
        public SalaryDetailDTO detail = new SalaryDetailDTO();
        public bool isUpdate = false;


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
        ("Salary", "Salary"),
        ("Year", "Year"),
        ("Month", "Month"),
        ("ImagePath", "Image Path"),
        ("DepartmentName", "Department"),
        ("PositionName", "Position"),



            };
            // Add columns
            foreach (var col in columns)
            {
                dataGridView1.Columns.Add(col.PropertyName, col.HeaderText);
                dataGridView1.Columns[col.PropertyName].DataPropertyName = col.PropertyName;

            }

            General.StyleDataGridView(dataGridView1);
        }
        public FrmSalary()
        {
            InitializeComponent();
        }

        void LoadImage()
        {
            if (int.TryParse(useridTxt.Text, out int userNo))
            {
                var employee = EmployeeBLL.GetEmployeeData()
                                          .Employees
                                          .FirstOrDefault(x => x.EmployeeNo == userNo);

                if (employee != null && !string.IsNullOrEmpty(employee.ImagePath))
                {
                    string fullImagePath = Path.Combine(
                        @"C:\Users\JYSSD\Documents\Rider\PersonelTracking\PersonelTracking\bin\Debug\net9.0-windows\Images",
                        employee.ImagePath);

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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSalary_KeyDown(object sender, KeyEventArgs e)
        {
            General.isAnyText(txtSalary, "Salary");
        }

        private void txtYear_KeyDown(object sender, KeyEventArgs e)
        {
            General.isAnyText(txtYear, "Year");
        }

        SalaryDTO dto = new SalaryDTO();
        private void FrmSalary_Load(object sender, EventArgs e)
        {
            dto = SalariesBLL.GetSalaryData();

            // Disconnect RowEnter
            dataGridView1.RowEnter -= dataGridView1_RowEnter;

            // Set DataGridView data source
            dataGridView1.DataSource = dto.Employees;

            if (!isUpdate)
            {

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

                cmbDeparments.SelectedIndex = -1;
                cmbPosition.SelectedIndex = -1;


                //Position Combobox
                cmbPosition.Enabled = false;
                cmbPosition.DataSource = null;
                cmbPosition.Text = "Select Position";

                General.ComboBoxStyleHelper.ApplyCMBDisabledStyle(cmbPosition);

                lblSaved.Text = string.Empty;

                if (dto.Departments.Count > 0)

                    // Enable ComboBox behavior
                    combofull = true;
            }

            //Month ComboBox Stlye
            //Style ComboBoxes
            cmbMonth.DataSource = null;
            cmbMonth.DataSource = dto.Months;
            cmbMonth.DisplayMember = "Month";
            cmbMonth.ValueMember = "ID";
            cmbMonth.Text = "Select Month";
            cmbMonth.SelectedIndex = -1;

            if (isUpdate)
            {
                panel1.Hide();
                useridTxt.Text = detail.EmployeeNo.ToString();
                txtName.Text = detail.FirstName;
                txtSalary.Text = detail.SalaryAmount.ToString();
                txtLastName.Text = detail.LastName;
                txtYear.Text = detail.SalaryYear.ToString();
                cmbMonth.SelectedValue = detail.MonthID;
                txtYear.ForeColor = Color.Lime;
                txtSalary.ForeColor = Color.Lime;

                // Attempt to load image based on useridTxt.Text
                LoadImage();
                lblSaved.Text = string.Empty;
            }

        }
        

        void ResetAll()
        {
            useridTxt.ForeColor = Color.Silver;
            useridTxt.Text = "UserID";
            txtName.ForeColor = Color.Silver;
            txtName.Text = "First Name";
            txtLastName.ForeColor = Color.Silver;
            txtLastName.Text = "Last Name";
            txtSalary.ForeColor = Color.Silver;
            txtSalary.Text = "Salary";
            txtYear.ForeColor = Color.Silver;
            txtYear.Text = "Year";
            cmbMonth.ForeColor = Color.Silver;
            cmbMonth.SelectedIndex = -1;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (txtYear.Text.Trim() == "" || txtYear.Text.Trim() == "Year")
            {
                General.UserMessage(lblSaved, "Please Enter Year!", Color.Red, "Error2.wav");

            }
            else if (cmbMonth.SelectedIndex == -1)
            {
                General.UserMessage(lblSaved, "Please Select Month!", Color.Red, "Error2.wav");

            }
            else if (txtSalary.Text.Trim() == "")
            {
                General.UserMessage(lblSaved, "Please enter salary!", Color.Red, "Error2.wav");
            }
            else if (useridTxt.Text == "" || useridTxt.Text == "User ID")
            {
                General.UserMessage(lblSaved, "Please Select Employee From the list", Color.Red, "Error2.wav");
            }
            else 
            {
                bool control = false;
                if (!isUpdate)
                {
                    if (Salary.EmployeeId == 0)
                    {
                        General.UserMessage(lblSaved, "Please Select Employee From the list", Color.Red, "Error2.wav");
                    }
                    else
                    {
                        Salary.Year = Convert.ToInt32(txtYear.Text);
                        Salary.MonthId = Convert.ToInt32(cmbMonth.SelectedValue);
                        Salary.Amount = Convert.ToInt32(txtSalary.Text);

                        if(Salary.Amount>oldersalary)
                            control = true;
                        //Save Task
                        SalariesBLL.AddSalary(Salary,control);

                        //UI message confirming saved salary

                        General.UserMessage(lblSaved, "Salary saved!", Color.Lime, "Button.wav");

                        ResetAll();

                        Salary = new SalaryModel(); // Reset salaries

                        cmbMonth.SelectedIndex = 1;
                    }
                }
                else 
                {
                    DialogResult result = MessageBox.Show("Are you sure?!", "title", MessageBoxButtons.YesNo);
                    if (DialogResult.Yes == result)
                    {
                        SalaryModel Salary = new SalaryModel();
                        Salary.Id = detail.SalaryID;
                        Salary.EmployeeId = detail.ID;
                        Salary.Year=Convert.ToInt32(txtYear.Text);
                        Salary.MonthId=Convert.ToInt32(cmbMonth.SelectedValue);
                        Salary.Amount=Convert.ToInt32(txtSalary.Text);

                        if (Salary.Amount>detail.OldSalary)
                            control = true;
                        SalariesBLL.UpdateSalary(Salary, control);
                        General.UserMessage(lblSaved, "Salary was updated! Please wait...", Color.Lime, "Button.wav");

                        useridTxt.ForeColor = Color.Silver;
                        txtName.ForeColor = Color.Silver;
                        txtLastName.ForeColor = Color.Silver;
                        txtSalary.ForeColor = Color.Silver;
                        txtYear.ForeColor = Color.Silver;
                        cmbMonth.ForeColor = Color.Silver;

                    }
                }


            }
        

        }

        SalaryModel Salary = new SalaryModel();
        int oldersalary = 0;

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                useridTxt.Text = row.Cells["EmployeeNo"].Value?.ToString() ?? "";
                useridTxt.ForeColor = Color.Lime;
                txtName.Text = row.Cells["FirstName"].Value?.ToString() ?? "";
                txtName.ForeColor = Color.Lime;
                txtLastName.Text = row.Cells["LastName"].Value?.ToString() ?? "";
                txtLastName.ForeColor = Color.Lime;
                txtYear.Text = DateTime.Today.Year.ToString() ?? "";
                txtYear.ForeColor = Color.Lime;
                txtSalary.Text = row.Cells["Salary"].Value?.ToString();
                txtSalary.ForeColor = Color.Lime;
                Salary.EmployeeId = Convert.ToInt32(row.Cells["EmployeeNo"].Value ?? 0);
                oldersalary = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Salary"].Value?.ToString());

                //Selected Salary
                txtSalary.ForeColor = Color.Lime;

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
    }
}
