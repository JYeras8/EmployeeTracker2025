// Clean rewrite to follow teacher's pattern fully
// - Central FillGrid()
// - No redundant new List<> calls
// - Clear comments

using BLL;
using DAL.DTO;
using PersonelTracking.Helpers;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PersonelTracking;

public partial class FrmPositionList : Form
{
    public FrmPositionList()
    {
        InitializeComponent();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {
    }

    // Class-level list to hold data
    List<PositionDTO> positionList;

    // Reusable method to fill the grid
    private void FillGrid()
    {
        PositionBLL bll = new PositionBLL();
        positionList = bll.GetPositions();
        dataGridView1.DataSource = positionList;
    }

    private void btnNew_Click(object sender, EventArgs e)
    {
        FrmPosition frm = new FrmPosition();
        this.Hide();
        frm.ShowDialog();
        this.Visible = true;

        // Refresh grid after adding
        FillGrid();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (detailDto.Id == 0)
        {
            General.UserMessage(lblSaved, "Please Sekect a Position from the table", Color.Red, "Error2.wav");
        }
        else

        {
            FrmPosition frm = new FrmPosition();
            frm.isUpdate = true;
            frm.detailDTO = detailDto;

            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
        // Optional: you may call FillGrid() here too if needed
        FillGrid();

    }

    PositionDTO detailDto = new PositionDTO();

    private void FrmPositionList_Load(object sender, EventArgs e)
    {
        FillGrid();

        // Adjust column visibility and headers
        dataGridView1.Columns[0].HeaderText = "PositionID";
        dataGridView1.Columns[1].HeaderText = "Position Name";
        dataGridView1.Columns[2].HeaderText = "Department Name";
        dataGridView1.Columns[3].HeaderText = "DepartmentID";

        //Visiblility
        dataGridView1.Columns[0].Visible = false;
        dataGridView1.Columns[4].Visible = false;
        dataGridView1.Columns[3].Visible = false;

        dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        // Auto sizing for readability


        // Apply custom style
        General.StyleDataGridView(dataGridView1);

        lblSaved.Text = string.Empty;



    }

    private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
    {
        {
            var row = dataGridView1.Rows[e.RowIndex];

            detailDto.PositionName = row.Cells["PositionName"].Value.ToString();
            detailDto.Id = Convert.ToInt32(row.Cells["ID"].Value);
            detailDto.DepartmentId = Convert.ToInt32(row.Cells["DepartmentID"].Value);
            detailDto.OldDeparmentID = Convert.ToInt32(row.Cells["OldDeparmentID"].Value);
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        General.YNCheck("Are you Sure?", MessageBoxButtons.YesNo);
        DialogResult = DialogResult.Yes;

        {
            PositionBLL.DeletePosition(detailDto.Id);
            General.UserMessage(lblSaved, "Position was deleted!", Color.Lime, "Button.wav");
            FillGrid();

        }

    }
}


