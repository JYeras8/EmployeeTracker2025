using BLL;
using DAL.Models;
using PersonelTracking.Helpers;

namespace PersonelTracking;

public partial class FrmDeparmentList : Form
{
    public FrmDeparmentList()
    {
        InitializeComponent();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    DepartmentBLL bll = new DepartmentBLL(); // create an instance of DepartmentBLL

    private void btnNew_Click(object sender, EventArgs e)
    {
        FrmDeparment frm = new FrmDeparment();
        this.Hide();
        frm.ShowDialog();
        this.Visible = true;
        list = bll.GetDepartments();
        dataGridView1.DataSource = list;
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (detailDTO.Id == 0)
            General.UserMessage(lblSaved, "Please Select a Department on table!", Color.Red, "Error2.wav");

        FrmDeparment frm = new FrmDeparment();
        frm.isUpdate = true;
        frm.detailDTO = detailDTO;
        this.Hide();
        frm.ShowDialog();
        this.Visible = true;
        list = bll.GetDepartments();
        dataGridView1.DataSource = list;
    }

    List<Department> list = new List<Department>();

    public Department detailDTO = new Department();

    private void FrmDeparmentList_Load(object sender, EventArgs e)
    {
        lblSaved.Text = string.Empty;

        DepartmentBLL bll = new DepartmentBLL(); // create an instance of DepartmentBLL
        list = bll.GetDepartments();
        dataGridView1.DataSource = list;

        //Name Columns
        dataGridView1.Columns[0].HeaderText = "DPID";
        dataGridView1.Columns[0].Visible = false;
        dataGridView1.Columns[1].HeaderText = "Department Name";

        //Format the sheet to have ID row fixed at 60 and the rest of the columns fill.
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        dataGridView1.Columns[0].Width = 50;
        General.StyleDataGridView(dataGridView1);


    }

    private void FrmDeparmentList_FormClosed(object sender, FormClosedEventArgs e)
    {

    }

    private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
    {
        detailDTO.Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
        detailDTO.DepartmentName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        General.YNCheck("Are you Sure?", MessageBoxButtons.YesNo);
        DialogResult = DialogResult.Yes;
        {
            DepartmentBLL.DeleteDeparment(detailDTO.Id);
            General.UserMessage(lblSaved, "Department Deleted!", Color.Lime, "Button.wav");
            list = bll.GetDepartments();
            dataGridView1.DataSource = list;
        }
    }
}