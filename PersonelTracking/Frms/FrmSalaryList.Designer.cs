namespace PersonelTracking
{
    partial class FrmSalaryList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalaryList));
            panel2 = new Panel();
            btnExit = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            panel3 = new Panel();
            lblSaved = new Label();
            pbProfilePic = new PictureBox();
            button3 = new Button();
            bntExport = new Button();
            button2 = new Button();
            groupBox3 = new GroupBox();
            rbMore = new RadioButton();
            rbEqual = new RadioButton();
            rbLessThan = new RadioButton();
            cmbMonth = new ComboBox();
            txtYear = new TextBox();
            txtSalary = new TextBox();
            pnlForAdmin = new Panel();
            groupBox1 = new GroupBox();
            cmbDeparments = new ComboBox();
            cmbPosition = new ComboBox();
            txtName = new TextBox();
            useridTxt = new TextBox();
            txtLastName = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfilePic).BeginInit();
            groupBox3.SuspendLayout();
            pnlForAdmin.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 778);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1358, 102);
            panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Black;
            btnExit.Font = new Font("Silkscreen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Lime;
            btnExit.Location = new Point(895, 19);
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
            // btnNew
            // 
            btnNew.BackColor = Color.Black;
            btnNew.Font = new Font("Silkscreen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.ForeColor = Color.Lime;
            btnNew.Location = new Point(338, 19);
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
            // btnDelete
            // 
            btnDelete.BackColor = Color.Black;
            btnDelete.Font = new Font("Silkscreen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Lime;
            btnDelete.Location = new Point(711, 19);
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
            btnUpdate.Location = new Point(527, 19);
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
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(15, 15, 15);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 278);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1358, 500);
            dataGridView1.TabIndex = 2;
            dataGridView1.RowEnter += dataGridView1_RowEnter;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pnlForAdmin);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1358, 278);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblSaved);
            panel3.Controls.Add(pbProfilePic);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(bntExport);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(groupBox3);
            panel3.Controls.Add(cmbMonth);
            panel3.Controls.Add(txtYear);
            panel3.Controls.Add(txtSalary);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(474, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(884, 278);
            panel3.TabIndex = 13;
            // 
            // lblSaved
            // 
            lblSaved.AutoSize = true;
            lblSaved.Font = new Font("Silkscreen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaved.ForeColor = Color.Lime;
            lblSaved.Location = new Point(30, 233);
            lblSaved.Margin = new Padding(2, 0, 2, 0);
            lblSaved.Name = "lblSaved";
            lblSaved.Size = new Size(126, 17);
            lblSaved.TabIndex = 20;
            lblSaved.Text = "Warning";
            // 
            // pbProfilePic
            // 
            pbProfilePic.BackgroundImageLayout = ImageLayout.Stretch;
            pbProfilePic.Location = new Point(679, 44);
            pbProfilePic.Margin = new Padding(3, 4, 3, 4);
            pbProfilePic.Name = "pbProfilePic";
            pbProfilePic.Size = new Size(156, 156);
            pbProfilePic.TabIndex = 9;
            pbProfilePic.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Silkscreen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Lime;
            button3.Location = new Point(376, 89);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Padding = new Padding(0, 0, 0, 6);
            button3.Size = new Size(149, 40);
            button3.TabIndex = 4;
            button3.Text = "Clean";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnClean_Click;
            // 
            // bntExport
            // 
            bntExport.BackColor = Color.Black;
            bntExport.Font = new Font("Silkscreen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntExport.ForeColor = Color.Lime;
            bntExport.Location = new Point(376, 140);
            bntExport.Margin = new Padding(3, 4, 3, 4);
            bntExport.Name = "bntExport";
            bntExport.Padding = new Padding(0, 0, 0, 6);
            bntExport.Size = new Size(149, 40);
            bntExport.TabIndex = 3;
            bntExport.Text = "Export";
            bntExport.TextAlign = ContentAlignment.BottomCenter;
            bntExport.UseVisualStyleBackColor = false;
            bntExport.Click += bntExport_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Silkscreen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Lime;
            button2.Location = new Point(376, 36);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Padding = new Padding(0, 0, 0, 6);
            button2.Size = new Size(149, 40);
            button2.TabIndex = 3;
            button2.Text = "Search";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnSearch_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbMore);
            groupBox3.Controls.Add(rbEqual);
            groupBox3.Controls.Add(rbLessThan);
            groupBox3.Location = new Point(223, 30);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(138, 122);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            // 
            // rbMore
            // 
            rbMore.AutoSize = true;
            rbMore.Font = new Font("Silkscreen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbMore.ForeColor = Color.Lime;
            rbMore.Location = new Point(7, 26);
            rbMore.Margin = new Padding(3, 4, 3, 4);
            rbMore.Name = "rbMore";
            rbMore.Size = new Size(71, 17);
            rbMore.TabIndex = 0;
            rbMore.TabStop = true;
            rbMore.Text = "More";
            rbMore.UseVisualStyleBackColor = true;
            // 
            // rbEqual
            // 
            rbEqual.AutoSize = true;
            rbEqual.Font = new Font("Silkscreen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbEqual.ForeColor = Color.Lime;
            rbEqual.Location = new Point(7, 82);
            rbEqual.Margin = new Padding(3, 4, 3, 4);
            rbEqual.Name = "rbEqual";
            rbEqual.Size = new Size(79, 17);
            rbEqual.TabIndex = 2;
            rbEqual.TabStop = true;
            rbEqual.Text = "Equal";
            rbEqual.UseVisualStyleBackColor = true;
            // 
            // rbLessThan
            // 
            rbLessThan.AutoSize = true;
            rbLessThan.Font = new Font("Silkscreen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbLessThan.ForeColor = Color.Lime;
            rbLessThan.Location = new Point(7, 54);
            rbLessThan.Margin = new Padding(3, 4, 3, 4);
            rbLessThan.Name = "rbLessThan";
            rbLessThan.Size = new Size(118, 17);
            rbLessThan.TabIndex = 1;
            rbLessThan.TabStop = true;
            rbLessThan.Text = "Less Than";
            rbLessThan.UseVisualStyleBackColor = true;
            // 
            // cmbMonth
            // 
            cmbMonth.BackColor = SystemColors.InactiveCaptionText;
            cmbMonth.Font = new Font("Silkscreen", 11.25F);
            cmbMonth.ForeColor = Color.Lime;
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(30, 122);
            cmbMonth.Margin = new Padding(3, 4, 3, 4);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(167, 24);
            cmbMonth.TabIndex = 2;
            cmbMonth.Text = "Month";
            // 
            // txtYear
            // 
            txtYear.BackColor = SystemColors.ActiveCaptionText;
            txtYear.Font = new Font("Silkscreen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtYear.ForeColor = Color.LightGray;
            txtYear.Location = new Point(29, 82);
            txtYear.Margin = new Padding(3, 4, 3, 4);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(169, 27);
            txtYear.TabIndex = 1;
            txtYear.Text = "Year";
            txtYear.WordWrap = false;
            txtYear.KeyDown += txtYear_KeyDown;
            // 
            // txtSalary
            // 
            txtSalary.BackColor = SystemColors.ActiveCaptionText;
            txtSalary.Font = new Font("Silkscreen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSalary.ForeColor = Color.LightGray;
            txtSalary.Location = new Point(30, 44);
            txtSalary.Margin = new Padding(3, 4, 3, 4);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(169, 27);
            txtSalary.TabIndex = 0;
            txtSalary.Text = "Salary";
            txtSalary.WordWrap = false;
            txtSalary.KeyDown += txtSalary_KeyDown;
            // 
            // pnlForAdmin
            // 
            pnlForAdmin.Controls.Add(groupBox1);
            pnlForAdmin.Dock = DockStyle.Left;
            pnlForAdmin.Location = new Point(0, 0);
            pnlForAdmin.Margin = new Padding(3, 4, 3, 4);
            pnlForAdmin.Name = "pnlForAdmin";
            pnlForAdmin.Size = new Size(474, 278);
            pnlForAdmin.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Controls.Add(cmbDeparments);
            groupBox1.Controls.Add(cmbPosition);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(useridTxt);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Location = new Point(30, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(368, 234);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // cmbDeparments
            // 
            cmbDeparments.BackColor = SystemColors.InactiveCaptionText;
            cmbDeparments.Font = new Font("Silkscreen", 11.25F);
            cmbDeparments.ForeColor = Color.Lime;
            cmbDeparments.FormattingEnabled = true;
            cmbDeparments.Location = new Point(22, 140);
            cmbDeparments.Margin = new Padding(3, 4, 3, 4);
            cmbDeparments.Name = "cmbDeparments";
            cmbDeparments.Size = new Size(282, 24);
            cmbDeparments.TabIndex = 4;
            cmbDeparments.Text = "Departrment";
            // 
            // cmbPosition
            // 
            cmbPosition.BackColor = SystemColors.InactiveCaptionText;
            cmbPosition.Font = new Font("Silkscreen", 11.25F);
            cmbPosition.ForeColor = Color.Lime;
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(22, 172);
            cmbPosition.Margin = new Padding(3, 4, 3, 4);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(282, 24);
            cmbPosition.TabIndex = 3;
            cmbPosition.Text = "Positions";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ActiveCaptionText;
            txtName.Font = new Font("Silkscreen", 11.25F);
            txtName.ForeColor = Color.LightGray;
            txtName.Location = new Point(22, 68);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(279, 26);
            txtName.TabIndex = 1;
            txtName.Text = "First Name";
            txtName.WordWrap = false;
            txtName.KeyDown += txtName_KeyDown;
            // 
            // useridTxt
            // 
            useridTxt.BackColor = SystemColors.ActiveCaptionText;
            useridTxt.Font = new Font("Silkscreen", 11.25F);
            useridTxt.ForeColor = Color.LightGray;
            useridTxt.Location = new Point(21, 30);
            useridTxt.Margin = new Padding(3, 4, 3, 4);
            useridTxt.Name = "useridTxt";
            useridTxt.Size = new Size(207, 26);
            useridTxt.TabIndex = 0;
            useridTxt.Text = "User ID";
            useridTxt.WordWrap = false;
            useridTxt.KeyDown += useridTxt_KeyDown;
            useridTxt.KeyPress += useridTxt_KeyPress;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = SystemColors.ActiveCaptionText;
            txtLastName.Font = new Font("Silkscreen", 11.25F);
            txtLastName.ForeColor = Color.LightGray;
            txtLastName.Location = new Point(21, 106);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(281, 26);
            txtLastName.TabIndex = 2;
            txtLastName.Text = "Last Name";
            txtLastName.WordWrap = false;
            txtLastName.KeyDown += txtLastName_KeyDown;
            // 
            // FrmSalaryList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1358, 880);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmSalaryList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salary List";
            Load += FrmSalaryList_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfilePic).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            pnlForAdmin.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button btnExit;
        private Button btnNew;
        private Button btnDelete;
        private Button btnUpdate;
        private Panel panel1;
        private Panel pnlForAdmin;
        private GroupBox groupBox1;
        private ComboBox cmbDeparments;
        private ComboBox cmbPosition;
        private TextBox txtName;
        private TextBox useridTxt;
        private TextBox txtLastName;
        private Panel panel3;
        private ComboBox cmbMonth;
        private TextBox txtYear;
        private TextBox txtSalary;
        private GroupBox groupBox3;
        private RadioButton rbMore;
        private RadioButton rbEqual;
        private RadioButton rbLessThan;
        private Button button3;
        private Button button2;
        private PictureBox pbProfilePic;
        private Label lblSaved;
        private Button bntExport;
    }
}