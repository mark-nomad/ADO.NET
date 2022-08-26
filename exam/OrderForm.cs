using System;
using System.Windows.Forms;

namespace exam
{
  public partial class OrderForm : Form
  {
    public OrderForm() {
      InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e) {

    }

    private void OrderForm_Load(object sender, EventArgs e) {
      // TODO: данная строка кода позволяет загрузить данные в таблицу "db_musicDataSet.Sales". При необходимости она может быть перемещена или удалена.
      this.salesTableAdapter.Fill(this.db_musicDataSet.Sales);
      // TODO: данная строка кода позволяет загрузить данные в таблицу "db_musicDataSet.Customers". При необходимости она может быть перемещена или удалена.
      this.customersTableAdapter.Fill(this.db_musicDataSet.Customers);
      // TODO: данная строка кода позволяет загрузить данные в таблицу "db_musicDataSet.Records". При необходимости она может быть перемещена или удалена.
      this.recordsTableAdapter.Fill(this.db_musicDataSet.Records);

    }

    private void button3_Click(object sender, EventArgs e) {

    }
  }
}
