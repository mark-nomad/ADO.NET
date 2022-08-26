using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace exam
{
  public partial class Form2 : Form
  {
    db_musicEntities1 db;


    public Seller Seller { get; set; }
    public Form2(Seller seller) {
      this.Seller = seller;
      InitializeComponent();
      db = new db_musicEntities1();
      
      var stoks = db.Records.Join(db.Genres,
        u => u.GenreId,
        c => c.Id,
        (u, c) => new {
          Id = u.Id,
          DateAdd = u.DateAdd,
          RecordName = u.RecordName,
          PublisherName = u.PublisherName,
          CountTracks = u.CountTracks,
          Genre = c.GenreName,
          Year = u.Year,
          CostPrice = u.CostPrice,
          SellPrice = u.SellPrice,
          RecordsCount = u.RecordsCount,
        }).ToList();
      dataGridView1.DataSource = stoks;

      var records = db.Records.ToList<Records>();
      //dataGridView1.DataSource = records;
      dataGridView1.Refresh();

      var genres = db.Genres.ToList<Genres>();
      dataGridView4.DataSource = genres;
      dataGridView4.Refresh();


      var costomers = db.Customers.ToList<Customers>();
      dataGridView3.DataSource = costomers;
      dataGridView3.Refresh();

      var orders = db.Orders.Where(u => u.SellerId == seller.Id).ToList<Orders>();
      
      var orderRecorName = orders.Join(db.Records,
        u => u.RecordId,
        c => c.Id,
        (u, c) => new {
          Id = u.Id,
          CreatedAt = u.CreatedAt,
          RecordName = c.RecordName,
          ProductCount = u.ProductCount,
          CustomerId = u.CustomerId,
          SaleId = u.SaleId,
          Price = u.Price,
        }).ToList();
      var orderCustomerName = orderRecorName.Join(
        db.Customers,
        u => u.CustomerId,
        c=>c.Id,
        (u, c) => new {
          Id = u.Id,
          CreatedAt = u.CreatedAt,
          RecordName = u.RecordName,
          ProductCount = u.ProductCount,
          CustomerFirstName = c.FirstName,
          CustomerLastName = c.LastName,
          SaleId = u.SaleId,
          Price = u.Price,
        }).ToList();
      var orderSaleName = orderCustomerName.Join(
        db.Sales,
        u=>u.SaleId,
        c=>c.Id,
         (u, c) => new {
           Id = u.Id,
           CreatedAt = u.CreatedAt,
           RecordName = u.RecordName,
           ProductCount = u.ProductCount,
           CustomerFirstName = u.CustomerFirstName,
           CustomerLastName = u.CustomerLastName,
           SaleName = c.Name,
           Price = u.Price,
         }).ToList();
      dataGridView5.DataSource = orderSaleName;

      //profileUser.Info(db, Seller);
      //profileUser.selInfo(db, Seller);
      label5.Text = seller.FirstName;
      label6.Text = seller.LastName;
      label8.Text = seller.Login;
      label10.Text = seller.Password;
      decimal summ = db.Orders.Where(u => u.SellerId == seller.Id).Sum(u => (decimal)u.Price);
      label12.Text = summ.ToString();
    }

    private void ToolStripMenuItem_Click(object sender, EventArgs e) {

    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {

    }

    private void label1_Click(object sender, EventArgs e) {

    }

    private void Form2_Load(object sender, EventArgs e) {
      // TODO: данная строка кода позволяет загрузить данные в таблицу "db_musicDataSet.Genres". При необходимости она может быть перемещена или удалена.
      this.genresTableAdapter.Fill(this.db_musicDataSet.Genres);
      label2.Text = Seller.FirstName;
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

    }

    private void button2_Click(object sender, EventArgs e) {

    }

    private void tabPage5_Click(object sender, EventArgs e) {

    }

    private void tabPage4_Click(object sender, EventArgs e) {

    }


    // добавление Records
    private void button2_Click_1(object sender, EventArgs e) {
      createRecord.addRecord(db, Seller);
      dataGridView1.Refresh(); // обновляем грид    
    }

    // редактирование Records
    private void button4_Click(object sender, EventArgs e) {
      //createRecord.editRecord(db, Seller);
      if ( dataGridView1.SelectedRows.Count > 0) {
        int index =  dataGridView1.SelectedRows[0].Index;
        int id = 0;
        bool converted = Int32.TryParse( dataGridView1[0, index].Value.ToString(), out id);
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


        DialogResult result = plForm.ShowDialog(this);

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
         dataGridView1.Refresh(); // обновляем грид
      }


      dataGridView1.Refresh();
    }
    // удаление Records
    private void button3_Click(object sender, EventArgs e) {
      //createRecord.deleteRecord(db, Seller);

      if ( dataGridView1.SelectedRows.Count > 0) {
        int index =  dataGridView1.SelectedRows[0].Index;
        int id = 0;
        bool converted = Int32.TryParse( dataGridView1[0, index].Value.ToString(), out id);
        if (converted == false)
          return;

        Records record = db.Records.Find(id);
        db.Records.Remove(record);
        db.SaveChanges();
        MessageBox.Show("Объект удален");
         dataGridView1.Refresh(); // обновляем грид 
      }

    }
    
    
    //top list
    private void button1_Click(object sender, EventArgs e) {
      //topList.selectTop(db, Seller);
      //label3.Text = comboBox1.SelectedIndex.ToString();
      dataGridView2.DataSource = null;

      int top = comboBox1.SelectedIndex;
      if (top != -1) {
        if (top == 0) {
          //0 TOP новинок
          var result = db.Records.OrderBy(p => p.DateAdd == DateTime.Now).ToList<Records>().Take(10);
          dataGridView2.DataSource = result;
        } else if (top == 1) {              
          var TopSellsDay = db.Orders
            .Where(u => u.CreatedAt == DateTime.Now)
            .Join(db.Records,
                   u => u.RecordId,
                   c => c.Id,
                   (u, c) => new {
                     CreatedAt = u.CreatedAt,
                     RecordName = c.RecordName,
                     Year = c.Year,
                     ProductCount = u.ProductCount,
                   })
            .GroupBy(u => u.RecordName)
            .ToList();         

          dataGridView2.DataSource = TopSellsDay;          
        } else if (top == 2) { }
      } else {
        MessageBox.Show("Selected top ");
      }
    }

    private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e) {


    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

    }
    //add Customerses
    private void button7_Click(object sender, EventArgs e) {
      createCustomers.addCustomer(db, Seller);
    }

    //edit Costomer
    private void button5_Click(object sender, EventArgs e) {
      //createCustomers.editCustomer(db, Seller);

      if (dataGridView3.SelectedRows.Count > 0) {
        int index = dataGridView3.SelectedRows[0].Index;
        int id = 0;
        bool converted = Int32.TryParse(dataGridView3[0, index].Value.ToString(), out id);
        if (converted == false)
          return;
        Customers customer = db.Customers.Find(id);
        CastomForm csForm = new CastomForm();
        csForm.textBox1.Text = customer.FirstName;
        csForm.textBox2.Text = customer.LastName;
        csForm.maskedTextBox1.Text = customer.Phone;
        csForm.numericUpDown1.Value = (decimal)customer.TotalSum;
        csForm.numericUpDown3.Value = (int)customer.Discount;



        DialogResult result = csForm.ShowDialog(this);

        if (result == DialogResult.Cancel)
          return;
        customer.FirstName = csForm.textBox1.Text;
        customer.LastName = csForm.textBox2.Text;
        customer.Phone = csForm.maskedTextBox1.Text;
        customer.TotalSum = (decimal)csForm.numericUpDown1.Value;
        customer.Discount = (int)csForm.numericUpDown3.Value;

        db.SaveChanges();
        dataGridView3.Refresh();// обновляем грид
        MessageBox.Show("Объект обновлен");

      }

    }
    //remove Costomer 
    private void button6_Click(object sender, EventArgs e) {
      //createCustomers.deleteCustomer(db, Seller);

      if (dataGridView3.SelectedRows.Count > 0) {
        int index = dataGridView3.SelectedRows[0].Index;
        int id = 0;
        bool converted = Int32.TryParse(dataGridView3[0, index].Value.ToString(), out id);
        if (converted == false)
          return;
        Customers customer = db.Customers.Find(id);
        db.Customers.Remove(customer);
        db.SaveChanges();
        dataGridView3.Refresh(); // обновляем грид
        MessageBox.Show("Объект удален");

      }

    }


    //add Genres
    private void button10_Click(object sender, EventArgs e) {
      createGenres.addGenres(db, Seller);
    }

    //edit Genres
    private void button8_Click(object sender, EventArgs e) {
      //createGenres.editGenres(db, Seller);

      if (dataGridView4.SelectedRows.Count > 0) {
        int index = dataGridView4.SelectedRows[0].Index;
        int id = 0;
        bool converted = Int32.TryParse(dataGridView4[0, index].Value.ToString(), out id);
        if (converted == false)
          return;

        Genres genre = db.Genres.Find(id);
        GenreForm grForm = new GenreForm();
        grForm.textBox1.Text = genre.GenreName;

        DialogResult result = grForm.ShowDialog(this);

        if (result == DialogResult.Cancel)
          return;

        genre.GenreName = grForm.textBox1.Text;
        db.SaveChanges();
        dataGridView4.Refresh();// обновляем грид
        MessageBox.Show("Genre обновлен");

      }

    }
    //delete Genres
    private void button9_Click(object sender, EventArgs e) {
      createGenres.removeGenres(db, Seller);
    }

    private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e) {
     
    }
    // добавление Order
    private void button13_Click(object sender, EventArgs e) {
      createOrder.addOrder(db,Seller);     
    }
    private void button11_Click(object sender, EventArgs e) {
      //createOrder.editOrder(db, Seller);

      if (dataGridView5.SelectedRows.Count > 0) {
        int index = dataGridView5.SelectedRows[0].Index;
        int id = 0;
        bool converted = Int32.TryParse(dataGridView5[0, index].Value.ToString(), out id);
        if (converted == false)
          return;
        Orders order = db.Orders.Find(id);
        OrderForm orderForm = new OrderForm();
        orderForm.comboBox1.DisplayMember = "RecordName";
        orderForm.numericUpDown2.Value = (int)order.ProductCount;
        orderForm.comboBox2.DisplayMember = "FirstName";
        orderForm.comboBox3.DisplayMember = "Name";


        DialogResult result = orderForm.ShowDialog(this);

        if (result == DialogResult.Cancel)
          return;

        order.RecordId = orderForm.comboBox1.SelectedIndex;
        order.ProductCount = (int)orderForm.numericUpDown2.Value;
        order.CustomerId = orderForm.comboBox2.SelectedIndex;
        order.SaleId = orderForm.comboBox3.SelectedIndex;
        db.Orders.Add(order);

        db.SaveChanges();
        dataGridView5.Refresh();// обновляем грид
        MessageBox.Show("Объект обновлен");
      }

    }
    private void button12_Click(object sender, EventArgs e) {
      //createOrder.removeOrder(db, Seller);      
      if (dataGridView5.SelectedRows.Count > 0) {
        int index = dataGridView5.SelectedRows[0].Index;
        int id = 0;
        bool converted = Int32.TryParse(dataGridView5[0, index].Value.ToString(), out id);
        if (converted == false)
          return;
        Orders order = db.Orders.Find(id);
        db.Orders.Remove(order);
        db.SaveChanges();
        dataGridView5.Refresh(); // обновляем грид
        MessageBox.Show("Объект удален");
      }

    }

    private void button14_Click(object sender, EventArgs e) {
      profileUser.editInfo(db, Seller);
    }

   
  }
}
