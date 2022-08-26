using System;
using System.Windows.Forms;

namespace exam
{
  public partial class RecordForm : Form
  {
    public RecordForm() {
      InitializeComponent();
    }

    private void numericUpDown5_ValueChanged(object sender, EventArgs e) {

    }

    private void RecordForm_Load(object sender, EventArgs e) {
      // TODO: данная строка кода позволяет загрузить данные в таблицу "db_musicDataSet.Genres". При необходимости она может быть перемещена или удалена.
      this.genresTableAdapter.Fill(this.db_musicDataSet.Genres);

    }

    private void label10_Click(object sender, EventArgs e) {

    }

    private void label1_Click(object sender, EventArgs e) {

    }
  }
}
