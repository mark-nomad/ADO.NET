using System;
using System.Linq;

namespace homeWork03
{
  public class Task4
  {
    public static void Demo() {


      var db = new DataClasses1DataContext();

      Console.WriteLine("\nПоказать топ-5 стран по площади : ");
      var countriesArea = db.Countries
              .OrderByDescending(c => c.Area)
              .Take(5)
              .ToList();
      foreach (var item in countriesArea) {
        Console.WriteLine(item.Country + " " + item.Area);
      }

      Console.WriteLine("\nПоказать топ-5 стран по количеству жителей : ");
      var countriesPopulation = db.Countries
              .OrderByDescending(c => c.Population)
              .Take(5)
              .ToList();
      foreach (var item in countriesPopulation) {
        Console.WriteLine(item.Country + " " + item.Population);
      }

      Console.WriteLine("\nПоказать страну с самой большой площадью : ");
      var countryMaxArea = db.Countries.OrderByDescending(c => c.Area).First();
      Console.WriteLine(countryMaxArea.Country + " " + countryMaxArea.Area);

      Console.WriteLine("\nПоказать страну с самым большим количеством жителей : ");
      var countryMaxPopulation = db.Countries.OrderByDescending(c => c.Population).First();
      Console.WriteLine(countryMaxPopulation.Country + " " + countryMaxPopulation.Population);

      Console.WriteLine("\nПоказать страну с самой маленькой площадью в Африке : ");
      var countryMinAreaAfrica = db.Countries.ToList()
        .Where(c => c.Continents == "Africa")
        .OrderBy(c => c.Area)
        .First();
      Console.WriteLine(countryMinAreaAfrica.Country + " " + countryMinAreaAfrica.Area);


      Console.WriteLine("\nПоказать среднюю площадь стран в Азии : ");
      var Countries = db.Countries.ToList();
      var countryAvgAreaAsia = (from c in Countries where c.Continents == "Asia" select c.Area).Average();

      Console.WriteLine("Показать среднюю площадь стран в Азии = " + countryAvgAreaAsia);


    }
  }
}

