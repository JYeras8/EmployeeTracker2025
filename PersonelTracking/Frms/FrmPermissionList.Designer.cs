namespace PersonelTracking
{
    partial class FrmPermissionList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPermissionList));
            btnExit = new Button();
            btnApproved = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            panel1 = new Panel();
            btnDenied = new Button();
            lblSaved = new Label();
            dataGridView1 = new DataGridView();
            pnlForEmployee = new Panel();
            bntExport = new Button();
            cmbState = new ComboBox();
            pbProfilePic = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            dpStartDate = new DateTimePicker();
            label2 = new Label();
            groupBox3 = new GroupBox();
            rdbStartDate = new RadioButton();
            rdbDeliveryDate = new RadioButton();
            dpComplete = new DateTimePicker();
            txtDop = new TextBox();
            label3 = new Label();
            label1 = new Label();
            pnlForAdmin = new Panel();
            groupBox1 = new GroupBox();
            cmbDeparments = new ComboBox();
            cmbPosition = new ComboBox();
            txtName = new TextBox();
            useridTxt = new TextBox();
            txtLastName = new TextBox();
            MainPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlForEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfilePic).BeginInit();
            groupBox3.SuspendLayout();
            pnlForAdmin.SuspendLayout();
            groupBox1.SuspendLayout();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Black;
            btnExit.Font = new Font("Silkscreen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Lime;
            btnExit.Location = new Point(997, 48);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(0, 0, 0, 7);
            btnExit.Size = new Size(161, 72);
            btnExit.TabIndex = 5;
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
            btnApproved.Location = new Point(273, 18);
            btnApproved.Margin = new Padding(3, 4, 3, 4);
            btnApproved.Name = "btnApproved";
            btnApproved.Padding = new Padding(0, 0, 0, 7);
            btnApproved.Size = new Size(186, 72);
            btnApproved.TabIndex = 0;
            btnApproved.Text = "Approve";
            btnApproved.TextAlign = ContentAlignment.BottomCenter;
            btnApproved.UseVisualStyleBackColor = false;
            btnApproved.Click += Approved_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.Black;
            btnNew.Font = new Font("Silkscreen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.ForeColor = Color.Lime;
            btnNew.Location = new Point(493, 48);
            btnNew.Margin = new Padding(3, 4, 3, 4);
            btnNew.Name = "btnNew";
            btnNew.Padding = new Padding(0, 0, 0, 7);
            btnNew.Size = new Size(161, 72);
            btnNew.TabIndex = 2;
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
            btnDelete.Location = new Point(829, 48);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(0, 0, 0, 7);
            btnDelete.Size = new Size(161, 72);
            btnDelete.TabIndex = 4;
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
            btnUpdate.Location = new Point(661, 48);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Padding = new Padding(0, 0, 0, 7);
            btnUpdate.Size = new Size(161, 72);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.TextAlign = ContentAlignment.BottomCenter;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnDenied);
            panel1.Controls.Add(btnApproved);
            panel1.Controls.Add(lblSaved);
            panel1.Controls.Add(btnNew);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 648);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1418, 191);
            panel1.TabIndex = 10;
            // 
            // btnDenied
            // 
            btnDenied.BackColor = Color.Black;
            btnDenied.Font = new Font("Silkscreen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDenied.ForeColor = Color.Lime;
            btnDenied.Location = new Point(273, 98);
            btnDenied.Margin = new Padding(3, 4, 3, 4);
            btnDenied.Name = "btnDenied";
            btnDenied.Padding = new Padding(0, 0, 0, 7);
            btnDenied.Size = new Size(186, 72);
            btnDenied.TabIndex = 1;
            btnDenied.Text = "Denied";
            btnDenied.TextAlign = ContentAlignment.BottomCenter;
            btnDenied.UseVisualStyleBackColor = false;
            btnDenied.Click += btnDenied_Click;
            // 
            // lblSaved
            // 
            lblSaved.AutoSize = true;
            lblSaved.Font = new Font("Silkscreen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaved.ForeColor = Color.Lime;
            lblSaved.Location = new Point(493, 165);
            lblSaved.Margin = new Padding(2, 0, 2, 0);
            lblSaved.Name = "lblSaved";
            lblSaved.Size = new Size(126, 17);
            lblSaved.TabIndex = 18;
            lblSaved.Text = "Warning";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 249);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1418, 399);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.RowEnter += dataGridView1_RowEnter;
            dataGridView1.RowLeave += dataGridView1_RowLeave;
            // 
            // pnlForEmployee
            // 
            pnlForEmployee.Controls.Add(bntExport);
            pnlForEmployee.Controls.Add(cmbState);
            pnlForEmployee.Controls.Add(pbProfilePic);
            pnlForEmployee.Controls.Add(button3);
            pnlForEmployee.Controls.Add(button2);
            pnlForEmployee.Controls.Add(dpStartDate);
            pnlForEmployee.Controls.Add(label2);
            pnlForEmployee.Controls.Add(groupBox3);
            pnlForEmployee.Controls.Add(dpComplete);
            pnlForEmployee.Controls.Add(txtDop);
            pnlForEmployee.Controls.Add(label3);
            pnlForEmployee.Controls.Add(label1);
            pnlForEmployee.Dock = DockStyle.Right;
            pnlForEmployee.Location = new Point(438, 0);
            pnlForEmployee.Margin = new Padding(3, 4, 3, 4);
            pnlForEmployee.Name = "pnlForEmployee";
            pnlForEmployee.Size = new Size(980, 249);
            pnlForEmployee.TabIndex = 2;
            // 
            // bntExport
            // 
            bntExport.BackColor = Color.Black;
            bntExport.Font = new Font("Silkscreen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntExport.ForeColor = Color.Lime;
            bntExport.Location = new Point(386, 201);
            bntExport.Margin = new Padding(3, 4, 3, 4);
            bntExport.Name = "bntExport";
            bntExport.Padding = new Padding(0, 0, 0, 6);
            bntExport.Size = new Size(149, 40);
            bntExport.TabIndex = 19;
            bntExport.Text = "Export";
            bntExport.TextAlign = ContentAlignment.BottomCenter;
            bntExport.UseVisualStyleBackColor = false;
            bntExport.Click += bntExport_Click;
            // 
            // cmbState
            // 
            cmbState.BackColor = SystemColors.InactiveCaptionText;
            cmbState.Font = new Font("Silkscreen", 11.25F);
            cmbState.ForeColor = Color.Lime;
            cmbState.FormattingEnabled = true;
            cmbState.Location = new Point(13, 184);
            cmbState.Margin = new Padding(3, 4, 3, 4);
            cmbState.Name = "cmbState";
            cmbState.Size = new Size(172, 24);
            cmbState.TabIndex = 4;
            cmbState.Text = "State";
            cmbState.SelectedIndexChanged += cmbDeparments_SelectedIndexChanged;
            // 
            // pbProfilePic
            // 
            pbProfilePic.BackgroundImageLayout = ImageLayout.Stretch;
            pbProfilePic.Location = new Point(772, 26);
            pbProfilePic.Margin = new Padding(3, 4, 3, 4);
            pbProfilePic.Name = "pbProfilePic";
            pbProfilePic.Size = new Size(150, 150);
            pbProfilePic.TabIndex = 13;
            pbProfilePic.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Silkscreen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Lime;
            button3.Location = new Point(386, 155);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Padding = new Padding(0, 0, 0, 7);
            button3.Size = new Size(149, 37);
            button3.TabIndex = 3;
            button3.Text = "Clean";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnClear_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Silkscreen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Lime;
            button2.Location = new Point(386, 104);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Padding = new Padding(0, 0, 0, 7);
            button2.Size = new Size(149, 40);
            button2.TabIndex = 2;
            button2.Text = "Search";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnSearch_Click;
            // 
            // dpStartDate
            // 
            dpStartDate.CalendarForeColor = Color.Lime;
            dpStartDate.CalendarMonthBackground = SystemColors.WindowText;
            dpStartDate.Font = new Font("Silkscreen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dpStartDate.Format = DateTimePickerFormat.Short;
            dpStartDate.Location = new Point(118, 51);
            dpStartDate.Margin = new Padding(3, 4, 3, 4);
            dpStartDate.Name = "dpStartDate";
            dpStartDate.Size = new Size(135, 22);
            dpStartDate.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Silkscreen", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(15, 12);
            label2.Name = "label2";
            label2.Size = new Size(354, 27);
            label2.TabIndex = 9;
            label2.Text = "Permission Date";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rdbStartDate);
            groupBox3.Controls.Add(rdbDeliveryDate);
            groupBox3.Location = new Point(386, 4);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(166, 92);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            // 
            // rdbStartDate
            // 
            rdbStartDate.AutoSize = true;
            rdbStartDate.Font = new Font("Silkscreen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbStartDate.ForeColor = Color.Lime;
            rdbStartDate.Location = new Point(7, 25);
            rdbStartDate.Margin = new Padding(3, 4, 3, 4);
            rdbStartDate.Name = "rdbStartDate";
            rdbStartDate.Size = new Size(126, 17);
            rdbStartDate.TabIndex = 0;
            rdbStartDate.TabStop = true;
            rdbStartDate.Text = "Start Date";
            rdbStartDate.UseVisualStyleBackColor = true;
            // 
            // rdbDeliveryDate
            // 
            rdbDeliveryDate.AutoSize = true;
            rdbDeliveryDate.Font = new Font("Silkscreen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbDeliveryDate.ForeColor = Color.Lime;
            rdbDeliveryDate.Location = new Point(7, 55);
            rdbDeliveryDate.Margin = new Padding(3, 4, 3, 4);
            rdbDeliveryDate.Name = "rdbDeliveryDate";
            rdbDeliveryDate.Size = new Size(153, 17);
            rdbDeliveryDate.TabIndex = 1;
            rdbDeliveryDate.TabStop = true;
            rdbDeliveryDate.Text = "Delivery Date";
            rdbDeliveryDate.UseVisualStyleBackColor = true;
            // 
            // dpComplete
            // 
            dpComplete.CalendarForeColor = Color.Lime;
            dpComplete.CalendarMonthBackground = SystemColors.WindowText;
            dpComplete.Font = new Font("Silkscreen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dpComplete.Format = DateTimePickerFormat.Short;
            dpComplete.Location = new Point(118, 89);
            dpComplete.Margin = new Padding(3, 4, 3, 4);
            dpComplete.Name = "dpComplete";
            dpComplete.Size = new Size(135, 22);
            dpComplete.TabIndex = 1;
            // 
            // txtDop
            // 
            txtDop.BackColor = SystemColors.ActiveCaptionText;
            txtDop.Font = new Font("Silkscreen", 11.25F);
            txtDop.ForeColor = Color.LightGray;
            txtDop.Location = new Point(13, 136);
            txtDop.Margin = new Padding(3, 4, 3, 4);
            txtDop.Name = "txtDop";
            txtDop.Size = new Size(241, 26);
            txtDop.TabIndex = 4;
            txtDop.Text = "Days of Permission";
            txtDop.WordWrap = false;
            txtDop.KeyDown += txtDop_KeyDown;
            txtDop.KeyPress += txtDop_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Enabled = false;
            label3.Font = new Font("Silkscreen", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(13, 57);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 9;
            label3.Text = "Start";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Enabled = false;
            label1.Font = new Font("Silkscreen", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(13, 96);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 9;
            label1.Text = "Complete";
            // 
            // pnlForAdmin
            // 
            pnlForAdmin.Controls.Add(groupBox1);
            pnlForAdmin.Dock = DockStyle.Top;
            pnlForAdmin.Location = new Point(0, 0);
            pnlForAdmin.Name = "pnlForAdmin";
            pnlForAdmin.Size = new Size(438, 246);
            pnlForAdmin.TabIndex = 19;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Controls.Add(cmbDeparments);
            groupBox1.Controls.Add(cmbPosition);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(useridTxt);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Location = new Point(12, 11);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(325, 221);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // cmbDeparments
            // 
            cmbDeparments.BackColor = SystemColors.InactiveCaptionText;
            cmbDeparments.Font = new Font("Silkscreen", 11.25F);
            cmbDeparments.ForeColor = Color.Lime;
            cmbDeparments.FormattingEnabled = true;
            cmbDeparments.Location = new Point(22, 144);
            cmbDeparments.Margin = new Padding(3, 4, 3, 4);
            cmbDeparments.Name = "cmbDeparments";
            cmbDeparments.Size = new Size(282, 24);
            cmbDeparments.TabIndex = 4;
            cmbDeparments.Text = "Departrment";
            cmbDeparments.SelectedIndexChanged += cmbDeparments_SelectedIndexChanged;
            // 
            // cmbPosition
            // 
            cmbPosition.BackColor = SystemColors.InactiveCaptionText;
            cmbPosition.Font = new Font("Silkscreen", 11.25F);
            cmbPosition.ForeColor = Color.Lime;
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(22, 176);
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
            txtName.KeyPress += txtName_KeyPress;
            // 
            // useridTxt
            // 
            useridTxt.BackColor = SystemColors.ActiveCaptionText;
            useridTxt.Font = new Font("Silkscreen", 11.25F);
            useridTxt.ForeColor = Color.LightGray;
            useridTxt.Location = new Point(21, 29);
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
            txtLastName.Location = new Point(21, 107);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(281, 26);
            txtLastName.TabIndex = 2;
            txtLastName.Text = "Last Name";
            txtLastName.WordWrap = false;
            txtLastName.KeyPress += txtLastName_KeyPress;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(pnlForAdmin);
            MainPanel.Controls.Add(pnlForEmployee);
            MainPanel.Dock = DockStyle.Top;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Margin = new Padding(3, 4, 3, 4);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1418, 249);
            MainPanel.TabIndex = 11;
            // 
            // FrmPermissionList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1418, 839);
            Controls.Add(dataGridView1);
            Controls.Add(MainPanel);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPermissionList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Permissions List";
            Load += FrmPermissionList_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlForEmployee.ResumeLayout(false);
            pnlForEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfilePic).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            pnlForAdmin.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            MainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Button btnApproved;
        private Button btnNew;
        private Button btnDelete;
        private Button btnUpdate;
        private Panel panel1;
        private Button btnDenied;
        private DataGridView dataGridView1;
        private Panel pnlForEmployee;
        private ComboBox cmbState;
        private PictureBox pbProfilePic;
        private Label lblSaved;
        private Button button3;
        private Button button2;
        private DateTimePicker dpStartDate;
        private Label label2;
        private GroupBox groupBox3;
        private RadioButton rdbStartDate;
        private RadioButton rdbDeliveryDate;
        private DateTimePicker dpComplete;
        private TextBox txtDop;
        private Label label3;
        private Label label1;
        private Panel pnlForAdmin;
        private GroupBox groupBox1;
        private ComboBox cmbDeparments;
        private ComboBox cmbPosition;
        private TextBox txtName;
        private TextBox useridTxt;
        private TextBox txtLastName;
        private Panel MainPanel;
        private Button bntExport;
    }
}