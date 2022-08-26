using System;
using System.Linq;
using System.Windows.Forms;

namespace exam
{
  public partial class Form3 : Form
  {
    public Form3() {
      InitializeComponent();
      
    }   

    private void button1_Click(object sender, EventArgs e ) {
      //string firstName = textBox1.Text;
      //string lastName = textBox2.Text;
      //string login = textBox3.Text;
      //string password = textBox4.Text;

      //if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0) {
      //  button1.Enabled = false;
      //}
      //button1.Enabled = true;
      //var addSeller = new Sellers { FirstName = firstName, LastName = lastName, Login = login, Password = password };

      //  using (var db = new db_musicEntities1()) {
      //    var seller = db.Sellers.FirstOrDefault(x => x.Login == login && x.Password == password);
      //    if (seller != null) {
      //      MessageBox.Show("Yes User");
      //    } else {
      //      label5.Text = addSeller.Login;
      //      db.Sellers.Add(addSeller);
      //      db.SaveChanges();
      //      MessageBox.Show("add new Seller");
      //      Form3 form3 = new Form3();
      //      form3.Close();
      //      Form1 form1 = new Form1();
      //      form1.Focus();
      //    }
      //  }      
      
    }

    private void textBox1_TextChanged(object sender, EventArgs e) {

    }
  }
}
