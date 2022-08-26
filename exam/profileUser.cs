using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam
{
  public class profileUser
  {
    public static void Info(db_musicEntities1 db, Seller seller) {
      Form2 form2 = new Form2(seller);
      form2.label5.Text = seller.FirstName;
      form2.label6.Text = seller.LastName;
      form2.label8.Text = seller.Login;
      form2.label10.Text = seller.Password;
      decimal summ = db.Orders.Where(u => u.SellerId == seller.Id).Sum(u => (decimal)u.Price);
      form2.label12.Text = summ.ToString();

    }

    public static void selInfo(db_musicEntities1 db, Seller seller) {
      Form2 form2 = new Form2(seller);
      Sellers user = db.Sellers.Find(seller.Id);       
      form2.label5.Text = user.FirstName;
      form2.label6.Text = user.LastName;
      form2.label8.Text = user.Login;
      form2.label10.Text = user.Password;
    }


    public static void editInfo(db_musicEntities1 db, Seller seller) {
      Form2 form2 = new Form2(seller);
      Sellers user = db.Sellers.Find(seller.Id);
      sellerForm slForm = new sellerForm();
      slForm.textBox1.Text = user.FirstName;
      slForm.textBox2.Text = user.LastName;
      slForm.textBox3.Text = user.Login;
      slForm.textBox4.Text = user.Password;     

      DialogResult result = slForm.ShowDialog(form2);

      if (result == DialogResult.Cancel)
        return;
      user.FirstName = slForm.textBox1.Text;
      user.LastName = slForm.textBox2.Text;
      user.Login = slForm.textBox3.Text;
      user.Password = slForm.textBox4.Text;      
      db.SaveChanges();
      MessageBox.Show("Объект обновлен");
      selInfo(db, seller);



    }

    }
}
