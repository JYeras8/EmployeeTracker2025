using System.ComponentModel;

namespace PersonelTracking;

partial class FrmDeparmentList
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
        ComponentResourceManager resources = new ComponentResourceManager(typeof(FrmDeparmentList));
        dataGridView1 = new DataGridView();
        btnNew = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        btnExit = new Button();
        lblSaved = new Label();
        ((ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridViewCellStyle1.BackColor = Color.Black;
        dataGridViewCellStyle1.Font = new Font("Silkscreen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewCellStyle1.ForeColor = Color.Lime;
        dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dataGridView1.BackgroundColor = Color.FromArgb(25, 25, 25);
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaptionText;
        dataGridViewCellStyle2.Font = new Font("Silkscreen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewCellStyle2.ForeColor = Color.Lime;
        dataGridViewCellStyle2.SelectionBackColor = Color.Lime;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.ActiveCaptionText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaptionText;
        dataGridViewCellStyle3.Font = new Font("Silkscreen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewCellStyle3.ForeColor = Color.Lime;
        dataGridViewCellStyle3.SelectionBackColor = Color.Lime;
        dataGridViewCellStyle3.SelectionForeColor = SystemColors.ActiveCaptionText;
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
        dataGridView1.Dock = DockStyle.Top;
        dataGridView1.Location = new Point(0, 0);
        dataGridView1.Margin = new Padding(3, 4, 3, 4);
        dataGridView1.MultiSelect = false;
        dataGridView1.Name = "dataGridView1";
        dataGridView1.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = SystemColors.ActiveCaptionText;
        dataGridViewCellStyle4.Font = new Font("Silkscreen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewCellStyle4.ForeColor = Color.Lime;
        dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
        dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dataGridView1.RowHeadersWidth = 62;
        dataGridViewCellStyle5.BackColor = Color.Black;
        dataGridViewCellStyle5.Font = new Font("Silkscreen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewCellStyle5.ForeColor = Color.Lime;
        dataGridViewCellStyle5.SelectionBackColor = Color.Lime;
        dataGridViewCellStyle5.SelectionForeColor = Color.Black;
        dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
        dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.Black;
        dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("Silkscreen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.Lime;
        dataGridView1.Size = new Size(1186, 877);
        dataGridView1.TabIndex = 0;
        dataGridView1.Text = "dataGridView1";
        dataGridView1.RowEnter += dataGridView1_RowEnter;
        // 
        // btnNew
        // 
        btnNew.BackColor = Color.Black;
        btnNew.Font = new Font("Silkscreen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnNew.ForeColor = Color.Lime;
        btnNew.Location = new Point(230, 902);
        btnNew.Margin = new Padding(3, 4, 3, 4);
        btnNew.Name = "btnNew";
        btnNew.Padding = new Padding(0, 0, 0, 6);
        btnNew.Size = new Size(161, 54);
        btnNew.TabIndex = 1;
        btnNew.Text = "New";
        btnNew.TextAlign = ContentAlignment.BottomCenter;
        btnNew.UseVisualStyleBackColor = false;
        btnNew.Click += btnNew_Click;
        // 
        // btnUpdate
        // 
        btnUpdate.BackColor = Color.Black;
        btnUpdate.Font = new Font("Silkscreen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnUpdate.ForeColor = Color.Lime;
        btnUpdate.Location = new Point(418, 902);
        btnUpdate.Margin = new Padding(3, 4, 3, 4);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Padding = new Padding(0, 0, 0, 6);
        btnUpdate.Size = new Size(161, 54);
        btnUpdate.TabIndex = 2;
        btnUpdate.Text = "Update";
        btnUpdate.TextAlign = ContentAlignment.BottomCenter;
        btnUpdate.UseVisualStyleBackColor = false;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnDelete
        // 
        btnDelete.BackColor = Color.Black;
        btnDelete.Font = new Font("Silkscreen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnDelete.ForeColor = Color.Lime;
        btnDelete.Location = new Point(602, 902);
        btnDelete.Margin = new Padding(3, 4, 3, 4);
        btnDelete.Name = "btnDelete";
        btnDelete.Padding = new Padding(0, 0, 0, 6);
        btnDelete.Size = new Size(161, 54);
        btnDelete.TabIndex = 3;
        btnDelete.Text = "Delete";
        btnDelete.TextAlign = ContentAlignment.BottomCenter;
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnExit
        // 
        btnExit.BackColor = Color.Black;
        btnExit.Font = new Font("Silkscreen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnExit.ForeColor = Color.Lime;
        btnExit.Location = new Point(787, 902);
        btnExit.Margin = new Padding(3, 4, 3, 4);
        btnExit.Name = "btnExit";
        btnExit.Padding = new Padding(0, 0, 0, 6);
        btnExit.Size = new Size(161, 54);
        btnExit.TabIndex = 4;
        btnExit.Text = "Exit";
        btnExit.TextAlign = ContentAlignment.BottomCenter;
        btnExit.UseVisualStyleBackColor = false;
        btnExit.Click += btnExit_Click;
        // 
        // lblSaved
        // 
        lblSaved.AutoSize = true;
        lblSaved.Font = new Font("Silkscreen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblSaved.ForeColor = Color.Lime;
        lblSaved.Location = new Point(230, 976);
        lblSaved.Margin = new Padding(2, 0, 2, 0);
        lblSaved.Name = "lblSaved";
        lblSaved.Size = new Size(126, 17);
        lblSaved.TabIndex = 22;
        lblSaved.Text = "Warning";
        // 
        // FrmDeparmentList
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(1186, 1002);
        Controls.Add(lblSaved);
        Controls.Add(btnExit);
        Controls.Add(btnDelete);
        Controls.Add(btnUpdate);
        Controls.Add(btnNew);
        Controls.Add(dataGridView1);
        ForeColor = Color.Lime;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(3, 4, 3, 4);
        MaximumSize = new Size(1204, 1049);
        MinimumSize = new Size(1204, 1049);
        Name = "FrmDeparmentList";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Department List";
        FormClosed += FrmDeparmentList_FormClosed;
        Load += FrmDeparmentList_Load;
        ((ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button btnExit;

    private System.Windows.Forms.Button btnUpdate;

    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.Button btnNew;

    private System.Windows.Forms.DataGridView dataGridView1;

    #endregion

    private Label lblSaved;
}