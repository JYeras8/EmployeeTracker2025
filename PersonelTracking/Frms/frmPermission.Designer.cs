namespace PersonelTracking
{
    partial class frmPermission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPermission));
            useridTxt = new TextBox();
            pictureBox2 = new PictureBox();
            lblTitle = new Label();
            dpStartDate = new DateTimePicker();
            label3 = new Label();
            label1 = new Label();
            dpComplete = new DateTimePicker();
            txtDayAmount = new TextBox();
            txtExplain = new TextBox();
            ExitButton = new Button();
            btnSave = new Button();
            pictureBox3 = new PictureBox();
            pbProfilePic = new PictureBox();
            lblSaved = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProfilePic).BeginInit();
            SuspendLayout();
            // 
            // useridTxt
            // 
            useridTxt.BackColor = SystemColors.ActiveCaptionText;
            useridTxt.Font = new Font("Silkscreen", 11.25F);
            useridTxt.ForeColor = Color.LightGray;
            useridTxt.Location = new Point(27, 81);
            useridTxt.Margin = new Padding(3, 4, 3, 4);
            useridTxt.Name = "useridTxt";
            useridTxt.ReadOnly = true;
            useridTxt.Size = new Size(207, 26);
            useridTxt.TabIndex = 1;
            useridTxt.Text = "User ID";
            useridTxt.WordWrap = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Lime;
            pictureBox2.Location = new Point(-170, 56);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(563, 8);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Silkscreen", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Lime;
            lblTitle.Location = new Point(14, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(332, 32);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Permissions";
            // 
            // dpStartDate
            // 
            dpStartDate.CalendarForeColor = Color.Lime;
            dpStartDate.CalendarMonthBackground = SystemColors.WindowText;
            dpStartDate.Font = new Font("Silkscreen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dpStartDate.Format = DateTimePickerFormat.Short;
            dpStartDate.Location = new Point(166, 127);
            dpStartDate.Margin = new Padding(3, 4, 3, 4);
            dpStartDate.Name = "dpStartDate";
            dpStartDate.Size = new Size(135, 22);
            dpStartDate.TabIndex = 1;
            dpStartDate.ValueChanged += dpStartDate_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Enabled = false;
            label3.Font = new Font("Silkscreen", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(27, 133);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 14;
            label3.Text = "Start Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Enabled = false;
            label1.Font = new Font("Silkscreen", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(27, 171);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 15;
            label1.Text = "End Date";
            // 
            // dpComplete
            // 
            dpComplete.CalendarForeColor = Color.Lime;
            dpComplete.CalendarMonthBackground = SystemColors.WindowText;
            dpComplete.Font = new Font("Silkscreen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dpComplete.Format = DateTimePickerFormat.Short;
            dpComplete.Location = new Point(166, 165);
            dpComplete.Margin = new Padding(3, 4, 3, 4);
            dpComplete.Name = "dpComplete";
            dpComplete.Size = new Size(135, 22);
            dpComplete.TabIndex = 2;
            dpComplete.ValueChanged += dpComplete_ValueChanged;
            // 
            // txtDayAmount
            // 
            txtDayAmount.BackColor = SystemColors.ActiveCaptionText;
            txtDayAmount.Font = new Font("Silkscreen", 11.25F);
            txtDayAmount.ForeColor = Color.LightGray;
            txtDayAmount.Location = new Point(27, 222);
            txtDayAmount.Margin = new Padding(3, 4, 3, 4);
            txtDayAmount.Name = "txtDayAmount";
            txtDayAmount.ReadOnly = true;
            txtDayAmount.Size = new Size(207, 26);
            txtDayAmount.TabIndex = 3;
            txtDayAmount.Text = "Day Amount";
            txtDayAmount.WordWrap = false;
            // 
            // txtExplain
            // 
            txtExplain.BackColor = SystemColors.ActiveCaptionText;
            txtExplain.Font = new Font("Silkscreen", 11.25F);
            txtExplain.ForeColor = Color.LightGray;
            txtExplain.Location = new Point(27, 316);
            txtExplain.Margin = new Padding(3, 4, 3, 4);
            txtExplain.Multiline = true;
            txtExplain.Name = "txtExplain";
            txtExplain.Size = new Size(494, 226);
            txtExplain.TabIndex = 4;
            txtExplain.Text = "Permission Description";
            txtExplain.WordWrap = false;
            txtExplain.KeyDown += txtExplain_KeyDown;
            txtExplain.KeyPress += txtExplain_KeyPress;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Black;
            ExitButton.Font = new Font("Silkscreen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.ForeColor = Color.Lime;
            ExitButton.Location = new Point(121, 600);
            ExitButton.Margin = new Padding(3, 4, 3, 4);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(87, 30);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Black;
            btnSave.Font = new Font("Silkscreen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Lime;
            btnSave.Location = new Point(27, 600);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(87, 30);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Lime;
            pictureBox3.Location = new Point(-21, 563);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(619, 10);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pbProfilePic
            // 
            pbProfilePic.BackgroundImageLayout = ImageLayout.Stretch;
            pbProfilePic.Location = new Point(546, 34);
            pbProfilePic.Margin = new Padding(3, 4, 3, 4);
            pbProfilePic.Name = "pbProfilePic";
            pbProfilePic.Size = new Size(226, 214);
            pbProfilePic.TabIndex = 16;
            pbProfilePic.TabStop = false;
            // 
            // lblSaved
            // 
            lblSaved.AutoSize = true;
            lblSaved.Font = new Font("Silkscreen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaved.ForeColor = Color.Lime;
            lblSaved.Location = new Point(27, 654);
            lblSaved.Margin = new Padding(2, 0, 2, 0);
            lblSaved.Name = "lblSaved";
            lblSaved.Size = new Size(126, 17);
            lblSaved.TabIndex = 17;
            lblSaved.Text = "Warning";
            // 
            // frmPermission
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(865, 763);
            Controls.Add(pbProfilePic);
            Controls.Add(lblSaved);
            Controls.Add(ExitButton);
            Controls.Add(btnSave);
            Controls.Add(dpStartDate);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dpComplete);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(lblTitle);
            Controls.Add(txtExplain);
            Controls.Add(txtDayAmount);
            Controls.Add(useridTxt);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPermission";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Permissions";
            Load += frmPermission_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProfilePic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox useridTxt;
        private PictureBox pictureBox2;
        private Label lblTitle;
        private DateTimePicker dpStartDate;
        private Label label3;
        private Label label1;
        private DateTimePicker dpComplete;
        private TextBox txtDayAmount;
        private TextBox txtExplain;
        private Button ExitButton;
        private Button btnSave;
        private PictureBox pictureBox3;
        private PictureBox pbProfilePic;
        private Label lblSaved;
    }
}