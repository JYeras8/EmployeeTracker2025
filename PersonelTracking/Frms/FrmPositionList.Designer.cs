using System.ComponentModel;

namespace PersonelTracking;

partial class FrmPositionList
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
        dataGridView1 = new DataGridView();
        btnNew = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        btnExit = new Button();
        panel1 = new Panel();
        lblSaved = new Label();
        ((ISupportInitialize)dataGridView1).BeginInit();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.BackgroundColor = Color.FromArgb(25, 25, 25);
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Dock = DockStyle.Top;
        dataGridView1.Location = new Point(0, 0);
        dataGridView1.Margin = new Padding(3, 4, 3, 4);
        dataGridView1.MultiSelect = false;
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 62;
        dataGridView1.Size = new Size(1022, 474);
        dataGridView1.TabIndex = 0;
        dataGridView1.Text = "dataGridView1";
        dataGridView1.RowEnter += dataGridView1_RowEnter;
        // 
        // btnNew
        // 
        btnNew.Font = new Font("Silkscreen", 15.75F, FontStyle.Bold);
        btnNew.ForeColor = Color.Lime;
        btnNew.Location = new Point(173, 19);
        btnNew.Margin = new Padding(3, 4, 3, 4);
        btnNew.Name = "btnNew";
        btnNew.Padding = new Padding(0, 0, 0, 6);
        btnNew.Size = new Size(178, 62);
        btnNew.TabIndex = 1;
        btnNew.Text = "New";
        btnNew.TextAlign = ContentAlignment.BottomCenter;
        btnNew.Click += btnNew_Click;
        // 
        // btnUpdate
        // 
        btnUpdate.Font = new Font("Silkscreen", 15.75F, FontStyle.Bold);
        btnUpdate.ForeColor = Color.Lime;
        btnUpdate.Location = new Point(357, 19);
        btnUpdate.Margin = new Padding(3, 4, 3, 4);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Padding = new Padding(0, 0, 0, 6);
        btnUpdate.Size = new Size(178, 62);
        btnUpdate.TabIndex = 3;
        btnUpdate.Text = "Update";
        btnUpdate.TextAlign = ContentAlignment.BottomCenter;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnDelete
        // 
        btnDelete.Font = new Font("Silkscreen", 15.75F, FontStyle.Bold);
        btnDelete.ForeColor = Color.Lime;
        btnDelete.Location = new Point(541, 19);
        btnDelete.Margin = new Padding(3, 4, 3, 4);
        btnDelete.Name = "btnDelete";
        btnDelete.Padding = new Padding(0, 0, 0, 6);
        btnDelete.Size = new Size(178, 62);
        btnDelete.TabIndex = 2;
        btnDelete.Text = "Delete";
        btnDelete.TextAlign = ContentAlignment.BottomCenter;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnExit
        // 
        btnExit.Font = new Font("Silkscreen", 15.75F, FontStyle.Bold);
        btnExit.ForeColor = Color.Lime;
        btnExit.Location = new Point(725, 19);
        btnExit.Margin = new Padding(3, 4, 3, 4);
        btnExit.Name = "btnExit";
        btnExit.Padding = new Padding(0, 0, 0, 6);
        btnExit.Size = new Size(178, 62);
        btnExit.TabIndex = 4;
        btnExit.Text = "Exit";
        btnExit.TextAlign = ContentAlignment.BottomCenter;
        btnExit.Click += btnExit_Click;
        // 
        // panel1
        // 
        panel1.BackColor = SystemColors.ActiveCaptionText;
        panel1.Controls.Add(lblSaved);
        panel1.Controls.Add(btnExit);
        panel1.Controls.Add(btnDelete);
        panel1.Controls.Add(btnUpdate);
        panel1.Controls.Add(btnNew);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 471);
        panel1.Margin = new Padding(3, 4, 3, 4);
        panel1.Name = "panel1";
        panel1.Size = new Size(1022, 131);
        panel1.TabIndex = 1;
        panel1.Paint += panel1_Paint;
        // 
        // lblSaved
        // 
        lblSaved.AutoSize = true;
        lblSaved.Font = new Font("Silkscreen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblSaved.ForeColor = Color.Lime;
        lblSaved.Location = new Point(173, 102);
        lblSaved.Name = "lblSaved";
        lblSaved.Size = new Size(126, 17);
        lblSaved.TabIndex = 5;
        lblSaved.Text = "Warning";
        // 
        // FrmPositionList
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1022, 602);
        Controls.Add(panel1);
        Controls.Add(dataGridView1);
        Margin = new Padding(3, 4, 3, 4);
        Name = "FrmPositionList";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "FrmPositionList";
        Load += FrmPositionList_Load;
        ((ISupportInitialize)dataGridView1).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnNew;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnExit;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.DataGridView dataGridView1;

    #endregion

    private Label lblSaved;
}