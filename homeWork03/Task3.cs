using System;
using System.Linq;

namespace homeWork03
{
  public class Task3
  {
    public static void Demo() {
      var db = new DataClasses1DataContext();
      //var Countries = db.Countries.ToList();

      Console.WriteLine("\nОтобразить все страны, у которых в названии есть буквы a, u: ");
      var countries = db.Countries
        .Where(c => c.Country.Contains("a"))
        .Where(c => c.Country.Contains("u"))
        .OrderBy(c => c.Country)
        .ToList();
      foreach (var item in countries) {
        Console.WriteLine(item.Country);
      }

      Console.WriteLine("\nОтобразить все страны, у которых название начинается с буквы a: ");
      var countriesWithA = db.Countries
        .Where(c => c.Country.StartsWith("A"))
        .OrderBy(c => c.Country)
        .ToList();
      foreach (var item in countriesWithA) {
        Console.WriteLine(item.Country);
      }



      Console.WriteLine("\nОтобразить название стран, у которых площадь находится в указанном диапазоне {450000 500000} : ");
      var countriesArea = db.Countries
        .Where(c => c.Area > 450000)
        .Where(c => c.Area < 500000)
        .OrderBy(c => c.Area)
        .ToList();
      foreach (var item in countriesArea) {
        Console.WriteLine(item.Country + " " + item.Area);
      }

      Console.WriteLine("\nОтобразить название стран, у которых количество жителей больше указанного числа {550000} : ");
      var countriesPopulation = db.Countries
        .Where(c => c.Population > 550000)
        .OrderBy(c => c.Population)
        .ToList();
      foreach (var item in countriesPopulation) {
        Console.WriteLine(item.Country + " " + item.Population);
      }

    }
  }
}
