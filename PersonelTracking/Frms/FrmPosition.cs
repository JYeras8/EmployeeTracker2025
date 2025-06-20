using BLL;
using DAL;
using DAL.DTO;
using DAL.Models;
using PersonelTracking.Helpers;
using SysTask = System.Threading.Tasks.Task;


namespace PersonelTracking;


public partial class FrmPosition : Form
{

    List<Department> departmentlist = new List<Department>(); //Declaring List

    public PositionDTO detailDTO = new PositionDTO();
    public bool isUpdate = false;


    public FrmPosition()
    {

        InitializeComponent();
    }

    private void ExitButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void txtPostion_KeyDown(object sender, KeyEventArgs e)
    {
        General.isAnyText(txtPostion, "Position");
    }

    private void cmbDeparments_DropDown(object sender, EventArgs e)
    {

    }

    private void FrmPosition_Load(object sender, EventArgs e)
    {
        departmentlist = new DepartmentBLL().GetDepartments();

        cmbDeparments.DataSource = departmentlist;
        cmbDeparments.DisplayMember = "DepartmentName"; // use your actual property name!
        cmbDeparments.ValueMember = "ID";               // use your actual primary key name!
        cmbDeparments.SelectedIndex = -1;

        if (isUpdate)
        {
            txtPostion.Text=detailDTO.PositionName;
            cmbDeparments.SelectedValue = detailDTO.DepartmentId;
        }
    }

    private async void btnSave_Click(object sender, EventArgs e)
    {
        if (txtPostion.Text.Trim() == "" || txtPostion.Text.Trim() == "Position")
        { 
            General.UserMessage(lblSaved, "Please fill in the position name!", Color.Red, "Error2.wav");
        }
        else if (cmbDeparments.SelectedIndex == -1)

        {
            General.UserMessage(lblSaved, "Please choose a Department position name!", Color.Red, "Error2.wav");

        }
        else
        {
            if (!isUpdate)
            {
                Position position = new Position();
                position.PositionName = txtPostion.Text;
                position.DeparmentId = Convert.ToInt32(cmbDeparments.SelectedValue);


                PositionBLL bll = new PositionBLL();
                bll.AddPosition(position); //add position

                General.UserMessage(lblSaved, "Position Saved!", Color.Lime, "Button.wav");
            }
            else 
            {
                Position position = new Position();
                position.Id=detailDTO.Id;
                position.PositionName=txtPostion.Text;
                position.DeparmentId = Convert.ToInt32(cmbDeparments.SelectedValue);
                bool control =false;
                if (Convert.ToInt32(cmbDeparments.SelectedValue) != detailDTO.OldDeparmentID)
                
                        control = true;
                PositionBLL.UpdatePosition(position, control);
                General.UserMessage(lblSaved, "Position was updated! Please Wait...", Color.Lime, "Button.wav");

                await SysTask.Delay(2000);
                this.Close();

            }
        }




    }
}