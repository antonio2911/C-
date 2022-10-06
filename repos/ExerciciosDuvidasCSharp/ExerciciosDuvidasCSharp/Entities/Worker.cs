using ExerciciosDuvidasCSharp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDuvidasCSharp.Entities
{
  class Worker
  {
    public string Name { get; set; }
    
    public double BaseSalary { get; set; }

    public WorkerLevel Level { get; set; }

    public Departament Departament { get; set; }

    public List<HourContract> Contract { get; set; } = new List<HourContract>();

    public Worker() { }

    public Worker(string nome, double salarioBase, WorkerLevel nivel, Departament departamento)
    {
      Name = nome;
      BaseSalary = salarioBase;
      Level = nivel;
      Departament = departamento;
    }

    public void AddContract(HourContract contract)
    {
      Contract.Add(contract);
    }

    public void RemoveContract(HourContract contract)
    {
      Contract.Remove(contract);
    }

    public double Income(int year, int month)
    {
      double sum = BaseSalary;

      Contract.ForEach((contrato) =>
      {
        if (contrato.Date.Year == year && contrato.Date.Month == month)
        {
          sum += contrato.TotalValue();
        }
      });
      return sum;
    }
  }
}
