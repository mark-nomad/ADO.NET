using System;
using System.Linq;

namespace homeWork03
{
  public class Task1
  {
    public static void Demo() {
      var db = new DataClasses1DataContext();
      var result = db.Countries.ToList();

      foreach (var item in result) {
        Console.WriteLine(item.Country + " " + item.Capital);
      }

    }
  }
}
