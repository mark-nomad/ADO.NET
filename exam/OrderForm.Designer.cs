namespace exam
{
  partial class OrderForm
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
      this.components = new System.ComponentModel.Container();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.recordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.db_musicDataSet = new exam.db_musicDataSet();
      this.recordsTableAdapter = new exam.db_musicDataSetTableAdapters.RecordsTableAdapter();
      this.label3 = new System.Windows.Forms.Label();
      this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.comboBox2 = new System.Windows.Forms.ComboBox();
      this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dbmusicDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.customersTableAdapter = new exam.db_musicDataSetTableAdapters.CustomersTableAdapter();
      this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.salesTableAdapter = new exam.db_musicDataSetTableAdapters.SalesTableAdapter();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.comboBox3 = new System.Windows.Forms.ComboBox();
      this.label7 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.recordsBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.db_musicDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dbmusicDataSetBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.button1.Location = new System.Drawing.Point(53, 399);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "OK";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.button2.Location = new System.Drawing.Point(227, 399);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 1;
      this.button2.Text = "Cancel";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(45, 25);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(76, 29);
      this.label1.TabIndex = 2;
      this.label1.Text = "Order";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(47, 85);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(92, 16);
      this.label2.TabIndex = 3;
      this.label2.Text = "Record Name";
      // 
      // comboBox1
      // 
      this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.recordsBindingSource, "Id", true));
      this.comboBox1.DataSource = this.recordsBindingSource;
      this.comboBox1.DisplayMember = "RecordName";
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(222, 82);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(379, 24);
      this.comboBox1.TabIndex = 4;
      this.comboBox1.ValueMember = "Id";
      // 
      // recordsBindingSource
      // 
      this.recordsBindingSource.DataMember = "Records";
      this.recordsBindingSource.DataSource = this.db_musicDataSet;
      // 
      // db_musicDataSet
      // 
      this.db_musicDataSet.DataSetName = "db_musicDataSet";
      this.db_musicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // recordsTableAdapter
      // 
      this.recordsTableAdapter.ClearBeforeFill = true;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(47, 139);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(41, 16);
      this.label3.TabIndex = 5;
      this.label3.Text = "Price ";
      // 
      // numericUpDown2
      // 
      this.numericUpDown2.Location = new System.Drawing.Point(222, 190);
      this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown2.Name = "numericUpDown2";
      this.numericUpDown2.Size = new System.Drawing.Size(379, 22);
      this.numericUpDown2.TabIndex = 8;
      this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(47, 193);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(52, 16);
      this.label4.TabIndex = 7;
      this.label4.Text = "Amount";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(47, 247);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(64, 16);
      this.label5.TabIndex = 9;
      this.label5.Text = "Customer";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(47, 349);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(38, 16);
      this.label6.TabIndex = 11;
      this.label6.Text = "Total";
      // 
      // comboBox2
      // 
      this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customersBindingSource, "Id", true));
      this.comboBox2.DataSource = this.customersBindingSource;
      this.comboBox2.DisplayMember = "FirstName";
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Location = new System.Drawing.Point(222, 243);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new System.Drawing.Size(379, 24);
      this.comboBox2.TabIndex = 12;
      this.comboBox2.ValueMember = "Id";
      // 
      // customersBindingSource
      // 
      this.customersBindingSource.DataMember = "Customers";
      this.customersBindingSource.DataSource = this.dbmusicDataSetBindingSource;
      // 
      // dbmusicDataSetBindingSource
      // 
      this.dbmusicDataSetBindingSource.DataSource = this.db_musicDataSet;
      this.dbmusicDataSetBindingSource.Position = 0;
      // 
      // customersTableAdapter
      // 
      this.customersTableAdapter.ClearBeforeFill = true;
      // 
      // salesBindingSource
      // 
      this.salesBindingSource.DataMember = "Sales";
      this.salesBindingSource.DataSource = this.dbmusicDataSetBindingSource;
      // 
      // salesTableAdapter
      // 
      this.salesTableAdapter.ClearBeforeFill = true;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(222, 139);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(14, 16);
      this.label8.TabIndex = 15;
      this.label8.Text = "0";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(222, 349);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(14, 16);
      this.label9.TabIndex = 16;
      this.label9.Text = "0";
      // 
      // comboBox3
      // 
      this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesBindingSource, "Id", true));
      this.comboBox3.DataSource = this.salesBindingSource;
      this.comboBox3.DisplayMember = "Name";
      this.comboBox3.FormattingEnabled = true;
      this.comboBox3.Location = new System.Drawing.Point(222, 299);
      this.comboBox3.Name = "comboBox3";
      this.comboBox3.Size = new System.Drawing.Size(379, 24);
      this.comboBox3.TabIndex = 18;
      this.comboBox3.ValueMember = "Id";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(47, 303);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(46, 16);
      this.label7.TabIndex = 17;
      this.label7.Text = "акции";
      // 
      // OrderForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(731, 504);
      this.Controls.Add(this.comboBox3);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.comboBox2);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.numericUpDown2);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Name = "OrderForm";
      this.Text = "Оформление покупки";
      this.Load += new System.EventHandler(this.OrderForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.recordsBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.db_musicDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dbmusicDataSetBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private db_musicDataSet db_musicDataSet;
    private System.Windows.Forms.BindingSource recordsBindingSource;
    private db_musicDataSetTableAdapters.RecordsTableAdapter recordsTableAdapter;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.BindingSource dbmusicDataSetBindingSource;
    private System.Windows.Forms.BindingSource customersBindingSource;
    private db_musicDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
    private System.Windows.Forms.BindingSource salesBindingSource;
    private db_musicDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
    protected internal System.Windows.Forms.NumericUpDown numericUpDown2;
    protected internal System.Windows.Forms.ComboBox comboBox2;
    protected internal System.Windows.Forms.Label label8;
    protected internal System.Windows.Forms.Label label9;
    protected internal System.Windows.Forms.ComboBox comboBox3;
    private System.Windows.Forms.Label label7;
    protected internal System.Windows.Forms.ComboBox comboBox1;
  }
}