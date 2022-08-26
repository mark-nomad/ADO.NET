using System;
using System.Linq;
using System.Windows.Forms;

namespace exam
{
  public partial class Form1 : Form
  {
    public Form1() {
      InitializeComponent();


     

    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      var User = new Seller();
      string login = textBox1.Text;
      string password = textBox2.Text;
      using (var db = new db_musicEntities1()) {
        var seller = db.Sellers.FirstOrDefault(x => x.Login == login && x.Password == password);

        if (seller != null) {
          User.Login = seller.Login;
          User.Id = seller.Id;
          User.FirstName = seller.FirstName;
          User.LastName = seller.LastName;
          User.Password = seller.Password;
          Form2 form2 = new Form2(User);
          form2.ShowDialog();

          Form1 form1 = new Form1();
          form1.Close();


          textBox1.Clear();
          textBox2.Clear();

        } else {
          MessageBox.Show("No User");
        }
      }

    }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {       
      Form3 addUser = new Form3();
      
      DialogResult result = addUser.ShowDialog(this);
      if (result == DialogResult.Cancel)
        return;

      if (String.IsNullOrWhiteSpace(addUser.textBox1.Text) ||
        String.IsNullOrWhiteSpace(addUser.textBox2.Text)||
        String.IsNullOrWhiteSpace(addUser.textBox3.Text) ||
        String.IsNullOrWhiteSpace(addUser.textBox4.Text) ) {
        addUser.button1.Enabled = false;        
      }else 
      { addUser.button1.Enabled = true; }

      Sellers seller = new Sellers();
      seller.FirstName = addUser.textBox1.Text;
      seller.LastName = addUser.textBox2.Text;
      seller.Login = addUser.textBox3.Text;
      seller.Password = addUser.textBox4.Text;

      
        using (var db = new db_musicEntities1()) {
        var find = db.Sellers.FirstOrDefault(x => x.Login == seller.Login && x.Password == seller.Password);
        if (find != null) {
          MessageBox.Show("Такой пользователь есть - " + seller.Login);
        } else {          
          db.Sellers.Add(seller);
          db.SaveChanges();
          MessageBox.Show("add new пользователь " + seller.Login);          
        }
      }   
    }
  }
}
