namespace PersonelTracking
{
    partial class FrmEmployeeList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployeeList));
            panel1 = new Panel();
            lblSaved = new Label();
            pbProfilePic = new PictureBox();
            lblTitle = new Label();
            groupBox1 = new GroupBox();
            cmbDeparments = new ComboBox();
            cmbPosition = new ComboBox();
            btnClean = new Button();
            btnSearch = new Button();
            txtName = new TextBox();
            useridTxt = new TextBox();
            txtLastName = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnExit = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            bntExport = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfilePic).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(lblSaved);
            panel1.Controls.Add(pbProfilePic);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1704, 182);
            panel1.TabIndex = 0;
            // 
            // lblSaved
            // 
            lblSaved.AutoSize = true;
            lblSaved.Font = new Font("Silkscreen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaved.ForeColor = Color.Lime;
            lblSaved.Location = new Point(28, 119);
            lblSaved.Margin = new Padding(2, 0, 2, 0);
            lblSaved.Name = "lblSaved";
            lblSaved.Size = new Size(126, 17);
            lblSaved.TabIndex = 21;
            lblSaved.Text = "Warning";
            // 
            // pbProfilePic
            // 
            pbProfilePic.BackgroundImageLayout = ImageLayout.Stretch;
            pbProfilePic.Location = new Point(1509, 14);
            pbProfilePic.Margin = new Padding(3, 4, 3, 4);
            pbProfilePic.Name = "pbProfilePic";
            pbProfilePic.Size = new Size(156, 156);
            pbProfilePic.TabIndex = 8;
            pbProfilePic.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Enabled = false;
            lblTitle.Font = new Font("Silkscreen", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Lime;
            lblTitle.Location = new Point(14, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(373, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Employee List";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Controls.Add(bntExport);
            groupBox1.Controls.Add(cmbDeparments);
            groupBox1.Controls.Add(cmbPosition);
            groupBox1.Controls.Add(btnClean);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(useridTxt);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Location = new Point(818, 11);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(639, 146);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // cmbDeparments
            // 
            cmbDeparments.BackColor = SystemColors.InactiveCaptionText;
            cmbDeparments.Font = new Font("Silkscreen", 12F, FontStyle.Bold);
            cmbDeparments.ForeColor = Color.Lime;
            cmbDeparments.FormattingEnabled = true;
            cmbDeparments.Location = new Point(282, 20);
            cmbDeparments.Margin = new Padding(3, 4, 3, 4);
            cmbDeparments.Name = "cmbDeparments";
            cmbDeparments.Size = new Size(322, 25);
            cmbDeparments.TabIndex = 3;
            cmbDeparments.Text = "Departrment";
            cmbDeparments.SelectedIndexChanged += cmbDeparments_SelectedIndexChanged;
            // 
            // cmbPosition
            // 
            cmbPosition.BackColor = SystemColors.InactiveCaptionText;
            cmbPosition.Font = new Font("Silkscreen", 12F, FontStyle.Bold);
            cmbPosition.ForeColor = Color.Lime;
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(282, 51);
            cmbPosition.Margin = new Padding(3, 4, 3, 4);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(322, 25);
            cmbPosition.TabIndex = 1;
            cmbPosition.Text = "Positions";
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.Black;
            btnClean.Font = new Font("Silkscreen", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClean.ForeColor = Color.Lime;
            btnClean.Location = new Point(396, 98);
            btnClean.Margin = new Padding(3, 4, 3, 4);
            btnClean.Name = "btnClean";
            btnClean.Padding = new Padding(0, 0, 0, 6);
            btnClean.Size = new Size(105, 40);
            btnClean.TabIndex = 5;
            btnClean.Text = "Clear";
            btnClean.TextAlign = ContentAlignment.BottomCenter;
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Black;
            btnSearch.Font = new Font("Silkscreen", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Lime;
            btnSearch.Location = new Point(283, 98);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Padding = new Padding(0, 0, 0, 6);
            btnSearch.Size = new Size(107, 42);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.TextAlign = ContentAlignment.BottomCenter;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ActiveCaptionText;
            txtName.Font = new Font("Silkscreen", 12F);
            txtName.ForeColor = Color.LightGray;
            txtName.Location = new Point(9, 58);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(194, 27);
            txtName.TabIndex = 2;
            txtName.Text = "First Name";
            txtName.WordWrap = false;
            txtName.KeyPress += txtName_KeyPress;
            // 
            // useridTxt
            // 
            useridTxt.BackColor = SystemColors.ActiveCaptionText;
            useridTxt.Font = new Font("Silkscreen", 12F);
            useridTxt.ForeColor = Color.LightGray;
            useridTxt.Location = new Point(8, 20);
            useridTxt.Margin = new Padding(3, 4, 3, 4);
            useridTxt.Name = "useridTxt";
            useridTxt.Size = new Size(97, 27);
            useridTxt.TabIndex = 0;
            useridTxt.Text = "User ID";
            useridTxt.WordWrap = false;
            useridTxt.KeyDown += useridTxt_KeyDown;
            useridTxt.KeyPress += useridTxt_KeyPress;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = SystemColors.ActiveCaptionText;
            txtLastName.Font = new Font("Silkscreen", 12F);
            txtLastName.ForeColor = Color.LightGray;
            txtLastName.Location = new Point(8, 98);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(264, 27);
            txtLastName.TabIndex = 4;
            txtLastName.Text = "Last Name";
            txtLastName.WordWrap = false;
            txtLastName.KeyPress += txtLastName_KeyPress;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Lime;
            pictureBox2.Location = new Point(-38, 74);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(558, 8);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Lime;
            pictureBox1.Location = new Point(-21, 93);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(626, 8);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 182);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1704, 853);
            dataGridView1.TabIndex = 1;
            dataGridView1.RowEnter += datagridView1_RowEnter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnNew);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 941);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1704, 94);
            panel2.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Black;
            btnExit.Font = new Font("Silkscreen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Lime;
            btnExit.Location = new Point(1047, 19);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(0, 0, 0, 6);
            btnExit.Size = new Size(161, 54);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.TextAlign = ContentAlignment.BottomCenter;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Black;
            btnDelete.Font = new Font("Silkscreen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Lime;
            btnDelete.Location = new Point(862, 19);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(0, 0, 0, 6);
            btnDelete.Size = new Size(161, 54);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.BottomCenter;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Black;
            btnUpdate.Font = new Font("Silkscreen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Lime;
            btnUpdate.Location = new Point(678, 19);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Padding = new Padding(0, 0, 0, 6);
            btnUpdate.Size = new Size(161, 54);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.TextAlign = ContentAlignment.BottomCenter;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.Black;
            btnNew.Font = new Font("Silkscreen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.ForeColor = Color.Lime;
            btnNew.Location = new Point(490, 19);
            btnNew.Margin = new Padding(3, 4, 3, 4);
            btnNew.Name = "btnNew";
            btnNew.Padding = new Padding(0, 0, 0, 6);
            btnNew.Size = new Size(161, 54);
            btnNew.TabIndex = 0;
            btnNew.Text = "New";
            btnNew.TextAlign = ContentAlignment.BottomCenter;
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // bntExport
            // 
            bntExport.BackColor = Color.Black;
            bntExport.Font = new Font("Silkscreen", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntExport.ForeColor = Color.Lime;
            bntExport.Location = new Point(507, 98);
            bntExport.Margin = new Padding(3, 4, 3, 4);
            bntExport.Name = "bntExport";
            bntExport.Padding = new Padding(0, 0, 0, 6);
            bntExport.Size = new Size(105, 40);
            bntExport.TabIndex = 4;
            bntExport.Text = "Export";
            bntExport.TextAlign = ContentAlignment.BottomCenter;
            bntExport.UseVisualStyleBackColor = false;
            bntExport.Click += bntExport_Click;
            // 
            // FrmEmployeeList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1704, 1035);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmEmployeeList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEmployeeList";
            Load += FrmEmployeeList_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfilePic).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button btnExit;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnNew;
        private TextBox useridTxt;
        private TextBox txtLastName;
        private TextBox txtName;
        private Label lblTitle;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ComboBox cmbPosition;
        private ComboBox cmbDeparments;
        private Button btnSearch;
        private Button btnClean;
        private PictureBox pbProfilePic;
        private Label lblSaved;
        private Button bntExport;
    }
}