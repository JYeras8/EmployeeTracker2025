using System.ComponentModel;

namespace PersonelTracking;

partial class FrmMain
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(FrmMain));
        pictureBox1 = new PictureBox();
        textBox1 = new TextBox();
        btnEmployee = new Button();
        btnTask = new Button();
        btnSalary = new Button();
        btnPosition = new Button();
        btnDeparment = new Button();
        btnExit = new Button();
        btnLogout = new Button();
        Permission = new Button();
        groupBox1 = new GroupBox();
        textBox2 = new TextBox();
        richTextBox1 = new RichTextBox();
        pictureBox2 = new PictureBox();
        lblWelcome = new Label();
        ((ISupportInitialize)pictureBox1).BeginInit();
        groupBox1.SuspendLayout();
        ((ISupportInitialize)pictureBox2).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.BackColor = Color.Lime;
        pictureBox1.Location = new Point(-208, 57);
        pictureBox1.Margin = new Padding(3, 4, 3, 4);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(954, 8);
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // textBox1
        // 
        textBox1.BackColor = SystemColors.InactiveCaptionText;
        textBox1.BorderStyle = BorderStyle.None;
        textBox1.Font = new Font("Silkscreen", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        textBox1.ForeColor = Color.Lime;
        textBox1.Location = new Point(14, 16);
        textBox1.Margin = new Padding(3, 4, 3, 4);
        textBox1.Name = "textBox1";
        textBox1.ReadOnly = true;
        textBox1.Size = new Size(507, 34);
        textBox1.TabIndex = 0;
        textBox1.TabStop = false;
        textBox1.Text = "Employee Tracker";
        // 
        // btnEmployee
        // 
        btnEmployee.BackColor = SystemColors.ActiveCaptionText;
        btnEmployee.Font = new Font("Silkscreen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnEmployee.ForeColor = Color.Lime;
        btnEmployee.Location = new Point(93, 363);
        btnEmployee.Margin = new Padding(3, 4, 3, 4);
        btnEmployee.Name = "btnEmployee";
        btnEmployee.Padding = new Padding(0, 0, 0, 20);
        btnEmployee.Size = new Size(191, 199);
        btnEmployee.TabIndex = 4;
        btnEmployee.Text = "Employee";
        btnEmployee.TextAlign = ContentAlignment.BottomCenter;
        btnEmployee.UseVisualStyleBackColor = false;
        btnEmployee.Click += btnEmployee_Click;
        // 
        // btnTask
        // 
        btnTask.BackColor = SystemColors.ActiveCaptionText;
        btnTask.Font = new Font("Silkscreen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnTask.ForeColor = Color.Lime;
        btnTask.Location = new Point(93, 57);
        btnTask.Margin = new Padding(3, 4, 3, 4);
        btnTask.Name = "btnTask";
        btnTask.Padding = new Padding(0, 0, 0, 20);
        btnTask.Size = new Size(191, 199);
        btnTask.TabIndex = 1;
        btnTask.Text = "Task";
        btnTask.TextAlign = ContentAlignment.BottomCenter;
        btnTask.UseVisualStyleBackColor = false;
        btnTask.Click += btnTask_Click;
        // 
        // btnSalary
        // 
        btnSalary.BackColor = SystemColors.ActiveCaptionText;
        btnSalary.Font = new Font("Silkscreen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnSalary.ForeColor = Color.Lime;
        btnSalary.Location = new Point(710, 57);
        btnSalary.Margin = new Padding(3, 4, 3, 4);
        btnSalary.Name = "btnSalary";
        btnSalary.Padding = new Padding(0, 0, 0, 20);
        btnSalary.Size = new Size(191, 199);
        btnSalary.TabIndex = 3;
        btnSalary.Text = "Salary";
        btnSalary.TextAlign = ContentAlignment.BottomCenter;
        btnSalary.UseVisualStyleBackColor = false;
        btnSalary.Click += btnSalary_Click;
        // 
        // btnPosition
        // 
        btnPosition.BackColor = SystemColors.ActiveCaptionText;
        btnPosition.Font = new Font("Silkscreen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnPosition.ForeColor = Color.Lime;
        btnPosition.Location = new Point(710, 363);
        btnPosition.Margin = new Padding(3, 4, 3, 4);
        btnPosition.Name = "btnPosition";
        btnPosition.Padding = new Padding(0, 0, 0, 20);
        btnPosition.Size = new Size(191, 199);
        btnPosition.TabIndex = 5;
        btnPosition.Text = "Position";
        btnPosition.TextAlign = ContentAlignment.BottomCenter;
        btnPosition.UseVisualStyleBackColor = false;
        btnPosition.Click += btnPosition_Click;
        // 
        // btnDeparment
        // 
        btnDeparment.BackColor = SystemColors.ActiveCaptionText;
        btnDeparment.Font = new Font("Silkscreen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnDeparment.ForeColor = Color.Lime;
        btnDeparment.Location = new Point(402, 57);
        btnDeparment.Margin = new Padding(3, 4, 3, 4);
        btnDeparment.Name = "btnDeparment";
        btnDeparment.Padding = new Padding(0, 0, 0, 20);
        btnDeparment.Size = new Size(191, 199);
        btnDeparment.TabIndex = 2;
        btnDeparment.Text = "Department";
        btnDeparment.TextAlign = ContentAlignment.BottomCenter;
        btnDeparment.UseVisualStyleBackColor = false;
        btnDeparment.Click += btnDeparment_Click;
        // 
        // btnExit
        // 
        btnExit.BackColor = SystemColors.ActiveCaptionText;
        btnExit.Font = new Font("Silkscreen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnExit.ForeColor = Color.Lime;
        btnExit.Location = new Point(93, 657);
        btnExit.Margin = new Padding(3, 4, 3, 4);
        btnExit.Name = "btnExit";
        btnExit.Padding = new Padding(0, 0, 0, 20);
        btnExit.Size = new Size(191, 199);
        btnExit.TabIndex = 6;
        btnExit.Text = "Exit";
        btnExit.TextAlign = ContentAlignment.BottomCenter;
        btnExit.UseVisualStyleBackColor = false;
        btnExit.Click += btnExit_Click;
        // 
        // btnLogout
        // 
        btnLogout.BackColor = SystemColors.ActiveCaptionText;
        btnLogout.Font = new Font("Silkscreen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnLogout.ForeColor = Color.Lime;
        btnLogout.Location = new Point(402, 657);
        btnLogout.Margin = new Padding(3, 4, 3, 4);
        btnLogout.Name = "btnLogout";
        btnLogout.Padding = new Padding(0, 0, 0, 20);
        btnLogout.Size = new Size(191, 199);
        btnLogout.TabIndex = 7;
        btnLogout.Text = "LogOut";
        btnLogout.TextAlign = ContentAlignment.BottomCenter;
        btnLogout.UseVisualStyleBackColor = false;
        btnLogout.Click += btnLogout_Click;
        // 
        // Permission
        // 
        Permission.BackColor = SystemColors.ActiveCaptionText;
        Permission.Font = new Font("Silkscreen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Permission.ForeColor = Color.Lime;
        Permission.Location = new Point(710, 657);
        Permission.Margin = new Padding(3, 4, 3, 4);
        Permission.Name = "Permission";
        Permission.Padding = new Padding(0, 0, 0, 20);
        Permission.Size = new Size(191, 199);
        Permission.TabIndex = 8;
        Permission.Text = "Permission";
        Permission.TextAlign = ContentAlignment.BottomCenter;
        Permission.UseVisualStyleBackColor = false;
        Permission.Click += Permission_Click;
        // 
        // groupBox1
        // 
        groupBox1.BackColor = SystemColors.ActiveCaptionText;
        groupBox1.Controls.Add(btnTask);
        groupBox1.Controls.Add(btnLogout);
        groupBox1.Controls.Add(Permission);
        groupBox1.Controls.Add(btnExit);
        groupBox1.Controls.Add(btnDeparment);
        groupBox1.Controls.Add(btnPosition);
        groupBox1.Controls.Add(btnSalary);
        groupBox1.Controls.Add(btnEmployee);
        groupBox1.Controls.Add(textBox2);
        groupBox1.Controls.Add(richTextBox1);
        groupBox1.FlatStyle = FlatStyle.Flat;
        groupBox1.Location = new Point(30, 100);
        groupBox1.Margin = new Padding(3, 4, 3, 4);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(3, 4, 3, 4);
        groupBox1.Size = new Size(994, 946);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        // 
        // textBox2
        // 
        textBox2.BackColor = SystemColors.ActiveCaptionText;
        textBox2.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        textBox2.ForeColor = Color.Lime;
        textBox2.Location = new Point(188, 156);
        textBox2.Margin = new Padding(3, 4, 3, 4);
        textBox2.Multiline = true;
        textBox2.Name = "textBox2";
        textBox2.ReadOnly = true;
        textBox2.Size = new Size(620, 603);
        textBox2.TabIndex = 0;
        textBox2.TabStop = false;
        textBox2.TextAlign = HorizontalAlignment.Center;
        textBox2.WordWrap = false;
        // 
        // richTextBox1
        // 
        richTextBox1.BackColor = SystemColors.ActiveCaptionText;
        richTextBox1.ForeColor = Color.Lime;
        richTextBox1.Location = new Point(15, 24);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.ReadOnly = true;
        richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
        richTextBox1.Size = new Size(963, 914);
        richTextBox1.TabIndex = 9;
        richTextBox1.Text = "";
        // 
        // pictureBox2
        // 
        pictureBox2.BackColor = Color.Lime;
        pictureBox2.Location = new Point(-314, 73);
        pictureBox2.Margin = new Padding(3, 4, 3, 4);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(954, 8);
        pictureBox2.TabIndex = 0;
        pictureBox2.TabStop = false;
        // 
        // lblWelcome
        // 
        lblWelcome.AutoSize = true;
        lblWelcome.Font = new Font("Silkscreen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblWelcome.ForeColor = Color.Lime;
        lblWelcome.Location = new Point(666, 79);
        lblWelcome.Name = "lblWelcome";
        lblWelcome.Size = new Size(134, 17);
        lblWelcome.TabIndex = 2;
        lblWelcome.Text = "Welcome ";
        // 
        // FrmMain
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaptionText;
        ClientSize = new Size(1068, 1076);
        Controls.Add(lblWelcome);
        Controls.Add(textBox1);
        Controls.Add(pictureBox2);
        Controls.Add(pictureBox1);
        Controls.Add(groupBox1);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        Name = "FrmMain";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Employee Tracking";
        FormClosed += FrmMain_FormClosed;
        Load += FrmMain_Load;
        ((ISupportInitialize)pictureBox1).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((ISupportInitialize)pictureBox2).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.Button btnPosition;
    private System.Windows.Forms.Button btnDeparment;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Button btnLogout;
    private System.Windows.Forms.Button Permission;

    private System.Windows.Forms.Button btnSalary;

    private System.Windows.Forms.Button btnTask;

    private System.Windows.Forms.Button btnEmployee;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.PictureBox pictureBox1;

    #endregion
    private PictureBox pictureBox2;
    private TextBox textBox2;
    private RichTextBox richTextBox1;
    private Label lblWelcome;
}