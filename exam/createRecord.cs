using System;
using System.Windows.Forms;

namespace exam
{
  public class createRecord
  {

    public static void addRecord(db_musicEntities1 db, Seller seller) {

      Form2 form2 = new Form2(seller);
      RecordForm plForm = new RecordForm();
      DialogResult result = plForm.ShowDialog(form2);
      if (result == DialogResult.Cancel)
        return;
      Records record = new Records();
      record.RecordName = plForm.textBox1.Text;
      record.TeamdName = plForm.textBox2.Text;
      record.PublisherName = plForm.textBox2.Text;
      record.CountTracks = (int)plForm.numericUpDown1.Value;
      //record.DateAdd = new DateTime();
      record.GenreId = plForm.comboBox1.SelectedIndex;
      record.Year = (int)plForm.numericUpDown2.Value;
      record.CostPrice = (decimal)plForm.numericUpDown3.Value;
      record.SellPrice = (decimal)plForm.numericUpDown4.Value;
      record.RecordsCount = (int)plForm.numericUpDown5.Value;
      db.Records.Add(record);
      db.SaveChanges();
      MessageBox.Show("Новый Record добавлен");
    }

    public static void editRecord(db_musicEntities1 db, Seller seller) {
      Form2 form2 = new Form2(seller);
      
      if (form2.dataGridView1.SelectedRows.Count > 0) {
        int index = form2.dataGridView1.SelectedRows[0].Index;
        int id = 0;
        bool converted = Int32.TryParse(form2.dataGridView1[0, index].Value.ToString(), out id);
        if (converted == false)
          return;

        Records record = db.Records.Find(id);
        RecordForm plForm = new RecordForm();
        plForm.textBox1.Text = record.RecordName;
        plForm.textBox2.Text = record.TeamdName;
        plForm.textBox3.Text = record.PublisherName;
        plForm.numericUpDown1.Value = (int)record.CountTracks;
        plForm.comboBox1.DisplayMember = "GenreName";
        //plForm.comboBox1.SelectedIndex = (int)record.GenreId;

        plForm.numericUpDown2.Value = (int)record.Year;
        plForm.numericUpDown3.Value = (decimal)record.CostPrice;
        plForm.numericUpDown4.Value = (decimal)record.SellPrice;
        plForm.numericUpDown5.Value = (int)record.RecordsCount;


        DialogResult result = plForm.ShowDialog(form2);

        if (result == DialogResult.Cancel)
          return;

        record.RecordName = plForm.textBox1.Text;
        record.TeamdName = plForm.textBox2.Text;
        record.PublisherName = plForm.textBox3.Text;
        record.CountTracks = (int)plForm.numericUpDown1.Value;
        //record.DateAdd = new DateTime();
        record.GenreId = plForm.comboBox1.SelectedIndex;
        record.Year = (int)plForm.numericUpDown2.Value;
        record.CostPrice = (decimal)plForm.numericUpDown3.Value;
        record.SellPrice = (decimal)plForm.numericUpDown4.Value;
        record.RecordsCount = (int)plForm.numericUpDown5.Value;

        db.SaveChanges();
        MessageBox.Show("Record обновлен");
        form2.dataGridView1.Refresh(); // обновляем грид
      }
    }
    public static void deleteRecord(db_musicEntities1 db, Seller seller) {
      Form2 form2 = new Form2(seller);

      if (form2.dataGridView1.SelectedRows.Count > 0) {
        int index = form2.dataGridView1.SelectedRows[0].Index;
        int id = 0;
        bool converted = Int32.TryParse(form2.dataGridView1[0, index].Value.ToString(), out id);
        if (converted == false)
          return;

        Records record = db.Records.Find(id);
        db.Records.Remove(record);
        db.SaveChanges();
        MessageBox.Show("Объект удален");
        form2.dataGridView1.Refresh(); // обновляем грид 
      }
    }
    
}
}
