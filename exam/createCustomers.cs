using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam
{
  public class createCustomers
  {
    public static void addCustomer(db_musicEntities1 db, Seller seller) {
      Form2 form2 = new Form2(seller);
      CastomForm csForm = new CastomForm();
      DialogResult result = csForm.ShowDialog(form2);
      if (result == DialogResult.Cancel)
        return;
      Customers customer = new Customers();
      customer.FirstName = csForm.textBox1.Text;
      customer.LastName = csForm.textBox2.Text;
      customer.Phone = csForm.maskedTextBox1.Text;
      customer.TotalSum = (decimal)csForm.numericUpDown1.Value;
      customer.Discount = (int)csForm.numericUpDown3.Value;


      db.Customers.Add(customer);
      db.SaveChanges();
      form2.dataGridView3.Refresh(); // обновляем грид
      MessageBox.Show("Новый объект добавлен");
    }

    public static void editCustomer(db_musicEntities1 db, Seller seller) {
      Form2 form2 = new Form2(seller);
      if (form2.dataGridView3.SelectedRows.Count > 0) {
        int index = form2.dataGridView3.SelectedRows[0].Index;
        int id = 0;
        bool converted = Int32.TryParse(form2.dataGridView3[0, index].Value.ToString(), out id);
        if (converted == false)
          return;
        Customers customer = db.Customers.Find(id);
        CastomForm csForm = new CastomForm();
        csForm.textBox1.Text = customer.FirstName;
        csForm.textBox2.Text = customer.LastName;
        csForm.maskedTextBox1.Text = customer.Phone;
        csForm.numericUpDown1.Value = (decimal)customer.TotalSum;
        csForm.numericUpDown3.Value = (int)customer.Discount;



        DialogResult result = csForm.ShowDialog(form2);

        if (result == DialogResult.Cancel)
          return;
        customer.FirstName = csForm.textBox1.Text;
        customer.LastName = csForm.textBox2.Text;
        customer.Phone = csForm.maskedTextBox1.Text;
        customer.TotalSum = (decimal)csForm.numericUpDown1.Value;
        customer.Discount = (int)csForm.numericUpDown3.Value;

        db.SaveChanges();
        form2.dataGridView3.Refresh();// обновляем грид
        MessageBox.Show("Объект обновлен");

      }
    }

    public static void deleteCustomer(db_musicEntities1 db, Seller seller) { 
      Form2 form2 = new Form2(seller);
      if (form2.dataGridView3.SelectedRows.Count > 0) {
        int index = form2.dataGridView3.SelectedRows[0].Index;
        int id = 0;
        bool converted = Int32.TryParse(form2.dataGridView3[0, index].Value.ToString(), out id);
        if (converted == false)
          return;
        Customers customer = db.Customers.Find(id);
        db.Customers.Remove(customer);
        db.SaveChanges();
        form2.dataGridView3.Refresh(); // обновляем грид
        MessageBox.Show("Объект удален");

      }

    }



  }
}
