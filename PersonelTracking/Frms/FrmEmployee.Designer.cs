namespace PersonelTracking
{
    partial class FrmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployee));
            chkAdmin = new Panel();
            lblTitle = new Label();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox2 = new GroupBox();
            chAdmin = new CheckBox();
            passwordTxt = new TextBox();
            btnCheck = new Button();
            useridTxt = new TextBox();
            pictureBox1 = new PictureBox();
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtImagePath = new TextBox();
            groupBox1 = new GroupBox();
            lblSaved = new Label();
            ExitButton = new Button();
            btnSave = new Button();
            pictureBox3 = new PictureBox();
            txtAddress = new TextBox();
            txtDob = new TextBox();
            cmbDeparments = new ComboBox();
            cmbPosition = new ComboBox();
            txtSalary = new TextBox();
            btn_Browse = new Button();
            pbProfilePic = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            chkAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProfilePic).BeginInit();
            SuspendLayout();
            // 
            // chkAdmin
            // 
            chkAdmin.Controls.Add(lblTitle);
            chkAdmin.Controls.Add(pictureBox4);
            chkAdmin.Controls.Add(pictureBox2);
            chkAdmin.Controls.Add(groupBox2);
            chkAdmin.Dock = DockStyle.Top;
            chkAdmin.ForeColor = Color.Silver;
            chkAdmin.Location = new Point(0, 0);
            chkAdmin.Margin = new Padding(4, 5, 4, 5);
            chkAdmin.Name = "chkAdmin";
            chkAdmin.Size = new Size(1444, 220);
            chkAdmin.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Silkscreen", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Lime;
            lblTitle.Location = new Point(27, 30);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(550, 39);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Employee Profile";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Lime;
            pictureBox4.Location = new Point(-26, 144);
            pictureBox4.Margin = new Padding(4, 5, 4, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(940, 10);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Lime;
            pictureBox2.Location = new Point(-100, 88);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(829, 10);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chAdmin);
            groupBox2.Controls.Add(passwordTxt);
            groupBox2.Controls.Add(btnCheck);
            groupBox2.Controls.Add(useridTxt);
            groupBox2.Location = new Point(1133, 30);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(294, 172);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // chAdmin
            // 
            chAdmin.AutoSize = true;
            chAdmin.Font = new Font("Silkscreen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chAdmin.Location = new Point(31, 133);
            chAdmin.Margin = new Padding(4, 5, 4, 5);
            chAdmin.Name = "chAdmin";
            chAdmin.Size = new Size(165, 25);
            chAdmin.TabIndex = 3;
            chAdmin.Text = "Is Admin?";
            chAdmin.UseVisualStyleBackColor = true;
            // 
            // passwordTxt
            // 
            passwordTxt.BackColor = SystemColors.ActiveCaptionText;
            passwordTxt.Font = new Font("Silkscreen", 9.75F);
            passwordTxt.ForeColor = Color.LightGray;
            passwordTxt.Location = new Point(31, 85);
            passwordTxt.Margin = new Padding(4, 5, 4, 5);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(231, 27);
            passwordTxt.TabIndex = 2;
            passwordTxt.Text = "Password";
            passwordTxt.WordWrap = false;
            passwordTxt.KeyDown += PasswordTxt_KeyDown;
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.Black;
            btnCheck.Font = new Font("Silkscreen", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheck.ForeColor = Color.Lime;
            btnCheck.Location = new Point(161, 37);
            btnCheck.Margin = new Padding(4, 5, 4, 5);
            btnCheck.Name = "btnCheck";
            btnCheck.Padding = new Padding(0, 0, 0, 8);
            btnCheck.Size = new Size(103, 38);
            btnCheck.TabIndex = 1;
            btnCheck.Text = "Check";
            btnCheck.TextAlign = ContentAlignment.BottomCenter;
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // useridTxt
            // 
            useridTxt.BackColor = SystemColors.ActiveCaptionText;
            useridTxt.Font = new Font("Silkscreen", 9.75F);
            useridTxt.ForeColor = Color.LightGray;
            useridTxt.Location = new Point(31, 37);
            useridTxt.Margin = new Padding(4, 5, 4, 5);
            useridTxt.Name = "useridTxt";
            useridTxt.Size = new Size(120, 27);
            useridTxt.TabIndex = 0;
            useridTxt.Text = "User ID";
            useridTxt.WordWrap = false;
            useridTxt.KeyDown += useridTxt_KeyDown;
            useridTxt.KeyPress += useridTxt_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Lime;
            pictureBox1.Location = new Point(-265, 574);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(760, 10);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ActiveCaptionText;
            txtName.Font = new Font("Silkscreen", 14.25F);
            txtName.ForeColor = Color.LightGray;
            txtName.Location = new Point(43, 73);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(393, 36);
            txtName.TabIndex = 0;
            txtName.Text = "First Name";
            txtName.WordWrap = false;
            txtName.KeyDown += txtName_KeyDown;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = SystemColors.ActiveCaptionText;
            txtLastName.Font = new Font("Silkscreen", 14.25F);
            txtLastName.ForeColor = Color.LightGray;
            txtLastName.Location = new Point(43, 127);
            txtLastName.Margin = new Padding(4, 5, 4, 5);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(393, 36);
            txtLastName.TabIndex = 1;
            txtLastName.Text = "Last Name";
            txtLastName.WordWrap = false;
            txtLastName.KeyDown += txtLastName_KeyDown;
            // 
            // txtImagePath
            // 
            txtImagePath.BackColor = SystemColors.ActiveCaptionText;
            txtImagePath.Font = new Font("Silkscreen", 14.25F);
            txtImagePath.ForeColor = Color.LightGray;
            txtImagePath.Location = new Point(43, 180);
            txtImagePath.Margin = new Padding(4, 5, 4, 5);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.Size = new Size(393, 36);
            txtImagePath.TabIndex = 2;
            txtImagePath.Text = "Image Path";
            txtImagePath.WordWrap = false;
            txtImagePath.KeyDown += txtImagePath_KeyDown;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblSaved);
            groupBox1.Controls.Add(ExitButton);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtDob);
            groupBox1.Controls.Add(cmbDeparments);
            groupBox1.Controls.Add(cmbPosition);
            groupBox1.Controls.Add(txtSalary);
            groupBox1.Controls.Add(btn_Browse);
            groupBox1.Controls.Add(pbProfilePic);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtImagePath);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Location = new Point(44, 230);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1353, 955);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lblSaved
            // 
            lblSaved.AutoSize = true;
            lblSaved.Font = new Font("Silkscreen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaved.Location = new Point(43, 603);
            lblSaved.Name = "lblSaved";
            lblSaved.Size = new Size(150, 21);
            lblSaved.TabIndex = 8;
            lblSaved.Text = "Warning";
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Black;
            ExitButton.Font = new Font("Silkscreen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(160, 883);
            ExitButton.Margin = new Padding(4, 5, 4, 5);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(109, 38);
            ExitButton.TabIndex = 10;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Black;
            btnSave.Font = new Font("Silkscreen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(43, 883);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(109, 38);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Lime;
            pictureBox3.Location = new Point(-75, 841);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1454, 10);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.ActiveCaptionText;
            txtAddress.Font = new Font("Silkscreen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.ForeColor = Color.LightGray;
            txtAddress.Location = new Point(43, 428);
            txtAddress.Margin = new Padding(4, 5, 4, 5);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(480, 126);
            txtAddress.TabIndex = 7;
            txtAddress.Text = "Address";
            txtAddress.WordWrap = false;
            txtAddress.KeyDown += txtAddress_KeyDown;
            // 
            // txtDob
            // 
            txtDob.BackColor = SystemColors.ActiveCaptionText;
            txtDob.Font = new Font("Silkscreen", 14.25F);
            txtDob.ForeColor = Color.LightGray;
            txtDob.Location = new Point(43, 375);
            txtDob.Margin = new Padding(4, 5, 4, 5);
            txtDob.Name = "txtDob";
            txtDob.Size = new Size(480, 36);
            txtDob.TabIndex = 6;
            txtDob.Text = "D.O.B";
            txtDob.WordWrap = false;
            txtDob.KeyPress += txtDob_KeyPress;
            // 
            // cmbDeparments
            // 
            cmbDeparments.BackColor = SystemColors.InactiveCaptionText;
            cmbDeparments.FlatStyle = FlatStyle.Flat;
            cmbDeparments.Font = new Font("Silkscreen", 14.25F);
            cmbDeparments.ForeColor = Color.Lime;
            cmbDeparments.FormattingEnabled = true;
            cmbDeparments.Location = new Point(43, 275);
            cmbDeparments.Margin = new Padding(4, 5, 4, 5);
            cmbDeparments.Name = "cmbDeparments";
            cmbDeparments.Size = new Size(480, 33);
            cmbDeparments.TabIndex = 4;
            cmbDeparments.SelectedIndexChanged += cmbDeparments_SelectedIndexChanged;
            // 
            // cmbPosition
            // 
            cmbPosition.BackColor = SystemColors.InactiveCaptionText;
            cmbPosition.Font = new Font("Silkscreen", 14.25F);
            cmbPosition.ForeColor = Color.Lime;
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(43, 325);
            cmbPosition.Margin = new Padding(4, 5, 4, 5);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(480, 33);
            cmbPosition.TabIndex = 5;
            cmbPosition.Text = "Positions";
            // 
            // txtSalary
            // 
            txtSalary.BackColor = SystemColors.ActiveCaptionText;
            txtSalary.Font = new Font("Silkscreen", 14.25F);
            txtSalary.ForeColor = Color.LightGray;
            txtSalary.Location = new Point(41, 228);
            txtSalary.Margin = new Padding(4, 5, 4, 5);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(481, 36);
            txtSalary.TabIndex = 3;
            txtSalary.Text = "Salary";
            txtSalary.WordWrap = false;
            txtSalary.KeyDown += txtSalary_KeyDown;
            // 
            // btn_Browse
            // 
            btn_Browse.BackColor = Color.Black;
            btn_Browse.Font = new Font("Silkscreen Expanded", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Browse.ForeColor = Color.Lime;
            btn_Browse.Location = new Point(446, 185);
            btn_Browse.Margin = new Padding(4, 5, 4, 5);
            btn_Browse.Name = "btn_Browse";
            btn_Browse.Padding = new Padding(0, 0, 0, 8);
            btn_Browse.Size = new Size(79, 38);
            btn_Browse.TabIndex = 11;
            btn_Browse.Text = "...";
            btn_Browse.TextAlign = ContentAlignment.BottomCenter;
            btn_Browse.UseVisualStyleBackColor = false;
            btn_Browse.Click += btn_Browse_Click;
            // 
            // pbProfilePic
            // 
            pbProfilePic.BackgroundImageLayout = ImageLayout.Stretch;
            pbProfilePic.Location = new Point(757, 100);
            pbProfilePic.Margin = new Padding(4, 5, 4, 5);
            pbProfilePic.Name = "pbProfilePic";
            pbProfilePic.Size = new Size(500, 500);
            pbProfilePic.TabIndex = 7;
            pbProfilePic.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1444, 1233);
            Controls.Add(groupBox1);
            Controls.Add(chkAdmin);
            ForeColor = Color.Lime;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            Load += FrmEmployee_Load;
            chkAdmin.ResumeLayout(false);
            chkAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProfilePic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel chkAdmin;
        private TextBox useridTxt;
        private Button btnCheck;
        private CheckBox chAdmin;
        private TextBox passwordTxt;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private TextBox txtName;
        private TextBox txtLastName;
        private TextBox txtImagePath;
        private GroupBox groupBox1;
        private Label lblTitle;
        private PictureBox pictureBox2;
        private TextBox txtSalary;
        private Button btn_Browse;
        private PictureBox pbProfilePic;
        private OpenFileDialog openFileDialog1;
        private ComboBox cmbDeparments;
        private ComboBox cmbPosition;
        private TextBox txtAddress;
        private TextBox txtDob;
        private Button ExitButton;
        private Button btnSave;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label lblSaved;
    }
}