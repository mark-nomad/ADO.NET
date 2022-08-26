using System;

namespace homeWork03
{
  internal class Program
  {
    static void Main(string[] args) {
      try {
        //Task1.Demo();
        //Task2.Demo();
        //Task3.Demo();
        Task4.Demo();
        Console.WriteLine("\nEnd . . .");
        Console.WriteLine("Press any key to complete...");
        Console.ReadLine();
      } catch (Exception ex) {
        Console.WriteLine(ex.Message);
      }
      Console.ReadLine();
    }
  }
}
