namespace exam
{
  partial class CastomForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.button2 = new System.Windows.Forms.Button();
      this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.label9 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      this.SuspendLayout();
      // 
      // button2
      // 
      this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.button2.Location = new System.Drawing.Point(321, 397);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 44;
      this.button2.Text = "Cancel";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // numericUpDown3
      // 
      this.numericUpDown3.Location = new System.Drawing.Point(254, 231);
      this.numericUpDown3.Name = "numericUpDown3";
      this.numericUpDown3.ReadOnly = true;
      this.numericUpDown3.Size = new System.Drawing.Size(216, 22);
      this.numericUpDown3.TabIndex = 42;
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.DecimalPlaces = 4;
      this.numericUpDown1.Location = new System.Drawing.Point(254, 171);
      this.numericUpDown1.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.ReadOnly = true;
      this.numericUpDown1.Size = new System.Drawing.Size(216, 22);
      this.numericUpDown1.TabIndex = 41;
      this.numericUpDown1.ThousandsSeparator = true;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(127, 227);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(59, 16);
      this.label9.TabIndex = 37;
      this.label9.Text = "Discount";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(127, 173);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(65, 16);
      this.label6.TabIndex = 34;
      this.label6.Text = "TotalSum";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(127, 135);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(46, 16);
      this.label3.TabIndex = 33;
      this.label3.Text = "Phone";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(127, 84);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(69, 16);
      this.label2.TabIndex = 32;
      this.label2.Text = "LastName";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(127, 30);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(69, 16);
      this.label1.TabIndex = 31;
      this.label1.Text = "FirstName";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // button1
      // 
      this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.button1.Location = new System.Drawing.Point(117, 397);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 30;
      this.button1.Text = "OK";
      this.button1.UseVisualStyleBackColor = false;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(254, 85);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(216, 22);
      this.textBox2.TabIndex = 28;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(254, 31);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(216, 22);
      this.textBox1.TabIndex = 27;
      // 
      // maskedTextBox1
      // 
      this.maskedTextBox1.Location = new System.Drawing.Point(254, 133);
      this.maskedTextBox1.Mask = "+7(999) 000-0000";
      this.maskedTextBox1.Name = "maskedTextBox1";
      this.maskedTextBox1.Size = new System.Drawing.Size(216, 22);
      this.maskedTextBox1.TabIndex = 45;
      // 
      // CastomForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.maskedTextBox1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.numericUpDown3);
      this.Controls.Add(this.numericUpDown1);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Name = "CastomForm";
      this.Text = "CastomForm";
      this.Load += new System.EventHandler(this.CastomForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button button2;
    protected internal System.Windows.Forms.NumericUpDown numericUpDown3;
    protected internal System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    protected internal System.Windows.Forms.TextBox textBox2;
    protected internal System.Windows.Forms.TextBox textBox1;
    protected internal System.Windows.Forms.MaskedTextBox maskedTextBox1;
  }
}