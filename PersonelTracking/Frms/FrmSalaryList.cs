using BLL;
using DAL;
using DAL.DTO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PersonelTracking
{
    public partial class FrmSalaryList : Form
    {
        public FrmSalaryList()
        {
            InitializeComponent();
        }

        SalaryDTO dto = new SalaryDTO();
        private bool combofull = false;



        void FillAllData()
        {
            dto = SalariesBLL.GetSalaryData();

            if (!UserStatic.IsAdmin)
                dto.Salaries = dto.Salaries.Where(x => x.EmployeeNo == UserStatic.EmployeeNo).ToList();

            dataGridView1.DataSource = dto.Salaries;
            combofull = false;

            dataGridView1.Columns["EmployeeNo"].Visible = false;
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["SalaryID"].Visible = false;
            dataGridView1.Columns["ImagePath"].Visible = false;
            dataGridView1.Columns["MonthName"].Visible = false;
            dataGridView1.Columns["DepartmentName"].Visible = false;
            dataGridView1.Columns["PositionName"].Visible = false;
            dataGridView1.Columns["DepartmentID"].Visible = false;
            dataGridView1.Columns["PositionID"].Visible = false;
            dataGridView1.Columns["MonthID"].Visible = false;

            dataGridView1.Columns["FirstName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["LastName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["SalaryAmount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns["SalaryYear"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns["OldSalary"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            General.StyleDataGridView(dataGridView1);

            cmbDeparments.DataSource = dto.Departments;
            cmbDeparments.DisplayMember = "DepartmentName";
            cmbDeparments.ValueMember = "Id";
            cmbDeparments.SelectedIndex = -1;
            cmbDeparments.Text = "Select Department";

            cmbPosition.DataSource = dto.Positions;
            cmbPosition.DisplayMember = "PositionName";
            cmbPosition.ValueMember = "Id";
            cmbPosition.SelectedIndex = -1;
            cmbPosition.Text = "Select Position";
            cmbPosition.Enabled = false;
            General.ComboBoxStyleHelper.ApplyCMBDisabledStyle(cmbPosition);

            cmbMonth.DataSource = dto.Months;
            cmbMonth.DisplayMember = "Month";
            cmbMonth.ValueMember = "ID";
            cmbMonth.SelectedIndex = -1;
            cmbMonth.Text = "Select Month";

            combofull = true;

            if (!UserStatic.IsAdmin)
                btnNew.Hide();
            btnDelete.Hide();
            pnlForAdmin.Hide();



        }

        void ClearFilter()
        {

            useridTxt.Text = "User ID";
            useridTxt.ForeColor = Color.DarkGray;

            txtName.Text = "First Name";
            txtName.ForeColor = Color.DarkGray;

            txtLastName.Text = "Last Name";
            txtLastName.ForeColor = Color.DarkGray;

            rbMore.Checked = false;
            rbLessThan.Checked = false;
            rbEqual.Checked = false;

            combofull = false;


            // Reset Combo Boxes
            //Deparment ComboBox
            cmbDeparments.DataSource = null;
            cmbDeparments.DataSource = dto.Departments;
            cmbDeparments.DisplayMember = "DepartmentName";
            cmbDeparments.ValueMember = "Id";
            cmbDeparments.SelectedIndex = -1;
            cmbDeparments.Text = "Select Department";

            cmbMonth.DataSource = null;
            cmbMonth.DataSource = dto.Departments;
            cmbMonth.DisplayMember = "Month";
            cmbMonth.SelectedIndex = -1;

            //Position Combobox
            cmbPosition.Enabled = false;
            cmbPosition.DataSource = null;
            cmbPosition.Text = "Select Position";
            General.ComboBoxStyleHelper.ApplyCMBDisabledStyle(cmbPosition);

            combofull = true;

            dataGridView1.DataSource = dto.Salaries;
        }

        private void FrmSalaryList_Load(object sender, EventArgs e)
        {
            FillAllData();

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
                General.isNumber(useridTxt, e, "User ID");
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            General.isAnyText(txtName, "First Name");
        }

        private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        {
            General.isAnyText(txtLastName, "Last Name");
        }

        private void txtSalary_KeyDown(object sender, KeyEventArgs e)
        {
            General.isAnyText(txtSalary, "Salary");
        }


        private void txtYear_KeyDown(object sender, KeyEventArgs e)
        {
            General.isAnyText(txtYear, "Year");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmSalary frm = new FrmSalary();
            this.Hide();
            frm.ShowDialog(); // blocks until closed
            this.Show();
            FillAllData();
        }

        SalaryDetailDTO detailDTO = new SalaryDetailDTO();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detailDTO.SalaryID == 0)
                General.UserMessage(lblSaved, "Please Select a Salary on table", Color.Red, "Error2.wav");
            else
            {
                FrmSalary frm = new FrmSalary
                {
                    isUpdate = true,
                    detail = detailDTO
                };

                this.Hide();
                frm.ShowDialog(); // blocks until closed
                this.Show();
                FillAllData();
                ClearFilter();
            }
        }


        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                useridTxt.Text = row.Cells["EmployeeNo"].Value?.ToString();
                txtName.Text = row.Cells["FirstName"].Value?.ToString() ?? "";
                txtLastName.Text = row.Cells["LastName"].Value?.ToString() ?? "";

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

                detailDTO.FirstName = dataGridView1.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                detailDTO.LastName = dataGridView1.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                detailDTO.EmployeeNo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["EmployeeNo"].Value);
                detailDTO.SalaryID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["SalaryID"].Value);
                detailDTO.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                detailDTO.SalaryYear = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["SalaryYear"].Value);
                detailDTO.MonthID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["MonthID"].Value);
                detailDTO.SalaryAmount = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["SalaryAmount"].Value);
                detailDTO.OldSalary = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["OldSalary"].Value);

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            // Search Filters
            List<SalaryDetailDTO> list = dto.Salaries;

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
            if (txtYear.Text.Trim() != "" && txtYear.Text.Trim() != "Year")
                list = list.Where(x => x.SalaryYear == Convert.ToInt32(txtSalary.Text)).ToList();

            if (txtSalary.Text.Trim() != "" && txtSalary.Text.Trim() != "Salary")
            {
                if (rbMore.Checked)
                    list = list.Where(x => x.SalaryAmount > Convert.ToInt32(txtSalary.Text)).ToList();
                else if (rbLessThan.Checked)
                    list = list.Where(x => x.SalaryAmount < Convert.ToInt32(txtSalary.Text)).ToList();
                else
                    list = list.Where(x => x.SalaryAmount == Convert.ToInt32(txtSalary.Text)).ToList();
            }


        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            General.YNCheck("Are you Sure?", MessageBoxButtons.YesNo);
            DialogResult = DialogResult.Yes;
            {
                SalariesBLL.DeleteSalary(detailDTO.SalaryID);
                General.UserMessage(lblSaved, "Salary Deleted!", Color.Lime, "Button.wav");
                FillAllData();
                ClearFilter();
            }
        }

        private void bntExport_Click(object sender, EventArgs e)
        {
            ExcelExporter.ExportDataGridView(dataGridView1, "Salaries", "SalaryList");
        }
    }
}
