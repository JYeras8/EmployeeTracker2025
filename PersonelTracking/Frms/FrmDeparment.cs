using BLL;
using DAL.Models;
using PersonelTracking.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using SysTask = System.Threading.Tasks.Task;


namespace PersonelTracking;

public partial class FrmDeparment : Form
{
    public FrmDeparment()
    {
        InitializeComponent();
    }
    public bool isUpdate = false;
    public Department detailDTO = new Department();
    private void FrmDeparment_Load(object sender, EventArgs e)
    {
        txtDepartment.Text = "Enter Deparment Name";
        lblSaved.Text = "";


        if (isUpdate)
        {
            txtDepartment.Text = detailDTO.DepartmentName;
        }
    }

    private void txtDepartment_KeyPress(object sender, KeyPressEventArgs e)
    {
        General.isAnyText(txtDepartment, "Enter Deparment Name");
    }

    private void ExitButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private async void btnSave_Click(object sender, EventArgs e)
    {
        if (txtDepartment.Text == "" || txtDepartment.Text == "Enter Deparment Name")
        {
            General.UserMessage(lblSaved, "Please fill the name field!", Color.Red, "Error2.wav");
        }

        else 
        {
            Department department = new Department();
            if (!isUpdate) 
            {
                department.DepartmentName = txtDepartment.Text;

                DepartmentBLL bll = new DepartmentBLL();
                bll.AddDepartment(department);
                txtDepartment.Clear();
                txtDepartment.Text = "Enter Deparment Name";
                General.UserMessage(lblSaved, "Department Saved!", Color.Lime, "Button.wav");

            }
            else
            {
                DialogResult result = General.YNCheck("Are you sure?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                   department.Id = detailDTO.Id;
                   department.DepartmentName = txtDepartment.Text;
                   DepartmentBLL.UpdateDepartment(department);
                   General.UserMessage(lblSaved, "Department was updated! Please Wait...", Color.Lime, "Button.wav");
                   this.Close();


                    await SysTask.Delay(2000); // waits for 2 seconds
                    




                }
                else
                {
                    // Do something else if No
                }
            }
        }


    }
}