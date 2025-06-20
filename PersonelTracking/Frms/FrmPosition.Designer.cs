using System.ComponentModel;

namespace PersonelTracking;

partial class FrmPosition
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(FrmPosition));
        btnSave = new Button();
        ExitButton = new Button();
        txtPostion = new TextBox();
        cmbDeparments = new ComboBox();
        pictureBox1 = new PictureBox();
        label1 = new Label();
        pictureBox2 = new PictureBox();
        lblSaved = new Label();
        pictureBox3 = new PictureBox();
        ((ISupportInitialize)pictureBox1).BeginInit();
        ((ISupportInitialize)pictureBox2).BeginInit();
        ((ISupportInitialize)pictureBox3).BeginInit();
        SuspendLayout();
        // 
        // btnSave
        // 
        btnSave.BackColor = Color.Black;
        btnSave.Font = new Font("Silkscreen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnSave.ForeColor = Color.Lime;
        btnSave.Location = new Point(631, 228);
        btnSave.Margin = new Padding(4, 5, 4, 5);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(109, 38);
        btnSave.TabIndex = 3;
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Click += btnSave_Click;
        // 
        // ExitButton
        // 
        ExitButton.BackColor = Color.Black;
        ExitButton.Font = new Font("Silkscreen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ExitButton.ForeColor = Color.Lime;
        ExitButton.Location = new Point(631, 427);
        ExitButton.Margin = new Padding(4, 5, 4, 5);
        ExitButton.Name = "ExitButton";
        ExitButton.Size = new Size(109, 38);
        ExitButton.TabIndex = 4;
        ExitButton.Text = "Exit";
        ExitButton.UseVisualStyleBackColor = false;
        ExitButton.Click += ExitButton_Click;
        // 
        // txtPostion
        // 
        txtPostion.BackColor = SystemColors.InactiveCaptionText;
        txtPostion.Font = new Font("Silkscreen", 12F, FontStyle.Bold);
        txtPostion.ForeColor = Color.Lime;
        txtPostion.Location = new Point(110, 228);
        txtPostion.Margin = new Padding(4, 5, 4, 5);
        txtPostion.Name = "txtPostion";
        txtPostion.Size = new Size(430, 31);
        txtPostion.TabIndex = 1;
        txtPostion.Text = "Position";
        txtPostion.KeyDown += txtPostion_KeyDown;
        // 
        // cmbDeparments
        // 
        cmbDeparments.BackColor = SystemColors.InactiveCaptionText;
        cmbDeparments.Font = new Font("Silkscreen", 12F, FontStyle.Bold);
        cmbDeparments.ForeColor = Color.Lime;
        cmbDeparments.FormattingEnabled = true;
        cmbDeparments.Location = new Point(110, 277);
        cmbDeparments.Margin = new Padding(4, 5, 4, 5);
        cmbDeparments.Name = "cmbDeparments";
        cmbDeparments.Size = new Size(430, 29);
        cmbDeparments.TabIndex = 2;
        cmbDeparments.Text = "Departrment";
        cmbDeparments.DropDown += cmbDeparments_DropDown;
        // 
        // pictureBox1
        // 
        pictureBox1.BackColor = Color.Lime;
        pictureBox1.Location = new Point(-503, 75);
        pictureBox1.Margin = new Padding(4, 5, 4, 5);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(806, 10);
        pictureBox1.TabIndex = 7;
        pictureBox1.TabStop = false;
        // 
        // label1
        // 
        label1.Font = new Font("Silkscreen", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        label1.ForeColor = Color.Lime;
        label1.Location = new Point(16, 35);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(506, 28);
        label1.TabIndex = 8;
        label1.Text = "Employee Positions";
        // 
        // pictureBox2
        // 
        pictureBox2.BackColor = Color.Lime;
        pictureBox2.Location = new Point(-390, 122);
        pictureBox2.Margin = new Padding(4, 5, 4, 5);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(1223, 10);
        pictureBox2.TabIndex = 7;
        pictureBox2.TabStop = false;
        // 
        // lblSaved
        // 
        lblSaved.AutoSize = true;
        lblSaved.Font = new Font("Silkscreen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblSaved.ForeColor = Color.Lime;
        lblSaved.Location = new Point(110, 337);
        lblSaved.Margin = new Padding(4, 0, 4, 0);
        lblSaved.Name = "lblSaved";
        lblSaved.Size = new Size(0, 21);
        lblSaved.TabIndex = 9;
        // 
        // pictureBox3
        // 
        pictureBox3.BackColor = Color.Lime;
        pictureBox3.Location = new Point(-409, 389);
        pictureBox3.Margin = new Padding(4, 5, 4, 5);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new Size(1223, 10);
        pictureBox3.TabIndex = 7;
        pictureBox3.TabStop = false;
        // 
        // FrmPosition
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(803, 503);
        Controls.Add(lblSaved);
        Controls.Add(label1);
        Controls.Add(pictureBox3);
        Controls.Add(pictureBox2);
        Controls.Add(pictureBox1);
        Controls.Add(cmbDeparments);
        Controls.Add(txtPostion);
        Controls.Add(ExitButton);
        Controls.Add(btnSave);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4, 5, 4, 5);
        Name = "FrmPosition";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Position";
        Load += FrmPosition_Load;
        ((ISupportInitialize)pictureBox1).EndInit();
        ((ISupportInitialize)pictureBox2).EndInit();
        ((ISupportInitialize)pictureBox3).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.TextBox txtPostion;

    private System.Windows.Forms.ComboBox cmbDeparments;

    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button ExitButton;

    #endregion

    private PictureBox pictureBox2;
    private Label lblSaved;
    private PictureBox pictureBox3;
}