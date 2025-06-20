using System;
using System.Windows.Forms;
using BLL;
using DAL.Models;
using System.IO;
using SysTask = System.Threading.Tasks.Task;
using PersonelTracking.Helpers;



namespace PersonelTracking;

public partial class FrmLogin : Form
{
    public FrmLogin()
    {
        InitializeComponent();
    }


    private void useridTxt_KeyPress(object sender, KeyPressEventArgs e)
    {
        General.isNumber(useridTxt, e, "User ID");
    }


    private void PasswordTxt_KeyDown(object sender, KeyEventArgs e)
    {
        General.isUserIdText(PasswordTxt, "Password");
        PasswordTxt.PasswordChar = '*';
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void useridTxt_KeyDown(object sender, KeyEventArgs e)
    {
        useridTxt.ForeColor = Color.Lime;
    }

    private async void btnEnter_Click(object sender, EventArgs e)
    {
        if (useridTxt.Text.Trim() == "" || useridTxt.Text.Trim() == "UserID" || PasswordTxt.Text.Trim() == "" || PasswordTxt.Text.Trim() == "Password")
        {
            lblSaved.Text = "Please fill the userno and password";
            lblSaved.ForeColor = Color.Red;
            //Play Error sound
            General.PlaySound("Error2.wav");

            await SysTask.Delay(2000); // Resets label 
            lblSaved.Text = "";
        }
        else
        {
            List<Employee> employeelist = EmployeeBLL.GetEmployees(
                Convert.ToInt32(useridTxt.Text),
                PasswordTxt.Text
            );

            if (employeelist.Count == 0)
            {
                lblSaved.Text = "User not Found";

                lblSaved.ForeColor = Color.Red;
                //Play Error sound
                General.PlaySound("Error2.wav");
                await SysTask.Delay(2000); // Resets label 
                lblSaved.Text = "";
            }
            else
            {
                Employee employee=new Employee();
                employee=employeelist.First();
                UserStatic.EmployeeNo = employee.EmployeeNo;
                UserStatic.ID = employee.Id;
                UserStatic.IsAdmin = Convert.ToBoolean(employee.IsAdmin);
                UserStatic.FirstName = employee.FirstName;
                UserStatic.LastName = employee.LastName;

                FrmMain frm = new FrmMain();
                this.Hide();
                frm.ShowDialog();
            }
        }



    }

    private void PasswordTxt_KeyPress(object sender, KeyPressEventArgs e)
    {

    }

    private void FrmLogin_Load(object sender, EventArgs e)
    {
        PasswordTxt.ForeColor = Color.DarkGray;
        PasswordTxt.PasswordChar = '\0';

        lblSaved.Text = "";
    }
}


