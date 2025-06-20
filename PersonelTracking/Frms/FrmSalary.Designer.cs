namespace PersonelTracking
{
    partial class FrmSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalary));
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            cmbDeparments = new ComboBox();
            cmbPosition = new ComboBox();
            txtName = new TextBox();
            useridTxt = new TextBox();
            txtLastName = new TextBox();
            txtSalary = new TextBox();
            txtYear = new TextBox();
            cmbMonth = new ComboBox();
            ExitButton = new Button();
            btnSave = new Button();
            lblTitle = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pbProfilePic = new PictureBox();
            lblSaved = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProfilePic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(687, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 782);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(25, 25, 25);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.Location = new Point(0, 107);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(457, 675);
            dataGridView1.TabIndex = 1;
            dataGridView1.RowEnter += dataGridView1_RowEnter;
            // 
            // panel2
            // 
            panel2.Controls.Add(cmbDeparments);
            panel2.Controls.Add(cmbPosition);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(457, 107);
            panel2.TabIndex = 0;
            // 
            // cmbDeparments
            // 
            cmbDeparments.BackColor = SystemColors.InactiveCaptionText;
            cmbDeparments.Font = new Font("Silkscreen", 11.25F);
            cmbDeparments.ForeColor = Color.Lime;
            cmbDeparments.FormattingEnabled = true;
            cmbDeparments.Location = new Point(24, 20);
            cmbDeparments.Margin = new Padding(3, 4, 3, 4);
            cmbDeparments.Name = "cmbDeparments";
            cmbDeparments.Size = new Size(282, 24);
            cmbDeparments.TabIndex = 1;
            cmbDeparments.Text = "Departrment";
            cmbDeparments.SelectedIndexChanged += cmbDeparments_SelectedIndexChanged;
            // 
            // cmbPosition
            // 
            cmbPosition.BackColor = SystemColors.InactiveCaptionText;
            cmbPosition.Font = new Font("Silkscreen", 11.25F);
            cmbPosition.ForeColor = Color.Lime;
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(24, 58);
            cmbPosition.Margin = new Padding(3, 4, 3, 4);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(282, 24);
            cmbPosition.TabIndex = 0;
            cmbPosition.Text = "Positions";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ActiveCaptionText;
            txtName.Font = new Font("Silkscreen", 12F);
            txtName.ForeColor = Color.Lime;
            txtName.Location = new Point(15, 145);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(348, 27);
            txtName.TabIndex = 1;
            txtName.Text = "First Name";
            txtName.WordWrap = false;
            // 
            // useridTxt
            // 
            useridTxt.BackColor = SystemColors.ActiveCaptionText;
            useridTxt.Font = new Font("Silkscreen", 12F);
            useridTxt.ForeColor = Color.Lime;
            useridTxt.Location = new Point(14, 107);
            useridTxt.Margin = new Padding(3, 4, 3, 4);
            useridTxt.Name = "useridTxt";
            useridTxt.ReadOnly = true;
            useridTxt.Size = new Size(181, 27);
            useridTxt.TabIndex = 0;
            useridTxt.Text = "User ID";
            useridTxt.WordWrap = false;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = SystemColors.ActiveCaptionText;
            txtLastName.Font = new Font("Silkscreen", 12F);
            txtLastName.ForeColor = Color.Lime;
            txtLastName.Location = new Point(14, 184);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(349, 27);
            txtLastName.TabIndex = 2;
            txtLastName.Text = "Last Name";
            txtLastName.WordWrap = false;
            // 
            // txtSalary
            // 
            txtSalary.BackColor = SystemColors.ActiveCaptionText;
            txtSalary.Font = new Font("Silkscreen", 12F);
            txtSalary.ForeColor = Color.LightGray;
            txtSalary.Location = new Point(15, 230);
            txtSalary.Margin = new Padding(3, 4, 3, 4);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(169, 27);
            txtSalary.TabIndex = 3;
            txtSalary.Text = "Salary";
            txtSalary.WordWrap = false;
            txtSalary.KeyDown += txtSalary_KeyDown;
            // 
            // txtYear
            // 
            txtYear.BackColor = SystemColors.ActiveCaptionText;
            txtYear.Font = new Font("Silkscreen", 12F);
            txtYear.ForeColor = Color.LightGray;
            txtYear.Location = new Point(14, 269);
            txtYear.Margin = new Padding(3, 4, 3, 4);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(169, 27);
            txtYear.TabIndex = 4;
            txtYear.Text = "Year";
            txtYear.WordWrap = false;
            txtYear.KeyDown += txtYear_KeyDown;
            // 
            // cmbMonth
            // 
            cmbMonth.BackColor = SystemColors.InactiveCaptionText;
            cmbMonth.Font = new Font("Silkscreen", 12F);
            cmbMonth.ForeColor = Color.Lime;
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(15, 308);
            cmbMonth.Margin = new Padding(3, 4, 3, 4);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(167, 25);
            cmbMonth.TabIndex = 5;
            cmbMonth.Text = "Month";
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Black;
            ExitButton.Font = new Font("Silkscreen", 12F);
            ExitButton.ForeColor = Color.Lime;
            ExitButton.Location = new Point(108, 476);
            ExitButton.Margin = new Padding(3, 4, 3, 4);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(87, 31);
            ExitButton.TabIndex = 7;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Black;
            btnSave.Font = new Font("Silkscreen", 12F);
            btnSave.ForeColor = Color.Lime;
            btnSave.Location = new Point(15, 476);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(87, 31);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Enabled = false;
            lblTitle.Font = new Font("Silkscreen", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Lime;
            lblTitle.Location = new Point(14, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(457, 32);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Employee Salary";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Lime;
            pictureBox2.Location = new Point(-221, 69);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(661, 10);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Lime;
            pictureBox1.Location = new Point(-11, 427);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(661, 10);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pbProfilePic
            // 
            pbProfilePic.BackgroundImageLayout = ImageLayout.Stretch;
            pbProfilePic.Location = new Point(393, 107);
            pbProfilePic.Margin = new Padding(3, 4, 3, 4);
            pbProfilePic.Name = "pbProfilePic";
            pbProfilePic.Size = new Size(268, 281);
            pbProfilePic.TabIndex = 11;
            pbProfilePic.TabStop = false;
            // 
            // lblSaved
            // 
            lblSaved.AutoSize = true;
            lblSaved.Font = new Font("Silkscreen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaved.ForeColor = Color.Lime;
            lblSaved.Location = new Point(15, 533);
            lblSaved.Margin = new Padding(2, 0, 2, 0);
            lblSaved.Name = "lblSaved";
            lblSaved.Size = new Size(126, 17);
            lblSaved.TabIndex = 12;
            lblSaved.Text = "Warning";
            // 
            // FrmSalary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1144, 782);
            Controls.Add(lblSaved);
            Controls.Add(pbProfilePic);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(ExitButton);
            Controls.Add(btnSave);
            Controls.Add(cmbMonth);
            Controls.Add(txtYear);
            Controls.Add(txtSalary);
            Controls.Add(txtName);
            Controls.Add(useridTxt);
            Controls.Add(txtLastName);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmSalary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salary";
            Load += FrmSalary_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProfilePic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private TextBox txtName;
        private TextBox useridTxt;
        private TextBox txtLastName;
        private ComboBox cmbDeparments;
        private ComboBox cmbPosition;
        private TextBox txtSalary;
        private TextBox txtYear;
        private ComboBox cmbMonth;
        private Button ExitButton;
        private Button btnSave;
        private Label lblTitle;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pbProfilePic;
        private Label lblSaved;
    }
}