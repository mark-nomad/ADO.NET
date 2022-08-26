using System;
using System.Linq;
using System.Windows.Forms;

namespace exam
{
  public class createOrder
  {
    public static void addOrder(db_musicEntities1 db, Seller seller) {
      
      Form2 form2 = new Form2(seller);

      OrderForm orderForm = new OrderForm();
      DialogResult result = orderForm.ShowDialog(form2);
      if (result == DialogResult.Cancel)
        return;
      Orders order = new Orders();     
      order.SellerId = seller.Id;
      order.CreatedAt = DateTime.Now;            
      order.RecordId = orderForm.comboBox1.SelectedIndex;
      Records records = db.Records.Find(order.RecordId);
     
      decimal price = (decimal)records.SellPrice;
      orderForm.label8.Text = price.ToString(); 
      
      //int kolvo = (int)orderForm.numericUpDown2.Value;
      //  int oldProdano = (int)records.Prodano;
      //  int newProdano = kolvo + oldProdano;

        order.ProductCount = (int)orderForm.numericUpDown2.Value;
     
        if (orderForm.comboBox2.SelectedIndex == -1)
          return;
        order.CustomerId = orderForm.comboBox2.SelectedIndex;
        Customers customer = db.Customers.Find(order.CustomerId);
      decimal discount = 0;
      if (order.CustomerId == 1) { discount = 0; }
      discount = (decimal)customer.Discount;

      //order.SaleId = orderForm.comboBox3.SelectedIndex;
      // Sales sales = db.Sales.Find(order.SaleId);
      //int saldiscount = (int)sales.Discount;
      decimal total = price * (int)orderForm.numericUpDown2.Value;
        decimal summ = (total) - (total * discount / 100);
        orderForm.label8.Text = summ.ToString();
        order.SaleId = orderForm.comboBox3.SelectedIndex;
        order.Price = summ;
        db.Orders.Add(order);
        db.SaveChanges();
        form2.dataGridView5.Refresh();
        MessageBox.Show("Новый order добавлен");
    } 

    public static void editOrder(db_musicEntities1 db, Seller seller) {  
      Form2 form2 = new Form2(seller);
      if (form2.dataGridView5.SelectedRows.Count > 0) {
        int index = form2.dataGridView5.SelectedRows[0].Index;
        int id = 0;
        bool converted = Int32.TryParse(form2.dataGridView5[0, index].Value.ToString(), out id);
        if (converted == false)
          return;
        Orders order = db.Orders.Find(id);
        OrderForm orderForm = new OrderForm();
        orderForm.comboBox1.DisplayMember = "RecordName";
        orderForm.numericUpDown2.Value = (int)order.ProductCount;
        orderForm.comboBox2.DisplayMember = "FirstName";
        orderForm.comboBox3.DisplayMember = "Name";


        DialogResult result = orderForm.ShowDialog(form2);

        if (result == DialogResult.Cancel)
          return;

        order.RecordId = orderForm.comboBox1.SelectedIndex;
        order.ProductCount =(int)orderForm.numericUpDown2.Value;
        order.CustomerId = orderForm.comboBox2.SelectedIndex;
        order.SaleId = orderForm.comboBox3.SelectedIndex;
                
        db.SaveChanges();
        form2.dataGridView5.Refresh();// обновляем грид
        MessageBox.Show("Объект обновлен");

      }

    }


    public static void removeOrder(db_musicEntities1 db, Seller seller) {
      Form2 form2 = new Form2(seller);
      if (form2.dataGridView5.SelectedRows.Count > 0) {
        int index = form2.dataGridView5.SelectedRows[0].Index;
        int id = 0;
        bool converted = Int32.TryParse(form2.dataGridView5[0, index].Value.ToString(), out id);
        if (converted == false)
          return;
        Orders order = db.Orders.Find(id);
        db.Orders.Remove(order);
        db.SaveChanges();
        form2.dataGridView5.Refresh(); // обновляем грид
        MessageBox.Show("Объект удален");

      }

    }



  }
}
