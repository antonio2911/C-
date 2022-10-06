using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDuvidasCSharp.Entities
{
 public class HourContract
  {
    public int Hours { get; set; }
    
    public DateTime Date { get; set; }

    public double ValuePerHours { get; set; }

    public HourContract() { }

    public HourContract(int horas, double valorPorHoras, DateTime data) 
    {
      Hours = horas;
      ValuePerHours = valorPorHoras;
      Date = data;
    }

    // Methods

    public double TotalValue()
    {
      return Hours * ValuePerHours;
    }
  }
}
