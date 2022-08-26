using System;
using System.Linq;

namespace homeWork03
{
  public class Task2
  {
    public static void Demo() {
      var db = new DataClasses1DataContext();
      var Countries = db.Countries.ToList();

      Console.WriteLine("Отобразить всю информацию о странах:");
      Console.WriteLine("Country" + " \t" + "Capital" + " \t" + "Population" + " \t" + "Area" + " \t" + "Continents");

      foreach (var item in Countries) {
        Console.WriteLine(item.Country + " \t" + item.Capital + " \t" + item.Population + " \t" + item.Area + " \t" + item.Continents);
      }

      Console.WriteLine("\nОтобразить название стран:");
      var names = from c in Countries select c.Country;
      foreach (var item in names) {
        Console.WriteLine(item);
      }

      Console.WriteLine("\nОтобразить название столиц:");
      var cities = from c in Countries select c.Capital;
      foreach (var item in cities) {
        Console.WriteLine(item);
      }

      Console.WriteLine("\nОтобразить название всех европейских стран:");
      var european = from c in Countries
                     where c.Continents == "Europe"
                     orderby c.Country
                     select c.Country;

      foreach (var item in european) {
        Console.WriteLine(item);
      }

      Console.WriteLine("\nОтобразить название стран с площадью большей конкретного числа: ");
      var areas = db.Countries
        .Where(x => x.Area > 415000)
        .OrderBy(a => a.Area).ToList();

      foreach (var item in areas) {
        Console.WriteLine(item.Country);
      }

    }
  }
}
