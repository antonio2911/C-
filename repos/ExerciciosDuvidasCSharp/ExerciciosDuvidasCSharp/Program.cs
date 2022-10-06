using ExerciciosDuvidasCSharp.Entities;
using ExerciciosDuvidasCSharp.Entities.Enums;
using System;
using System.Globalization;

namespace ExerciciosDuvidasCSharp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter name departament: ");
      
      string nameDepartament = Console.ReadLine();
      
      Console.WriteLine("Name");
      
      string name = Console.ReadLine();

      Console.WriteLine("Level ( Junior/ Pleno/ Senior");

      WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

      Console.WriteLine("Base Salary: ");

      double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      Departament departament = new Departament(nameDepartament);

      Worker worker = new Worker(name, baseSalary, level, departament);

      Console.WriteLine("How many contracts to this worker?");
      int quantidadeDeContratos = int.Parse(Console.ReadLine());

      for(int i = 1; i < quantidadeDeContratos; i++)
      {
        Console.WriteLine($"Enter #{i} contracts data: ");
        
        Console.WriteLine("Date (DD/MM/YYYY)");

        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Duration (hours)");

        int hours = int.Parse(Console.ReadLine());

        Console.WriteLine("Value Per Hours");
        
        double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        HourContract contract = new HourContract(hours, valuePerHours, date);

        worker.AddContract(contract);
      }

      Console.WriteLine();
      Console.Write("Enter Month and Year to calculate income (MM/YYYY)");
      string monthAndYear = Console.ReadLine();
      int month = int.Parse(monthAndYear.Substring(0, 2));
      int year = int.Parse(monthAndYear.Substring(3));

      Console.WriteLine($"Name: {worker.Name}");
      Console.WriteLine($"Departament: {worker.Departament.Name}");
      Console.WriteLine($"Departament: {worker.Departament.Name}");
      Console.WriteLine($"income for: {monthAndYear} : {worker.Income(year,month)}");

    }
  }
}
