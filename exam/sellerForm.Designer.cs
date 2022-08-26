namespace exam
{
  partial class sellerForm
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
      this.label11 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label11.Location = new System.Drawing.Point(37, 187);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(98, 25);
      this.label11.TabIndex = 10;
      this.label11.Text = "Password";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label9.Location = new System.Drawing.Point(37, 134);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(60, 25);
      this.label9.TabIndex = 9;
      this.label9.Text = "Login";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label7.Location = new System.Drawing.Point(37, 93);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(101, 25);
      this.label7.TabIndex = 8;
      this.label7.Text = "LastName";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(37, 44);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(101, 25);
      this.label4.TabIndex = 7;
      this.label4.Text = "FirstName";
      // 
      // button2
      // 
      this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.button2.Location = new System.Drawing.Point(417, 294);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 12;
      this.button2.Text = "Cancel";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.button1.Location = new System.Drawing.Point(243, 294);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 11;
      this.button1.Text = "OK";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(243, 44);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(364, 22);
      this.textBox1.TabIndex = 13;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(243, 96);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(364, 22);
      this.textBox2.TabIndex = 14;
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(243, 138);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(364, 22);
      this.textBox3.TabIndex = 15;
      // 
      // textBox4
      // 
      this.textBox4.Location = new System.Drawing.Point(243, 191);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(364, 22);
      this.textBox4.TabIndex = 16;
      // 
      // sellerForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(771, 360);
      this.Controls.Add(this.textBox4);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label4);
      this.Name = "sellerForm";
      this.Text = "sellerForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label4;
    protected internal System.Windows.Forms.TextBox textBox1;
    protected internal System.Windows.Forms.TextBox textBox2;
    protected internal System.Windows.Forms.TextBox textBox3;
    protected internal System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
  }
}