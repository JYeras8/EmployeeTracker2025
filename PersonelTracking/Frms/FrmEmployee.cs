using BLL;
using DAL;
using DAL.DTO;
using DAL.Models;
using PersonelTracking.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using SysTask = System.Threading.Tasks.Task;



namespace PersonelTracking
{


    public partial class FrmEmployee : Form
    {

        //Setup Variables
        EmployeeBLL bll = new EmployeeBLL();
        EmployeeDTO dto;
        bool combofull = false;

        //Variable to check if Id is unique.
        bool IsIDUnique = false;

        //this picture name must be unique or else it will cause problems down the line
        string filename = "";

        

        public FrmEmployee()
        {
            InitializeComponent();
        }

        public EmployeeDetailDTO detailDTO = new EmployeeDetailDTO();
        public bool isUpdate = false;


        private void ExitButton_Click(object sender, EventArgs e)
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

        private void PasswordTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (!UserStatic.IsAdmin)
            {
                passwordTxt.ForeColor = Color.Lime;
            }
            else 
            {
                General.isPasswordText(passwordTxt, e);
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

        private void txtImagePath_KeyDown(object sender, KeyEventArgs e)
        {
            General.isAnyText(txtImagePath, "Image Path");
        }

        private void txtSalary_KeyDown(object sender, KeyEventArgs e)
        {
            General.isAnyText(txtSalary, "Salary");
        }

        private void txtDob_KeyPress(object sender, KeyPressEventArgs e)
        {
            General.isDateText(txtDob, e, "D.O.B");
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            General.isAnyText(txtAddress, "Address");
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            lblSaved.Text = "";

            {
                dto = EmployeeBLL.GetEmployeeData();

                cmbPosition.DataSource = dto.Positions;

                cmbDeparments.DataSource = dto.Departments;

                cmbDeparments.DisplayMember = "DepartmentName";
                cmbDeparments.ValueMember = "Id";

                cmbPosition.DisplayMember = "PositionName";
                cmbPosition.ValueMember = "Id";

                cmbDeparments.SelectedIndex = -1;
                cmbDeparments.Text = "Select Department";
                cmbPosition.SelectedIndex = -1; ;
                cmbPosition.Text = "Select Position";

                // Now enable combobox event
                combofull = true;

                if (!isUpdate)
                {


                    // Disable Position ComboBox initially
                    cmbPosition.Enabled = false;
                    General.ComboBoxStyleHelper.ApplyCMBDisabledStyle(cmbPosition);

                    lblSaved.Text = "";
                }

                if (isUpdate)
                {
                    txtName.Text = detailDTO.FirstName;
                    txtLastName.Text = detailDTO.LastName;
                    useridTxt.Text = detailDTO.EmployeeNo.ToString();
                    passwordTxt.Text = detailDTO.Password;
                    chAdmin.Checked = detailDTO.IsAdmin;
                    txtAddress.Text = detailDTO.Address;
                    txtDob.Text = detailDTO.Birthday.ToString(); ;
                    txtSalary.Text = detailDTO.Salary.ToString();
                    txtImagePath.Text = detailDTO.ImagePath;

                    cmbDeparments.SelectedValue = detailDTO.DepartmentID;
                    cmbPosition.SelectedValue = detailDTO.PositionID;

                    LoadImage();

                    if (!UserStatic.IsAdmin)
                    {
                        chAdmin.Enabled = false;
                        useridTxt.Enabled = false;
                        txtSalary.Enabled = false;
                        cmbDeparments.Enabled = false;
                        cmbPosition.Enabled = false;
                        //passwordTxt.PasswordChar = '*';
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

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Erase previous image from memory if any
                if (pbProfilePic.Image != null)
                {
                    Image oldImage = pbProfilePic.Image;
                    pbProfilePic.Image = null;
                    oldImage.Dispose();
                }
                pbProfilePic.Image = Image.FromFile(openFileDialog1.FileName);
                txtImagePath.Text = openFileDialog1.FileName;
                pbProfilePic.SizeMode = PictureBoxSizeMode.Zoom; // this will center and scale

                //Unique string for picture
                string unique = Guid.NewGuid().ToString("N").Substring(0, 10); // 10-char hex
                filename = $"{unique}_{openFileDialog1.SafeFileName}";


                //Apply text box
                General.Textboxhelper.ApplyTextBoxStyle(txtImagePath);

            }
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

        private async void btnSave_Click(object sender, EventArgs e)
        {
            
            if (useridTxt.Text == "" || useridTxt.Text == "User ID")
            {
                General.UserMessage(lblSaved, "Please enter User ID!", Color.Red, "Error2.wav");
            }

            else if (passwordTxt.Text == "" || passwordTxt.Text == "Password")
            {
                General.UserMessage(lblSaved, "Please enter Password", Color.Red, "Error2.wav");
            }
            else if (txtName.Text == "" || txtName.Text == "First Name")
            {
                General.UserMessage(lblSaved, "Please enter First Name!", Color.Red, "Error2.wav");
            }
            else if (txtLastName.Text == "" || txtLastName.Text == "Last Name")
            {
                General.UserMessage(lblSaved, "Please enter Last Name!", Color.Red, "Error2.wav");
            }
            else if (txtImagePath.Text == "" || txtImagePath.Text == "Image Path")
            {
                General.UserMessage(lblSaved, "Please upload image!", Color.Red, "Error2.wav");
            }
            else if (txtSalary.Text == "" || txtSalary.Text == "Salary")
            {
                General.UserMessage(lblSaved, "Please enter Salary!", Color.Red, "Error2.wav");
            }
            else if (cmbDeparments.Text == "" || cmbDeparments.Text == "Select Department")
            {
                General.UserMessage(lblSaved, "Please enter Deparment!", Color.Red, "Error2.wav");
            }
            else if (cmbPosition.Text == "" || cmbPosition.Text == "Select Position")
            {
                General.UserMessage(lblSaved, "Please enter Position!", Color.Red, "Error2.wav");
            }
            else if (txtDob.Text == "" || txtDob.Text == "D.O.B")
            {
                General.UserMessage(lblSaved, "Please enter Date of Birth!", Color.Red, "Error2.wav");
            }
            else if (txtAddress.Text == "" || txtAddress.Text == "Address")
            {
                General.UserMessage(lblSaved, "Please enter Current Address!", Color.Red, "Error2.wav");
            }

                if (!isUpdate)
                {
                    if (!EmployeeBLL.IsIDUnique(Convert.ToInt32(useridTxt.Text)))

                        General.UserMessage(lblSaved, "please change user ID.", Color.Red, "Error2.wav");
                    else
                    {

                        //Enter Employee into DB
                        //Create new instnace
                        Employee employee = new Employee();

                        //Credentials
                        employee.EmployeeNo = Convert.ToInt32(useridTxt.Text);
                        employee.Password = passwordTxt.Text;
                        employee.IsAdmin = chAdmin.Checked;

                        //Employee Info
                        employee.FirstName = txtName.Text;
                        employee.LastName = txtLastName.Text;
                        employee.Address = txtAddress.Text;
                        employee.Salary = Convert.ToInt32(txtSalary.Text);

                        //Birthday is text.
                        if (DateOnly.TryParse(txtDob.Text, out var dob))
                            employee.Birthday = dob.ToDateTime(TimeOnly.MinValue);
                        else
                        {
                            General.UserMessage(lblSaved, "Invalid Date format! MM/dd/yyyy or M/d/yyyy!", Color.Red, "Error2.wav");
                            return;
                        }

                        //Deparment info
                        employee.DepartmentId = Convert.ToInt32(cmbDeparments.SelectedValue);
                        employee.PositionId = Convert.ToInt32(cmbPosition.SelectedValue);


                        // Save image to *exact* net9.0-windows\Images, regardless of where app is running

                        string sourcePath = txtImagePath.Text;

                        // Go up to project root
                        string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));

                        // Build exact path
                        string targetPath = Path.Combine(projectRoot, @"bin\Debug\net9.0-windows\Images");

                        // Create if missing
                        Directory.CreateDirectory(targetPath);

                        // Copy file
                        File.Copy(sourcePath, Path.Combine(targetPath, filename), true);

                        // Save filename only to DB
                        employee.ImagePath = filename;


                        //Add employee Method
                        bll.AddEmployee(employee);
                        //Reset DTO
                        dto = EmployeeBLL.GetEmployeeData();


                        //Reset Text
                        useridTxt.Text = "User ID";
                        useridTxt.ForeColor = Color.DarkGray;

                        passwordTxt.Text = "Password";
                        passwordTxt.ForeColor = Color.DarkGray;
                        passwordTxt.PasswordChar = '\0';

                        txtName.Text = "First Name";
                        txtName.ForeColor = Color.DarkGray;

                        txtLastName.Text = "Last Name";
                        txtLastName.ForeColor = Color.DarkGray;

                        txtImagePath.Text = "Image Path";
                        txtImagePath.ForeColor = Color.DarkGray;

                        txtSalary.Text = "Salary";
                        txtSalary.ForeColor = Color.DarkGray;

                        txtDob.Text = "D.O.B";
                        txtDob.ForeColor = Color.DarkGray;

                        txtAddress.Text = "Address";
                        txtAddress.ForeColor = Color.DarkGray;

                        pbProfilePic.Image = null;

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

                        General.UserMessage(lblSaved, "Employee Saved!", Color.Lime, "Button.wav");
                    }

                }

                else
                {
                    DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Employee employee = new Employee();

                        string imageDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");

                        if (!Directory.Exists(imageDir))
                            Directory.CreateDirectory(imageDir);

                        // Copy new image only if it was changed
                        if (txtImagePath.Text != Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", detailDTO.ImagePath))
                        {
                            string oldPath = Path.Combine(imageDir, detailDTO.ImagePath ?? "");

                            if (File.Exists(oldPath))
                                File.Delete(oldPath);

                            string newFileName = Path.GetFileName(txtImagePath.Text); // e.g. "terance.png"
                            string newPath = Path.Combine(imageDir, newFileName);

                            // ✅ FIX: Build path that explicitly targets net9.0-windows\Images
                            string sourcePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\net9.0-windows\Images", newFileName));

                            File.Copy(sourcePath, newPath, true);

                            employee.ImagePath = newFileName;
                        }
                        else
                        {
                            employee.ImagePath = detailDTO.ImagePath;
                        }

                        // Assign other fields
                        employee.Id = detailDTO.ID;
                        employee.EmployeeNo = Convert.ToInt32(useridTxt.Text);
                        employee.FirstName = txtName.Text;
                        employee.LastName = txtLastName.Text;
                        employee.Password = passwordTxt.Text;
                        employee.IsAdmin = chAdmin.Checked;
                        employee.Address = txtAddress.Text;
                        employee.Birthday = Convert.ToDateTime(txtDob.Text);
                        employee.DepartmentId = Convert.ToInt32(cmbDeparments.SelectedValue);
                        employee.PositionId = Convert.ToInt32(cmbPosition.SelectedValue);
                        employee.Salary = Convert.ToInt32(txtSalary.Text);

                        EmployeeBLL.UpdateEmployee(employee);

                        General.UserMessage(lblSaved, "Employee was updated", Color.Lime, "Button.wav");
                        this.Close();
                    }

                } //do this if all succeds!

            } //do this if isupdate is true
        


        private async void btnCheck_Click(object sender, EventArgs e)
        {
            if (useridTxt.Text == "" || useridTxt.Text == "User ID")
            {
                lblSaved.Text = "Please enter User ID";

                await SysTask.Delay(2000); // Resets label 
                lblSaved.Text = "";
            }
            else
            {
                bool isUnique = EmployeeBLL.IsIDUnique(Convert.ToInt32(useridTxt.Text));

                if (!isUnique)
                {
                    if (!isUpdate)
                    {
                        lblSaved.Text = "This User ID is used by another employee, please change.";

                        await SysTask.Delay(2000); // Resets label 
                        lblSaved.Text = "";
                    }
                    else
                    {
                        lblSaved.Text = "This User ID is usable.";

                        await SysTask.Delay(2000); // Resets label 
                        lblSaved.Text = "";
                    }
                }
            }
        }
    }

}
