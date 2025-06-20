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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Permissionmodel= DAL.Models.Permission;
using SysTask = System.Threading.Tasks.Task;


namespace PersonelTracking
{
    public partial class frmPermission : Form
    {


        public frmPermission()
        {
            InitializeComponent();
        }

        public bool isUpdate = false;
        public PermissionDetailDTO detailDTO = new PermissionDetailDTO();

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        TimeSpan PermissionDay;
        private void frmPermission_Load(object sender, EventArgs e)
        {
            lblSaved.Text = "";

            // Do this if update button is selected
            if (isUpdate && detailDTO != null)
            {
                useridTxt.Text = detailDTO.EmployeeNo.ToString();
                dpStartDate.Value = detailDTO.StartDate;
                dpComplete.Value = detailDTO.CompleteDate;
                txtExplain.Text = detailDTO.Explaination;
                txtDayAmount.Text = detailDTO.PermissionDayAmount.ToString();

                using (var db = new PersonnelDbContext())
                {
                    var employee = db.Employees.FirstOrDefault(x => x.EmployeeNo == detailDTO.EmployeeNo);
                    if (employee != null && !string.IsNullOrEmpty(employee.ImagePath))
                    {
                        string fullPath = Path.Combine(@"C:\Users\JYSSD\Documents\Rider\PersonelTracking\PersonelTracking\bin\Debug\net9.0-windows\Images", employee.ImagePath);
                        if (File.Exists(fullPath))
                        {
                            byte[] imgBytes = File.ReadAllBytes(fullPath);
                            using (MemoryStream ms = new MemoryStream(imgBytes))
                            {
                                pbProfilePic.Image = Image.FromStream(ms);
                            }
                            pbProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                }
            }

            //Do this is new button is selected
            else
                // Load and show employee profile picture
                using (var db = new PersonnelDbContext())
                {
                    useridTxt.Text = UserStatic.EmployeeNo.ToString();
                    useridTxt.ForeColor = Color.Lime;
                    lblSaved.Text = "";
                    var employee = db.Employees.FirstOrDefault(x => x.Id == UserStatic.ID);
                    if (employee != null && !string.IsNullOrEmpty(employee.ImagePath))
                    {
                        string fullPath = Path.Combine(@"C:\Users\JYSSD\Documents\Rider\PersonelTracking\PersonelTracking\bin\Debug\net9.0-windows\Images", employee.ImagePath);
                        if (File.Exists(fullPath))
                        {
                            byte[] imgBytes = File.ReadAllBytes(fullPath);
                            using (MemoryStream ms = new MemoryStream(imgBytes))
                            {
                                pbProfilePic.Image = Image.FromStream(ms);
                            }
                            pbProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;

                        }
                    }
                }
        }

        private void dpStartDate_ValueChanged(object sender, EventArgs e)
        {
            PermissionDay = dpComplete.Value.Date - dpStartDate.Value;
            txtDayAmount.Text = PermissionDay.TotalDays.ToString();
            txtDayAmount.ForeColor = Color.Lime;
        }

        private void dpComplete_ValueChanged(object sender, EventArgs e)
        {
            PermissionDay = dpComplete.Value.Date - dpStartDate.Value.Date;
            txtDayAmount.Text = ((int)PermissionDay.TotalDays).ToString();
        }

        async void UserMessage(string Message, Color TextColor, string Sound)
        {
            lblSaved.Text = Message;
            lblSaved.ForeColor = TextColor;
            //Play Error sound
            General.PlaySound(Sound);

            await SysTask.Delay(2000); // Short delay to clear lblsaved text.
            lblSaved.Text = "";

        }
        private async void btnSave_Click(object sender, EventArgs e)
        {


            if (txtDayAmount.Text == "" || txtDayAmount.Text == "Day Amount")
            {
                UserMessage("Please change end or start date!", Color.Red, "Error2.wav");

            }
            else if (txtDayAmount.Text == "Day Amount" || !int.TryParse(txtDayAmount.Text, out int dayAmount) || dayAmount < 0)

            {
                UserMessage("Date must exceed 0 days!", Color.Red, "Error2.wav");
            }
            else if (txtExplain.Text == "" || txtExplain.Text == "Permission Description")
            {
                UserMessage("Please enter explaination!", Color.Red, "Error2.wav");
            }
            else
            {
                if (isUpdate)
                {
                    DialogResult result = MessageBox.Show("Are you Sure?", "Warning", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Permission permission = new Permission
                        {
                            Id = detailDTO.PermissionID,
                            PermissionStartDate = DateOnly.FromDateTime(dpStartDate.Value),
                            PermissionEndDate = DateOnly.FromDateTime(dpComplete.Value),
                            PermissionExplain = txtExplain.Text,
                            PermissionDay = Convert.ToInt32(txtDayAmount.Text),
                            PermissionState = detailDTO.State // ← ADD THIS LINE
                        };

                        PermissionBLL.UpdatePermission(permission);
                        UserMessage("Permission was Updated!", Color.Lime, "Button.wav");
                        this.Close();
                    }
                }
                else
                {
                    Permission permission = new Permission
                    {
                        EmployeeId = UserStatic.ID,
                        PermissionState = 1,
                        PermissionStartDate = DateOnly.FromDateTime(dpStartDate.Value),
                        PermissionEndDate = DateOnly.FromDateTime(dpComplete.Value),
                        PermissionDay = Convert.ToInt32(txtDayAmount.Text),
                        PermissionExplain = txtExplain.Text
                    };

                    PermissionBLL.AddPermission(permission);
                    //Saved Sound
                    UserMessage("Permission was Added!", Color.Lime, "Button.wav");

                    // Clear textboxes
                    useridTxt.Clear();
                    txtDayAmount.Clear();
                    dpStartDate.Value = DateTime.Today;
                    dpComplete.Value = DateTime.Today;
                    txtDayAmount.Clear();
                    txtExplain.Clear();


                    //Reset task title and content box.
                    useridTxt.Text = UserStatic.EmployeeNo.ToString();
                    txtDayAmount.Text = "";
                    useridTxt.ForeColor = Color.Silver;
                    txtDayAmount.ForeColor = Color.Silver;

                    permission = new Permissionmodel(); // Reset task

                    txtExplain.Text = "Permission Description";
                    txtExplain.ForeColor = Color.Silver;

                    txtDayAmount.Text = "Day Amount";
                    txtDayAmount.ForeColor = Color.Silver;
                }
            }
        }

        private void txtExplain_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtExplain_KeyPress(object sender, KeyPressEventArgs e)
        {
            General.isAnyText(txtExplain, "Permission Description");
        }
    }
}
