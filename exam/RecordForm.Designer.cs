﻿namespace exam
{
  partial class RecordForm
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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.db_musicDataSet = new exam.db_musicDataSet();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
      this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
      this.button2 = new System.Windows.Forms.Button();
      this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
      this.genresTableAdapter = new exam.db_musicDataSetTableAdapters.GenresTableAdapter();
      this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
      this.label10 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.db_musicDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(262, 69);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(397, 22);
      this.textBox1.TabIndex = 0;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(262, 120);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(397, 22);
      this.textBox2.TabIndex = 1;
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(262, 171);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(397, 22);
      this.textBox3.TabIndex = 2;
      // 
      // button1
      // 
      this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.button1.Location = new System.Drawing.Point(128, 573);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 9;
      this.button1.Text = "OK";
      this.button1.UseVisualStyleBackColor = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(51, 71);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(187, 20);
      this.label1.TabIndex = 10;
      this.label1.Text = "Название Пластинки";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(51, 122);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(194, 20);
      this.label2.TabIndex = 11;
      this.label2.Text = "Название коллектива";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(51, 173);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(177, 20);
      this.label3.TabIndex = 12;
      this.label3.Text = "Название издателя";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(51, 326);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(117, 20);
      this.label4.TabIndex = 15;
      this.label4.Text = "Год издания";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(51, 275);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(53, 20);
      this.label5.TabIndex = 14;
      this.label5.Text = "Жанр";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label7.Location = new System.Drawing.Point(51, 479);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(205, 20);
      this.label7.TabIndex = 18;
      this.label7.Text = "Количество Пластинок";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label8.Location = new System.Drawing.Point(51, 428);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(131, 20);
      this.label8.TabIndex = 17;
      this.label8.Text = "Цена продажи";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label9.Location = new System.Drawing.Point(51, 377);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(141, 20);
      this.label9.TabIndex = 16;
      this.label9.Text = "Себестоимость";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.Location = new System.Drawing.Point(51, 224);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(173, 20);
      this.label6.TabIndex = 13;
      this.label6.Text = "Количество треков";
      // 
      // comboBox1
      // 
      this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.genresBindingSource, "Id", true));
      this.comboBox1.DataSource = this.genresBindingSource;
      this.comboBox1.DisplayMember = "GenreName";
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(262, 271);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(397, 24);
      this.comboBox1.TabIndex = 19;
      this.comboBox1.ValueMember = "Id";
      // 
      // genresBindingSource
      // 
      this.genresBindingSource.DataMember = "Genres";
      this.genresBindingSource.DataSource = this.db_musicDataSet;
      // 
      // db_musicDataSet
      // 
      this.db_musicDataSet.DataSetName = "db_musicDataSet";
      this.db_musicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.Location = new System.Drawing.Point(262, 222);
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(397, 22);
      this.numericUpDown1.TabIndex = 20;
      // 
      // numericUpDown3
      // 
      this.numericUpDown3.DecimalPlaces = 4;
      this.numericUpDown3.Location = new System.Drawing.Point(262, 375);
      this.numericUpDown3.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
      this.numericUpDown3.Name = "numericUpDown3";
      this.numericUpDown3.Size = new System.Drawing.Size(397, 22);
      this.numericUpDown3.TabIndex = 22;
      // 
      // numericUpDown4
      // 
      this.numericUpDown4.DecimalPlaces = 4;
      this.numericUpDown4.Location = new System.Drawing.Point(262, 426);
      this.numericUpDown4.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
      this.numericUpDown4.Name = "numericUpDown4";
      this.numericUpDown4.Size = new System.Drawing.Size(397, 22);
      this.numericUpDown4.TabIndex = 23;
      // 
      // button2
      // 
      this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.button2.Location = new System.Drawing.Point(404, 573);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 24;
      this.button2.Text = "Cancel";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // numericUpDown5
      // 
      this.numericUpDown5.Location = new System.Drawing.Point(262, 477);
      this.numericUpDown5.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.numericUpDown5.Name = "numericUpDown5";
      this.numericUpDown5.Size = new System.Drawing.Size(397, 22);
      this.numericUpDown5.TabIndex = 25;
      this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
      // 
      // genresTableAdapter
      // 
      this.genresTableAdapter.ClearBeforeFill = true;
      // 
      // numericUpDown2
      // 
      this.numericUpDown2.Location = new System.Drawing.Point(262, 324);
      this.numericUpDown2.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
      this.numericUpDown2.Name = "numericUpDown2";
      this.numericUpDown2.Size = new System.Drawing.Size(397, 22);
      this.numericUpDown2.TabIndex = 26;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label10.Location = new System.Drawing.Point(13, 9);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(488, 29);
      this.label10.TabIndex = 27;
      this.label10.Text = "Добавление / редактирование Пластинки";
      this.label10.Click += new System.EventHandler(this.label10_Click);
      // 
      // RecordForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(677, 648);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.numericUpDown2);
      this.Controls.Add(this.numericUpDown5);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.numericUpDown4);
      this.Controls.Add(this.numericUpDown3);
      this.Controls.Add(this.numericUpDown1);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Name = "RecordForm";
      this.Text = "Record Form";
      this.Load += new System.EventHandler(this.RecordForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.db_musicDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button button2;
    protected internal System.Windows.Forms.TextBox textBox1;
    protected internal System.Windows.Forms.TextBox textBox2;
    protected internal System.Windows.Forms.TextBox textBox3;
    protected internal System.Windows.Forms.ComboBox comboBox1;
    protected internal System.Windows.Forms.NumericUpDown numericUpDown1;
    protected internal System.Windows.Forms.NumericUpDown numericUpDown3;
    protected internal System.Windows.Forms.NumericUpDown numericUpDown4;
    protected internal System.Windows.Forms.NumericUpDown numericUpDown5;
    private db_musicDataSet db_musicDataSet;
    private System.Windows.Forms.BindingSource genresBindingSource;
    private db_musicDataSetTableAdapters.GenresTableAdapter genresTableAdapter;
    protected internal System.Windows.Forms.NumericUpDown numericUpDown2;
    private System.Windows.Forms.Label label10;
  }
}