using Microsoft.Data.SqlClient;

namespace LibraryApp
{
  class Program
  {
    static void Main(string[] args) {
      Console.WriteLine("Hello World!");
      var connectionString = "Server=DESKTOP-FA4P8I0;Database=bd_library;Trusted_Connection=True;TrustServerCertificate=True;";
      SqlConnection connection = new SqlConnection(connectionString);

      try {
        connection.Open();
        Console.WriteLine("Connection Open");

        string insertString = @"insert into Authors (FirstName, LastName) values ('Roger', 'Zelazny')";
        string insertStringBook = @"insert into Books (AuthorId, title, Price, Pages) values (1, 'Хроники Амбера', 5000, 500)";

        SqlCommand cmd = new SqlCommand(insertString, connection);
        cmd.ExecuteNonQuery();

        cmd = new SqlCommand(insertStringBook, connection);
        cmd.ExecuteNonQuery();


      } catch (Exception ex) {
        Console.WriteLine(ex.Message);
      } finally {
        connection.Close();
        Console.WriteLine("Connection Close");
      }

      Console.ReadKey();
    }
  }
}
