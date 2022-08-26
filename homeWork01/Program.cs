using System;
using System.Data.SqlClient;

namespace homeWork01
{
  internal class Program
  {
    static void Main(string[] args) {
      var connectionString = "Server=DESKTOP-FA4P8I0;Database=bd_vegetables_fruit;Trusted_Connection=True;TrustServerCertificate=True;";
      SqlConnection connection = new SqlConnection(connectionString);

      try {
        connection.Open();
        Console.WriteLine("Connection Open");
        Console.WriteLine("1. Отображение всей информации из таблицы с овощами и фруктами;");
        HomeTasks.ColumnsCount5(connection, 1);

        Console.WriteLine("2. Отображение всех названий овощей и фруктов;");
        HomeTasks.ColumnsCount1(connection, 2);
        Console.WriteLine("3. Отображение всех цветов;");
        HomeTasks.ColumnsCount1(connection, 3);
        Console.WriteLine("4. Показать максимальную калорийность;");
        HomeTasks.ColumnsCount1(connection, 4);
        Console.WriteLine("5. Показать минимальную калорийность;");
        HomeTasks.ColumnsCount1(connection, 5);
        Console.WriteLine("6. Показать среднюю калорийность;");
        HomeTasks.ColumnsCount1(connection, 6);
        Console.WriteLine("7. Показать количество овощей;");
        HomeTasks.ColumnsCount1(connection, 7);
        Console.WriteLine("8. Показать количество фруктов;");
        HomeTasks.ColumnsCount1(connection, 8);
        Console.WriteLine("9. Показать количество овощей и фруктов заданного цвета;");
        HomeTasks.ColumnsCount1(connection, 9);

        Console.WriteLine("10. Показать количество овощей фруктов каждого цвета;");
        HomeTasks.ColumnsCount2(connection, 10);

        Console.WriteLine("11. Показать овощи и фрукты с калорийностью ниже указанной;");
        HomeTasks.ColumnsCount4(connection, 11);
        Console.WriteLine("12. Показать овощи и фрукты с калорийностью выше указанной;");
        HomeTasks.ColumnsCount4(connection, 12);
        Console.WriteLine("13. Показать овощи и фрукты с калорийностью в указанном диапазоне;");
        HomeTasks.ColumnsCount4(connection, 13);
        Console.WriteLine("14. Показать все овощи и фрукты, у которых цвет желтый или красный;");
        HomeTasks.ColumnsCount4(connection, 14);
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
