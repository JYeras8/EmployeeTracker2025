using BLL;
using DAL.DTO;
using PersonelTracking.Helpers;
using System.Drawing.Drawing2D;
using System.Media;
using System.Security.Cryptography.X509Certificates;

namespace PersonelTracking;

public partial class FrmMain : Form
{
    
    public FrmMain()
    {
        InitializeComponent();


    }

    private static bool soundPlayed = false;
    private MatrixAnimation matrix;

    private int currentFrame = 0;
    private System.Windows.Forms.Timer asciiTimer = new System.Windows.Forms.Timer();

    private void FrmMain_Load(object sender, EventArgs e)
    {
        {
            if (!UserStatic.IsAdmin)

            {
                btnDeparment.Visible = false;
                btnPosition.Visible = false;
            }


            richTextBox1.ReadOnly = true;
            richTextBox1.BackColor = Color.Black;
            richTextBox1.ForeColor = Color.Green;
            richTextBox1.Font = new Font("Consolas", 10, FontStyle.Regular);

            int width = richTextBox1.Width ;
            int height = richTextBox1.Height;

            MatrixAnimation matrix = new MatrixAnimation(richTextBox1, width, height, 100);
            matrix.Start();
        }

        if (!soundPlayed)
        {
            try
            {
                SoundPlayer player = new SoundPlayer("Sounds/Boot.wav");
                player.Play(); // or .PlaySync() to wait until it finishes
                soundPlayed = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to play sound: {ex.Message}");
            }
        }//Start up sound

        lblWelcome.Text = $"Welcome, {UserStatic.FirstName}" + "!";
    }

    private void btnTask_Click(object sender, EventArgs e)
    {
        FrmTaskList frm = new FrmTaskList();
        this.Hide();
        frm.ShowDialog();
        this.Visible = true;
    }

    private void btnDeparment_Click(object sender, EventArgs e)
    {
        FrmDeparmentList frm = new FrmDeparmentList();
        this.Hide();
        frm.ShowDialog();
        this.Visible = true;
    }

    private void btnSalary_Click(object sender, EventArgs e)
    {
        FrmSalaryList frm = new FrmSalaryList();
        this.Hide();
        frm.ShowDialog();
        this.Visible = true;
    }

    private void btnEmployee_Click(object sender, EventArgs e)
    {
        if (!UserStatic.IsAdmin)
        {
            EmployeeDTO dto = EmployeeBLL.GetEmployeeData();
            EmployeeDetailDTO detail = dto.Employees.First(x => x.ID == UserStatic.ID);
            FrmEmployee frm = new FrmEmployee();
            frm.detailDTO = detail;
            frm.isUpdate = true;
            
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;

        }
        else
        {
            FrmEmployeeList frm = new FrmEmployeeList();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
    }

    private void btnPosition_Click(object sender, EventArgs e)
    {
        FrmPositionList frm = new FrmPositionList();
        this.Hide();
        frm.ShowDialog();
        this.Visible = true;
    }

    private void Permission_Click(object sender, EventArgs e)
    {
        FrmPermissionList frm = new FrmPermissionList();
        this.Hide();
        frm.ShowDialog();
        this.Visible = true;
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
        FrmLogin frm = new FrmLogin();
        this.Hide();
        frm.ShowDialog();

    }

    private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}