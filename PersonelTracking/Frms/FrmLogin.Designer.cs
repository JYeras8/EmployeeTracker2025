namespace PersonelTracking;

partial class FrmLogin
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
        useridTxt = new TextBox();
        pictureBox1 = new PictureBox();
        PasswordTxt = new TextBox();
        btnEnter = new Button();
        btnExit = new Button();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        pictureBox2 = new PictureBox();
        groupBox1 = new GroupBox();
        pictureBox3 = new PictureBox();
        groupBox2 = new GroupBox();
        pictureBox4 = new PictureBox();
        lblSaved = new Label();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
        groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
        SuspendLayout();
        // 
        // useridTxt
        // 
        useridTxt.BackColor = SystemColors.ActiveCaptionText;
        useridTxt.Font = new Font("Silkscreen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        useridTxt.ForeColor = Color.LightGray;
        useridTxt.Location = new Point(27, 47);
        useridTxt.Name = "useridTxt";
        useridTxt.Size = new Size(370, 27);
        useridTxt.TabIndex = 1;
        useridTxt.Text = "User ID";
        useridTxt.WordWrap = false;
        useridTxt.KeyDown += useridTxt_KeyDown;
        useridTxt.KeyPress += useridTxt_KeyPress;
        // 
        // pictureBox1
        // 
        pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
        pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        pictureBox1.Enabled = false;
        pictureBox1.Location = new Point(615, 30);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(114, 110);
        pictureBox1.TabIndex = 2;
        pictureBox1.TabStop = false;
        // 
        // PasswordTxt
        // 
        PasswordTxt.BackColor = SystemColors.ActiveCaptionText;
        PasswordTxt.Font = new Font("Silkscreen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        PasswordTxt.ForeColor = Color.LightGray;
        PasswordTxt.Location = new Point(27, 82);
        PasswordTxt.Name = "PasswordTxt";
        PasswordTxt.Size = new Size(370, 27);
        PasswordTxt.TabIndex = 2;
        PasswordTxt.Text = "Password";
        PasswordTxt.WordWrap = false;
        PasswordTxt.KeyDown += PasswordTxt_KeyDown;
        PasswordTxt.KeyPress += PasswordTxt_KeyPress;
        // 
        // btnEnter
        // 
        btnEnter.BackColor = SystemColors.ActiveCaptionText;
        btnEnter.Font = new Font("Silkscreen", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnEnter.Location = new Point(58, 127);
        btnEnter.Name = "btnEnter";
        btnEnter.Padding = new Padding(0, 0, 0, 5);
        btnEnter.Size = new Size(147, 43);
        btnEnter.TabIndex = 3;
        btnEnter.Text = "Login";
        btnEnter.TextAlign = ContentAlignment.BottomCenter;
        btnEnter.UseVisualStyleBackColor = false;
        btnEnter.Click += btnEnter_Click;
        // 
        // btnExit
        // 
        btnExit.BackColor = SystemColors.ActiveCaptionText;
        btnExit.Font = new Font("Silkscreen", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnExit.Location = new Point(211, 127);
        btnExit.Name = "btnExit";
        btnExit.Padding = new Padding(0, 0, 0, 5);
        btnExit.Size = new Size(147, 43);
        btnExit.TabIndex = 4;
        btnExit.Text = "Exit";
        btnExit.TextAlign = ContentAlignment.BottomCenter;
        btnExit.UseVisualStyleBackColor = false;
        btnExit.Click += btnExit_Click;
        // 
        // label1
        // 
        label1.Font = new Font("Silkscreen Expanded", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(7, 26);
        label1.Name = "label1";
        label1.Size = new Size(462, 40);
        label1.TabIndex = 10;
        label1.Text = "Personell Tracker";
        // 
        // label2
        // 
        label2.Font = new Font("Silkscreen Expanded", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.Location = new Point(27, 23);
        label2.Name = "label2";
        label2.Size = new Size(135, 21);
        label2.TabIndex = 10;
        label2.Text = "Login";
        // 
        // label3
        // 
        label3.Font = new Font("Silkscreen", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
        label3.Location = new Point(353, 61);
        label3.Name = "label3";
        label3.Size = new Size(100, 20);
        label3.TabIndex = 10;
        label3.Text = "2025";
        // 
        // pictureBox2
        // 
        pictureBox2.BackColor = Color.Lime;
        pictureBox2.Location = new Point(-18, 111);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(519, 10);
        pictureBox2.TabIndex = 11;
        pictureBox2.TabStop = false;
        // 
        // groupBox1
        // 
        groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        groupBox1.BackColor = SystemColors.ActiveCaptionText;
        groupBox1.Controls.Add(pictureBox1);
        groupBox1.Controls.Add(pictureBox3);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label1);
        groupBox1.FlatStyle = FlatStyle.System;
        groupBox1.ImeMode = ImeMode.NoControl;
        groupBox1.Location = new Point(12, 6);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(760, 172);
        groupBox1.TabIndex = 12;
        groupBox1.TabStop = false;
        // 
        // pictureBox3
        // 
        pictureBox3.BackColor = Color.Lime;
        pictureBox3.Location = new Point(-96, 89);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new Size(533, 10);
        pictureBox3.TabIndex = 11;
        pictureBox3.TabStop = false;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(btnExit);
        groupBox2.Controls.Add(btnEnter);
        groupBox2.Controls.Add(label2);
        groupBox2.Controls.Add(PasswordTxt);
        groupBox2.Controls.Add(useridTxt);
        groupBox2.Location = new Point(190, 226);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(427, 188);
        groupBox2.TabIndex = 13;
        groupBox2.TabStop = false;
        // 
        // pictureBox4
        // 
        pictureBox4.BackColor = Color.Lime;
        pictureBox4.Location = new Point(-18, 136);
        pictureBox4.Name = "pictureBox4";
        pictureBox4.Size = new Size(519, 10);
        pictureBox4.TabIndex = 11;
        pictureBox4.TabStop = false;
        // 
        // lblSaved
        // 
        lblSaved.AutoSize = true;
        lblSaved.Font = new Font("Silkscreen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblSaved.ForeColor = Color.Lime;
        lblSaved.Location = new Point(148, 431);
        lblSaved.Margin = new Padding(2, 0, 2, 0);
        lblSaved.Name = "lblSaved";
        lblSaved.Size = new Size(126, 17);
        lblSaved.TabIndex = 14;
        lblSaved.Text = "Warning";
        // 
        // FrmLogin
        // 
        AutoScaleMode = AutoScaleMode.None;
        BackColor = SystemColors.ActiveCaptionText;
        ClientSize = new Size(784, 476);
        Controls.Add(lblSaved);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Controls.Add(pictureBox2);
        Controls.Add(pictureBox4);
        ForeColor = Color.Lime;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        Name = "FrmLogin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Personell_Tracker";
        Load += FrmLogin_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        groupBox1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.PictureBox pictureBox4;

    private System.Windows.Forms.PictureBox pictureBox3;

    private System.Windows.Forms.GroupBox groupBox2;

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.PictureBox pictureBox2;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button btnExit;

    private System.Windows.Forms.Button btnEnter;

    private System.Windows.Forms.TextBox PasswordTxt;

    private System.Windows.Forms.TextBox useridTxt;

    private System.Windows.Forms.TextBox textBox2;

    private System.Windows.Forms.PictureBox pictureBox1;

    #endregion

    private Label lblSaved;
}