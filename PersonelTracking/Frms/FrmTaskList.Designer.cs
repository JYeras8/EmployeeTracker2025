namespace PersonelTracking
{
    partial class FrmTaskList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTaskList));
            chkAdmin = new Panel();
            panel2 = new Panel();
            taskStateTxt = new TextBox();
            tasknameTxt = new TextBox();
            taskContentTxt = new RichTextBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            lblTitle = new Label();
            pnlforEmployee = new Panel();
            bntExport = new Button();
            lblSaved = new Label();
            btnClean = new Button();
            pnlForAdmin = new Panel();
            groupBox1 = new GroupBox();
            cmbDeparments = new ComboBox();
            cmbPosition = new ComboBox();
            txtName = new TextBox();
            useridTxt = new TextBox();
            txtLastName = new TextBox();
            cmbTaskState = new ComboBox();
            dpStartDate = new DateTimePicker();
            btnSearch = new Button();
            groupBox2 = new GroupBox();
            rdbStartDate = new RadioButton();
            rdbDeliveryDate = new RadioButton();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dpComplete = new DateTimePicker();
            panel1 = new Panel();
            btnExit = new Button();
            btnApproved = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dataGridView1 = new DataGridView();
            chkAdmin.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlforEmployee.SuspendLayout();
            pnlForAdmin.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // chkAdmin
            // 
            chkAdmin.Controls.Add(panel2);
            chkAdmin.Controls.Add(pnlforEmployee);
            chkAdmin.Dock = DockStyle.Top;
            chkAdmin.ForeColor = Color.Silver;
            chkAdmin.Location = new Point(0, 0);
            chkAdmin.Margin = new Padding(3, 4, 3, 4);
            chkAdmin.Name = "chkAdmin";
            chkAdmin.Size = new Size(1443, 260);
            chkAdmin.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(taskStateTxt);
            panel2.Controls.Add(tasknameTxt);
            panel2.Controls.Add(taskContentTxt);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lblTitle);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(394, 260);
            panel2.TabIndex = 11;
            // 
            // taskStateTxt
            // 
            taskStateTxt.BackColor = SystemColors.ActiveCaptionText;
            taskStateTxt.ForeColor = Color.Lime;
            taskStateTxt.Location = new Point(275, 91);
            taskStateTxt.Name = "taskStateTxt";
            taskStateTxt.Size = new Size(96, 27);
            taskStateTxt.TabIndex = 12;
            // 
            // tasknameTxt
            // 
            tasknameTxt.BackColor = SystemColors.ActiveCaptionText;
            tasknameTxt.ForeColor = Color.Lime;
            tasknameTxt.Location = new Point(19, 91);
            tasknameTxt.Name = "tasknameTxt";
            tasknameTxt.Size = new Size(234, 27);
            tasknameTxt.TabIndex = 12;
            // 
            // taskContentTxt
            // 
            taskContentTxt.BackColor = SystemColors.ActiveCaptionText;
            taskContentTxt.ForeColor = Color.Lime;
            taskContentTxt.Location = new Point(19, 147);
            taskContentTxt.Name = "taskContentTxt";
            taskContentTxt.Size = new Size(358, 94);
            taskContentTxt.TabIndex = 11;
            taskContentTxt.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Silkscreen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Lime;
            label5.Location = new Point(12, 127);
            label5.Name = "label5";
            label5.Size = new Size(106, 17);
            label5.TabIndex = 10;
            label5.Text = "Content";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Silkscreen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Lime;
            label6.Location = new Point(299, 66);
            label6.Name = "label6";
            label6.Size = new Size(72, 17);
            label6.TabIndex = 10;
            label6.Text = "State";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Silkscreen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Lime;
            label4.Location = new Point(19, 68);
            label4.Name = "label4";
            label4.Size = new Size(122, 17);
            label4.TabIndex = 10;
            label4.Text = "TaskName";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Lime;
            pictureBox2.Location = new Point(-455, 54);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(826, 8);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Silkscreen", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Lime;
            lblTitle.Location = new Point(3, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(234, 32);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "TaskList";
            // 
            // pnlforEmployee
            // 
            pnlforEmployee.Controls.Add(bntExport);
            pnlforEmployee.Controls.Add(lblSaved);
            pnlforEmployee.Controls.Add(btnClean);
            pnlforEmployee.Controls.Add(pnlForAdmin);
            pnlforEmployee.Controls.Add(cmbTaskState);
            pnlforEmployee.Controls.Add(dpStartDate);
            pnlforEmployee.Controls.Add(btnSearch);
            pnlforEmployee.Controls.Add(groupBox2);
            pnlforEmployee.Controls.Add(label3);
            pnlforEmployee.Controls.Add(label2);
            pnlforEmployee.Controls.Add(label1);
            pnlforEmployee.Controls.Add(dpComplete);
            pnlforEmployee.Location = new Point(0, 0);
            pnlforEmployee.Margin = new Padding(3, 4, 3, 4);
            pnlforEmployee.Name = "pnlforEmployee";
            pnlforEmployee.Size = new Size(1440, 260);
            pnlforEmployee.TabIndex = 12;
            // 
            // bntExport
            // 
            bntExport.BackColor = Color.Black;
            bntExport.Font = new Font("Silkscreen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntExport.ForeColor = Color.Lime;
            bntExport.Location = new Point(842, 206);
            bntExport.Margin = new Padding(3, 4, 3, 4);
            bntExport.Name = "bntExport";
            bntExport.Padding = new Padding(0, 0, 0, 6);
            bntExport.Size = new Size(149, 40);
            bntExport.TabIndex = 20;
            bntExport.Text = "Export";
            bntExport.TextAlign = ContentAlignment.BottomCenter;
            bntExport.UseVisualStyleBackColor = false;
            bntExport.Click += bntExport_Click;
            // 
            // lblSaved
            // 
            lblSaved.AutoSize = true;
            lblSaved.Font = new Font("Silkscreen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaved.ForeColor = Color.Lime;
            lblSaved.Location = new Point(458, 224);
            lblSaved.Margin = new Padding(2, 0, 2, 0);
            lblSaved.Name = "lblSaved";
            lblSaved.Size = new Size(126, 17);
            lblSaved.TabIndex = 19;
            lblSaved.Text = "Warning";
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.Black;
            btnClean.Font = new Font("Silkscreen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClean.ForeColor = Color.Lime;
            btnClean.Location = new Point(842, 157);
            btnClean.Margin = new Padding(3, 4, 3, 4);
            btnClean.Name = "btnClean";
            btnClean.Padding = new Padding(0, 0, 0, 6);
            btnClean.Size = new Size(149, 38);
            btnClean.TabIndex = 1;
            btnClean.Text = "Clean";
            btnClean.TextAlign = ContentAlignment.BottomCenter;
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btn_Clean_Vlick;
            // 
            // pnlForAdmin
            // 
            pnlForAdmin.Controls.Add(groupBox1);
            pnlForAdmin.Dock = DockStyle.Right;
            pnlForAdmin.Location = new Point(1068, 0);
            pnlForAdmin.Margin = new Padding(3, 4, 3, 4);
            pnlForAdmin.Name = "pnlForAdmin";
            pnlForAdmin.Size = new Size(372, 260);
            pnlForAdmin.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Controls.Add(cmbDeparments);
            groupBox1.Controls.Add(cmbPosition);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(useridTxt);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Location = new Point(27, 4);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(325, 240);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // cmbDeparments
            // 
            cmbDeparments.BackColor = SystemColors.InactiveCaptionText;
            cmbDeparments.Font = new Font("Silkscreen", 11.25F);
            cmbDeparments.ForeColor = Color.Lime;
            cmbDeparments.FormattingEnabled = true;
            cmbDeparments.Location = new Point(19, 180);
            cmbDeparments.Margin = new Padding(3, 4, 3, 4);
            cmbDeparments.Name = "cmbDeparments";
            cmbDeparments.Size = new Size(282, 24);
            cmbDeparments.TabIndex = 3;
            cmbDeparments.Text = "Departrment";
            // 
            // cmbPosition
            // 
            cmbPosition.BackColor = SystemColors.InactiveCaptionText;
            cmbPosition.Font = new Font("Silkscreen", 11.25F);
            cmbPosition.ForeColor = Color.Lime;
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(19, 146);
            cmbPosition.Margin = new Padding(3, 4, 3, 4);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(282, 24);
            cmbPosition.TabIndex = 1;
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
            txtName.TabIndex = 2;
            txtName.Text = "First Name";
            txtName.WordWrap = false;
            txtName.KeyPress += txtName_KeyPress;
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
            txtLastName.TabIndex = 4;
            txtLastName.Text = "Last Name";
            txtLastName.WordWrap = false;
            txtLastName.KeyPress += txtLastName_KeyPress;
            // 
            // cmbTaskState
            // 
            cmbTaskState.BackColor = SystemColors.InactiveCaptionText;
            cmbTaskState.Font = new Font("Silkscreen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTaskState.ForeColor = Color.Lime;
            cmbTaskState.FormattingEnabled = true;
            cmbTaskState.Location = new Point(458, 177);
            cmbTaskState.Margin = new Padding(3, 4, 3, 4);
            cmbTaskState.Name = "cmbTaskState";
            cmbTaskState.Size = new Size(238, 25);
            cmbTaskState.TabIndex = 2;
            cmbTaskState.Text = "Task State";
            // 
            // dpStartDate
            // 
            dpStartDate.CalendarForeColor = Color.Lime;
            dpStartDate.CalendarMonthBackground = SystemColors.WindowText;
            dpStartDate.Font = new Font("Silkscreen", 12F);
            dpStartDate.Format = DateTimePickerFormat.Short;
            dpStartDate.Location = new Point(581, 78);
            dpStartDate.Margin = new Padding(3, 4, 3, 4);
            dpStartDate.Name = "dpStartDate";
            dpStartDate.Size = new Size(156, 27);
            dpStartDate.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Black;
            btnSearch.Font = new Font("Silkscreen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Lime;
            btnSearch.Location = new Point(844, 109);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Padding = new Padding(0, 0, 0, 6);
            btnSearch.Size = new Size(149, 40);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.TextAlign = ContentAlignment.BottomCenter;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btn_Search_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdbStartDate);
            groupBox2.Controls.Add(rdbDeliveryDate);
            groupBox2.Font = new Font("Silkscreen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(844, 11);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(206, 92);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // rdbStartDate
            // 
            rdbStartDate.AutoSize = true;
            rdbStartDate.Font = new Font("Silkscreen", 12F);
            rdbStartDate.Location = new Point(7, 25);
            rdbStartDate.Margin = new Padding(3, 4, 3, 4);
            rdbStartDate.Name = "rdbStartDate";
            rdbStartDate.Size = new Size(157, 21);
            rdbStartDate.TabIndex = 0;
            rdbStartDate.TabStop = true;
            rdbStartDate.Text = "Start Date";
            rdbStartDate.UseVisualStyleBackColor = true;
            // 
            // rdbDeliveryDate
            // 
            rdbDeliveryDate.AutoSize = true;
            rdbDeliveryDate.Font = new Font("Silkscreen", 12F);
            rdbDeliveryDate.Location = new Point(7, 54);
            rdbDeliveryDate.Margin = new Padding(3, 4, 3, 4);
            rdbDeliveryDate.Name = "rdbDeliveryDate";
            rdbDeliveryDate.Size = new Size(196, 21);
            rdbDeliveryDate.TabIndex = 1;
            rdbDeliveryDate.TabStop = true;
            rdbDeliveryDate.Text = "Delivery Date";
            rdbDeliveryDate.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Enabled = false;
            label3.Font = new Font("Silkscreen", 12F);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(455, 86);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 9;
            label3.Text = "Start";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Silkscreen", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(458, 30);
            label2.Name = "label2";
            label2.Size = new Size(218, 27);
            label2.TabIndex = 9;
            label2.Text = "Task Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Enabled = false;
            label1.Font = new Font("Silkscreen", 12F);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(455, 125);
            label1.Name = "label1";
            label1.Size = new Size(115, 17);
            label1.TabIndex = 9;
            label1.Text = "Complete";
            // 
            // dpComplete
            // 
            dpComplete.CalendarForeColor = Color.Lime;
            dpComplete.CalendarMonthBackground = SystemColors.WindowText;
            dpComplete.Font = new Font("Silkscreen", 12F);
            dpComplete.Format = DateTimePickerFormat.Short;
            dpComplete.Location = new Point(581, 117);
            dpComplete.Margin = new Padding(3, 4, 3, 4);
            dpComplete.Name = "dpComplete";
            dpComplete.Size = new Size(156, 27);
            dpComplete.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnApproved);
            panel1.Controls.Add(btnNew);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 770);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1443, 110);
            panel1.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Black;
            btnExit.Font = new Font("Silkscreen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Lime;
            btnExit.Location = new Point(1010, 18);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(0, 0, 0, 6);
            btnExit.Size = new Size(161, 72);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.TextAlign = ContentAlignment.BottomCenter;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnApproved
            // 
            btnApproved.BackColor = Color.Black;
            btnApproved.Font = new Font("Silkscreen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApproved.ForeColor = Color.Lime;
            btnApproved.Location = new Point(338, 18);
            btnApproved.Margin = new Padding(3, 4, 3, 4);
            btnApproved.Name = "btnApproved";
            btnApproved.Padding = new Padding(0, 0, 0, 6);
            btnApproved.Size = new Size(161, 72);
            btnApproved.TabIndex = 0;
            btnApproved.Text = "Approve";
            btnApproved.TextAlign = ContentAlignment.BottomCenter;
            btnApproved.UseVisualStyleBackColor = false;
            btnApproved.Click += btnApproved_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.Black;
            btnNew.Font = new Font("Silkscreen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.ForeColor = Color.Lime;
            btnNew.Location = new Point(506, 18);
            btnNew.Margin = new Padding(3, 4, 3, 4);
            btnNew.Name = "btnNew";
            btnNew.Padding = new Padding(0, 0, 0, 6);
            btnNew.Size = new Size(161, 72);
            btnNew.TabIndex = 1;
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
            btnDelete.Location = new Point(842, 18);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(0, 0, 0, 6);
            btnDelete.Size = new Size(161, 72);
            btnDelete.TabIndex = 3;
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
            btnUpdate.Location = new Point(674, 18);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Padding = new Padding(0, 0, 0, 6);
            btnUpdate.Size = new Size(161, 72);
            btnUpdate.TabIndex = 2;
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
            dataGridView1.Location = new Point(0, 260);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1443, 510);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.RowEnter += dataGridView1_RowEnter;
            // 
            // FrmTaskList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1443, 880);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(chkAdmin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmTaskList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task List";
            Load += FrmTaskList_Load;
            chkAdmin.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlforEmployee.ResumeLayout(false);
            pnlforEmployee.PerformLayout();
            pnlForAdmin.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel chkAdmin;
        private Label lblTitle;
        private PictureBox pictureBox2;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Panel pnlForAdmin;
        private Button btnExit;
        private Button btnApproved;
        private Button btnNew;
        private Button btnDelete;
        private Button btnUpdate;
        private GroupBox groupBox1;
        private ComboBox cmbDeparments;
        private ComboBox cmbPosition;
        private TextBox txtName;
        private TextBox useridTxt;
        private TextBox txtLastName;
        private Panel pnlforEmployee;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DateTimePicker dpComplete;
        private DateTimePicker dpStartDate;
        private RadioButton rdbStartDate;
        private RadioButton rdbDeliveryDate;
        private ComboBox cmbTaskState;
        private Button btnClean;
        private Button btnSearch;
        private Label label5;
        private Label label4;
        private TextBox tasknameTxt;
        private RichTextBox taskContentTxt;
        private TextBox taskStateTxt;
        private Label label6;
        private Label lblSaved;
        private Button bntExport;
    }
}