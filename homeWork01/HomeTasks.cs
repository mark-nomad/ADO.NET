using System;
using System.Data.SqlClient;

namespace homeWork01
{
  public class HomeTasks
  {
    static void Menu() {
      Console.WriteLine("1. Отображение всей информации из таблицы с овощами и фруктами;");
      Console.WriteLine("2. Отображение всех названий овощей и фруктов;");
      Console.WriteLine("3. Отображение всех цветов;");
      Console.WriteLine("4. Показать максимальную калорийность;");
      Console.WriteLine("5. Показать минимальную калорийность;");
      Console.WriteLine("6. Показать среднюю калорийность;");
      Console.WriteLine("7. Показать количество овощей;");
      Console.WriteLine("8. Показать количество фруктов;");
      Console.WriteLine("9. Показать количество овощей и фруктов заданного цвета;");
      Console.WriteLine("10. Показать количество овощей фруктов каждого цвета;");
      Console.WriteLine("11. Показать овощи и фрукты с калорийностью ниже указанной;");
      Console.WriteLine("12. Показать овощи и фрукты с калорийностью выше указанной;");
      Console.WriteLine("13. Показать овощи и фрукты с калорийностью в указанном диапазоне;");
      Console.WriteLine("14. Показать все овощи и фрукты, у которых цвет желтый или красный;");
    }

    public static string TaskString(int select) {
      switch (select) {
      case 1:
      return "1. Отображение всей информации из таблицы с овощами и фруктами;";
      case 2:
      return "2. Отображение всех названий овощей и фруктов;";
      case 3:
      return "3. Отображение всех цветов;";
      case 4:
      return "4. Показать максимальную калорийность;";
      case 5:
      return "5. Показать минимальную калорийность;";
      case 6:
      return "6. Показать среднюю калорийность;";
      case 7:
      return "7. Показать количество овощей;";
      case 8:
      return "8. Показать количество фруктов;";
      case 9:
      return "9. Показать количество овощей и фруктов заданного цвета;";
      case 10:
      return "10. Показать количество овощей фруктов каждого цвета;";
      case 11:
      return "11. Показать овощи и фрукты с калорийностью ниже указанной;";
      case 12:
      return "12. Показать овощи и фрукты с калорийностью выше указанной;";
      case 13:
      return "13. Показать овощи и фрукты с калорийностью в указанном диапазоне;";
      case 14:
      return "14. Показать все овощи и фрукты, у которых цвет желтый или красный;";
      default:
      return "Error!";
      }
    }
    public static string SelectString(int select) {
      switch (select) {
      /*5 columns */
      case 1:
      default:
      return @"SELECT * FROM Stuffs";
      /*1 column*/
      case 2:
      return @"SELECT DISTINCT Name FROM Stuffs ORDER BY Name";
      case 3:
      return @"SELECT DISTINCT Color FROM Stuffs ORDER BY Color";
      case 4:
      return @"SELECT MAX(Calories) AS MAX_Calories FROM Stuffs";
      /*SELECT TOP (1) Name, Typeof, Color,  Calories  FROM Stuffs ORDER BY Calories DESC*/
      case 5:
      return @"SELECT MIN(Calories) AS MIN_Calories FROM Stuffs";
      case 6:
      return @"SELECT AVG(Calories) AS AVG_Calories FROM Stuffs";
      case 7:
      return @"SELECT COUNT(Typeof) AS COUNT_vegetables FROM Stuffs WHERE (Typeof = 1)";
      case 8:
      return @"SELECT COUNT(Typeof) AS COUNT_fruit FROM Stuffs WHERE (Typeof = 0)";
      case 9:
      return @"SELECT COUNT(Color) AS COUNTOrange FROM Stuffs WHERE (Color = N'Orange')";
      /*2 columns*/
      case 10:
      return @"SELECT Color, COUNT(Color) AS COUNT FROM  Stuffs GROUP BY Color";
      /*4 column*/
      case 11:
      return @"SELECT Name, Typeof, Color, Calories FROM Stuffs WHERE  (Calories < 500) ORDER BY Calories DESC";
      case 12:
      return @"SELECT Name, Typeof, Color, Calories FROM Stuffs WHERE  (Calories > 500) ORDER BY Calories";
      case 13:
      return @"SELECT  Name, Typeof, Color, Calories FROM Stuffs WHERE  (Calories > 450) AND (Calories < 550) ORDER BY Calories";
      case 14:
      return @"SELECT  Name, Typeof, Color, Calories FROM Stuffs WHERE (Color = 'Orange') OR (Color = 'Red') ORDER BY Color, Name";
      }
    }

    public static void ColumnsCount5(SqlConnection connection, int select) {
      //Console.WriteLine(TaskString(select));
      SqlDataReader rdr = null;
      string queryString;
      queryString = SelectString(select);
      SqlCommand cmd = new SqlCommand(queryString, connection);
      rdr = cmd.ExecuteReader();
      while (rdr.Read()) {
        Console.WriteLine(rdr[0] + " " + rdr[1] + " " + rdr[2] + "  " + rdr[3] + " " + rdr[4]);
      }
      if (rdr != null) {
        rdr.Close();
      }
    }

    public static void ColumnsCount1(SqlConnection connection, int select) {
      //Console.WriteLine(TaskString(select));
      SqlDataReader rdr = null;
      string queryString;
      queryString = SelectString(select);
      SqlCommand cmd = new SqlCommand(queryString, connection);
      rdr = cmd.ExecuteReader();
      while (rdr.Read()) {
        Console.WriteLine(rdr[0]);
      }
      if (rdr != null) {
        rdr.Close();
      }
    }

    public static void ColumnsCount2(SqlConnection connection, int select) {
      //Console.WriteLine(TaskString(select));
      SqlDataReader rdr = null;
      string queryString;
      queryString = SelectString(select);
      SqlCommand cmd = new SqlCommand(queryString, connection);
      rdr = cmd.ExecuteReader();
      while (rdr.Read()) {
        Console.WriteLine(rdr[0] + " " + rdr[1]);
      }
      if (rdr != null) {
        rdr.Close();
      }
    }
    public static void ColumnsCount4(SqlConnection connection, int select) {
      //Console.WriteLine(TaskString(select));
      SqlDataReader rdr = null;
      string queryString;
      queryString = SelectString(select);
      SqlCommand cmd = new SqlCommand(queryString, connection);
      rdr = cmd.ExecuteReader();
      while (rdr.Read()) {
        Console.WriteLine(rdr[0] + " " + rdr[1] + " " + rdr[2] + "  " + rdr[3]);
      }
      if (rdr != null) {
        rdr.Close();
      }
    }



  }
}
