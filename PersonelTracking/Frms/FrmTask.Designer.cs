namespace PersonelTracking
{
    partial class FrmTask
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
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            cmbDeparments = new ComboBox();
            cmbPosition = new ComboBox();
            panel3 = new Panel();
            lblSaved = new Label();
            ExitButton = new Button();
            btnSave = new Button();
            cmbTaskState = new ComboBox();
            txtName = new TextBox();
            useridTxt = new TextBox();
            txtContent = new TextBox();
            txtTaskTitle = new TextBox();
            txtLastName = new TextBox();
            pbProfilePic = new PictureBox();
            lblTitle = new Label();
            pictureBox2 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfilePic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(846, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(502, 778);
            panel2.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(25, 25, 25);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.Location = new Point(4, 134);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(498, 644);
            dataGridView1.TabIndex = 13;
            dataGridView1.RowEnter += dataGridView1_RowEnter;
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbDeparments);
            panel1.Controls.Add(cmbPosition);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(502, 134);
            panel1.TabIndex = 12;
            // 
            // cmbDeparments
            // 
            cmbDeparments.BackColor = SystemColors.InactiveCaptionText;
            cmbDeparments.Font = new Font("Silkscreen", 14F);
            cmbDeparments.ForeColor = Color.Lime;
            cmbDeparments.FormattingEnabled = true;
            cmbDeparments.Location = new Point(14, 22);
            cmbDeparments.Margin = new Padding(3, 4, 3, 4);
            cmbDeparments.Name = "cmbDeparments";
            cmbDeparments.Size = new Size(447, 29);
            cmbDeparments.TabIndex = 1;
            cmbDeparments.Text = "Departrment";
            cmbDeparments.SelectedIndexChanged += cmbDeparments_SelectedIndexChanged;
            // 
            // cmbPosition
            // 
            cmbPosition.BackColor = SystemColors.InactiveCaptionText;
            cmbPosition.Font = new Font("Silkscreen", 14F);
            cmbPosition.ForeColor = Color.Lime;
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(14, 54);
            cmbPosition.Margin = new Padding(3, 4, 3, 4);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(447, 29);
            cmbPosition.TabIndex = 0;
            cmbPosition.Text = "Positions";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblSaved);
            panel3.Controls.Add(ExitButton);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(cmbTaskState);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(useridTxt);
            panel3.Controls.Add(txtContent);
            panel3.Controls.Add(txtTaskTitle);
            panel3.Controls.Add(txtLastName);
            panel3.Location = new Point(0, 133);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(840, 640);
            panel3.TabIndex = 12;
            // 
            // lblSaved
            // 
            lblSaved.AutoSize = true;
            lblSaved.Font = new Font("Silkscreen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaved.ForeColor = Color.Lime;
            lblSaved.Location = new Point(32, 510);
            lblSaved.Margin = new Padding(2, 0, 2, 0);
            lblSaved.Name = "lblSaved";
            lblSaved.Size = new Size(126, 17);
            lblSaved.TabIndex = 9;
            lblSaved.Text = "Warning";
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Black;
            ExitButton.Font = new Font("Silkscreen", 14F, FontStyle.Bold);
            ExitButton.ForeColor = Color.Lime;
            ExitButton.Location = new Point(146, 459);
            ExitButton.Margin = new Padding(3, 4, 3, 4);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 30);
            ExitButton.TabIndex = 7;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Black;
            btnSave.Font = new Font("Silkscreen", 14F, FontStyle.Bold);
            btnSave.ForeColor = Color.Lime;
            btnSave.Location = new Point(32, 459);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 30);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // cmbTaskState
            // 
            cmbTaskState.BackColor = SystemColors.InactiveCaptionText;
            cmbTaskState.Font = new Font("Silkscreen", 14F, FontStyle.Bold);
            cmbTaskState.ForeColor = Color.Lime;
            cmbTaskState.FormattingEnabled = true;
            cmbTaskState.Location = new Point(31, 150);
            cmbTaskState.Margin = new Padding(3, 4, 3, 4);
            cmbTaskState.Name = "cmbTaskState";
            cmbTaskState.Size = new Size(427, 29);
            cmbTaskState.TabIndex = 3;
            cmbTaskState.Text = "Task State";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ActiveCaptionText;
            txtName.Font = new Font("Silkscreen", 14F, FontStyle.Bold);
            txtName.ForeColor = Color.Lime;
            txtName.Location = new Point(32, 69);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(335, 31);
            txtName.TabIndex = 1;
            txtName.Text = "First Name";
            txtName.WordWrap = false;
            // 
            // useridTxt
            // 
            useridTxt.BackColor = SystemColors.ActiveCaptionText;
            useridTxt.Font = new Font("Silkscreen", 14F, FontStyle.Bold);
            useridTxt.ForeColor = Color.Lime;
            useridTxt.Location = new Point(31, 30);
            useridTxt.Margin = new Padding(3, 4, 3, 4);
            useridTxt.Name = "useridTxt";
            useridTxt.ReadOnly = true;
            useridTxt.Size = new Size(185, 31);
            useridTxt.TabIndex = 0;
            useridTxt.Text = "User ID";
            useridTxt.WordWrap = false;
            // 
            // txtContent
            // 
            txtContent.BackColor = SystemColors.ActiveCaptionText;
            txtContent.Font = new Font("Silkscreen", 14F, FontStyle.Bold);
            txtContent.ForeColor = Color.Silver;
            txtContent.Location = new Point(31, 226);
            txtContent.Margin = new Padding(3, 4, 3, 4);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(682, 198);
            txtContent.TabIndex = 5;
            txtContent.Text = "Task Description";
            txtContent.KeyPress += txtContent_KeyPress;
            // 
            // txtTaskTitle
            // 
            txtTaskTitle.BackColor = SystemColors.ActiveCaptionText;
            txtTaskTitle.Font = new Font("Silkscreen", 14F, FontStyle.Bold);
            txtTaskTitle.ForeColor = Color.Silver;
            txtTaskTitle.Location = new Point(31, 187);
            txtTaskTitle.Margin = new Padding(3, 4, 3, 4);
            txtTaskTitle.Name = "txtTaskTitle";
            txtTaskTitle.Size = new Size(427, 31);
            txtTaskTitle.TabIndex = 4;
            txtTaskTitle.Text = "TaskTitle";
            txtTaskTitle.WordWrap = false;
            txtTaskTitle.KeyPress += txtTaskTitle_KeyPress;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = SystemColors.ActiveCaptionText;
            txtLastName.Font = new Font("Silkscreen", 14F, FontStyle.Bold);
            txtLastName.ForeColor = Color.Lime;
            txtLastName.Location = new Point(31, 107);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(336, 31);
            txtLastName.TabIndex = 2;
            txtLastName.Text = "Last Name";
            txtLastName.WordWrap = false;
            // 
            // pbProfilePic
            // 
            pbProfilePic.BackgroundImageLayout = ImageLayout.Stretch;
            pbProfilePic.Location = new Point(534, 31);
            pbProfilePic.Margin = new Padding(3, 4, 3, 4);
            pbProfilePic.Name = "pbProfilePic";
            pbProfilePic.Size = new Size(268, 281);
            pbProfilePic.TabIndex = 9;
            pbProfilePic.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Silkscreen", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Lime;
            lblTitle.Location = new Point(46, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(133, 32);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Task";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Lime;
            pictureBox2.Location = new Point(-385, 51);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(600, 14);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // FrmTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1348, 778);
            Controls.Add(pbProfilePic);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmTask";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmTask";
            Load += FrmTask_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfilePic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel3;
        private TextBox txtName;
        private TextBox useridTxt;
        private TextBox txtLastName;
        private ComboBox cmbTaskState;
        private TextBox txtContent;
        private TextBox txtTaskTitle;
        private Button ExitButton;
        private Button btnSave;
        private Panel panel1;
        private ComboBox cmbDeparments;
        private ComboBox cmbPosition;
        private Label lblTitle;
        private PictureBox pictureBox2;
        private PictureBox pbProfilePic;
        private Label lblSaved;
    }
}