using System.ComponentModel;

namespace PersonelTracking;

partial class FrmDeparment
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(FrmDeparment));
        lblTitle = new Label();
        txtDepartment = new TextBox();
        btnSave = new Button();
        ExitButton = new Button();
        pictureBox1 = new PictureBox();
        pictureBox2 = new PictureBox();
        lblSaved = new Label();
        ((ISupportInitialize)pictureBox1).BeginInit();
        ((ISupportInitialize)pictureBox2).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.Enabled = false;
        lblTitle.Font = new Font("Silkscreen", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        lblTitle.Location = new Point(-3, 9);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(431, 32);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Deparment Registery";
        // 
        // txtDepartment
        // 
        txtDepartment.BackColor = Color.Black;
        txtDepartment.Font = new Font("Silkscreen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        txtDepartment.ForeColor = Color.Silver;
        txtDepartment.Location = new Point(48, 139);
        txtDepartment.Name = "txtDepartment";
        txtDepartment.Size = new Size(471, 31);
        txtDepartment.TabIndex = 0;
        txtDepartment.KeyPress += txtDepartment_KeyPress;
        // 
        // btnSave
        // 
        btnSave.BackColor = Color.Black;
        btnSave.Font = new Font("Silkscreen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnSave.Location = new Point(557, 139);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(112, 41);
        btnSave.TabIndex = 1;
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Click += btnSave_Click;
        // 
        // ExitButton
        // 
        ExitButton.BackColor = Color.Black;
        ExitButton.Font = new Font("Silkscreen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        ExitButton.Location = new Point(562, 249);
        ExitButton.Name = "ExitButton";
        ExitButton.Size = new Size(107, 48);
        ExitButton.TabIndex = 2;
        ExitButton.Text = "Exit";
        ExitButton.UseVisualStyleBackColor = false;
        ExitButton.Click += ExitButton_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.BackColor = Color.Lime;
        pictureBox1.Location = new Point(-153, 44);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(532, 10);
        pictureBox1.TabIndex = 3;
        pictureBox1.TabStop = false;
        // 
        // pictureBox2
        // 
        pictureBox2.BackColor = Color.Lime;
        pictureBox2.Location = new Point(-109, 223);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(787, 10);
        pictureBox2.TabIndex = 3;
        pictureBox2.TabStop = false;
        // 
        // lblSaved
        // 
        lblSaved.AutoSize = true;
        lblSaved.Location = new Point(48, 184);
        lblSaved.Name = "lblSaved";
        lblSaved.Size = new Size(126, 17);
        lblSaved.TabIndex = 4;
        lblSaved.Text = "Warning";
        // 
        // FrmDeparment
        // 
        BackColor = Color.Black;
        ClientSize = new Size(728, 344);
        Controls.Add(lblSaved);
        Controls.Add(pictureBox2);
        Controls.Add(pictureBox1);
        Controls.Add(ExitButton);
        Controls.Add(btnSave);
        Controls.Add(txtDepartment);
        Controls.Add(lblTitle);
        Font = new Font("Silkscreen", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        ForeColor = Color.Lime;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximumSize = new Size(750, 400);
        MinimumSize = new Size(750, 400);
        Name = "FrmDeparment";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "FrmDeparment";
        Load += FrmDeparment_Load;
        ((ISupportInitialize)pictureBox1).EndInit();
        ((ISupportInitialize)pictureBox2).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.PictureBox pictureBox2;

    private System.Windows.Forms.Button ExitButton;
    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.Button btnSave;

    private System.Windows.Forms.TextBox txtDepartment;

    private System.Windows.Forms.Label lblTitle;

    #endregion

    private Label lblSaved;
}