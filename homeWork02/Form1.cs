using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace homeWork02
{
  public partial class Form1 : Form
  {
    DbConnection conn = null;
    DbProviderFactory factory = null;
    string providerName = "";
    public Form1() {
      InitializeComponent();
      button2.Enabled = false;
      button3.Enabled = false;
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
      textBox1.Clear();
      ;
      factory = DbProviderFactories.GetFactory(comboBox1.SelectedItem.ToString());
      conn = factory.CreateConnection();
      providerName = GetConnectionStringByProvider(comboBox1.SelectedItem.ToString());
      textBox1.Text = providerName;
    }

    static string GetConnectionStringByProvider(string providerName) {
      string returnValue = null;
      ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;

      if (settings != null) {
        foreach (ConnectionStringSettings cs in settings) {
          if (cs.ProviderName == providerName) {
            returnValue = cs.ConnectionString;
            break;
          }
        }
      }
      return returnValue;
    }
    private void Form1_Load(object sender, EventArgs e) {

    }

    private void button1_Click(object sender, EventArgs e) {
      DataTable t = DbProviderFactories.GetFactoryClasses();
      dataGridView1.DataSource = t;
      comboBox1.Items.Clear();
      foreach (DataRow dr in t.Rows) {
        comboBox1.Items.Add(dr["InvariantName"]);
      }
      textBox1.Clear();
    }

    private void button2_Click(object sender, EventArgs e) {
      System.Diagnostics.Stopwatch st = new System.Diagnostics.Stopwatch();
      st.Start();

      conn.ConnectionString = textBox1.Text;
      DbDataAdapter adapter = factory.CreateDataAdapter();
      adapter.SelectCommand = conn.CreateCommand();
      adapter.SelectCommand.CommandText = textBox2.Text.ToString();
      DataTable table = new DataTable();
      adapter.Fill(table);

      dataGridView1.DataSource = null;
      dataGridView1.DataSource = table;
      conn.Close();
      st.Stop();
      long ms = st.ElapsedMilliseconds; // прошедшее время в миллисекундах
      textBox3.Text = ms.ToString();
    }

    private void textBox2_TextChanged(object sender, EventArgs e) {
      if (textBox2.Text.Length > 5) {
        button2.Enabled = true;
        button3.Enabled = true;
      } else {
        button2.Enabled = false;
        button3.Enabled = false;
      }
    }

    private void textBox1_TextChanged(object sender, EventArgs e) {
      textBox2.Clear();
      textBox3.Clear();
    }

    private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {

    }

    private void textBox3_TextChanged(object sender, EventArgs e) {


    }

    private void label4_Click(object sender, EventArgs e) {

    }

    private async void button3_Click(object sender, EventArgs e) {
      System.Diagnostics.Stopwatch st = new System.Diagnostics.Stopwatch();
      st.Start();

      conn.ConnectionString = textBox1.Text;
      await conn.OpenAsync();
      DbCommand comm = conn.CreateCommand();
      comm.CommandText = "WAITFOR DELAY '00:00:05'; ";
      comm.CommandText += textBox2.Text.ToString();
      //string sqlExpression = "SELECT * FROM Stuffs";  
      //comm.CommandText += sqlExpression;
      DataTable table = new DataTable();
      using (DbDataReader reader = await comm.ExecuteReaderAsync()) {
        int line = 0;
        do {
          while (await reader.ReadAsync()) {
            if (line == 0) {
              for (int i = 0; i < reader.FieldCount; i++) {
                table.Columns.Add(reader.GetName(i));
              }
              line++;
            }
            DataRow row = table.NewRow();
            for (int i = 0; i < reader.FieldCount; i++) {
              row[i] = await reader.GetFieldValueAsync<Object>(i);
            }
            table.Rows.Add(row);
          }
        } while (reader.NextResult());
      }
      conn.Close();
      dataGridView1.DataSource = null;
      dataGridView1.DataSource = table;

      st.Stop();
      long ms = st.ElapsedMilliseconds; // прошедшее время в миллисекундах
      textBox3.Text = (ms - 5 * 1000).ToString();
    }
  }
}
