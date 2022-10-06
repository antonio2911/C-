using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
  class Properties
  {
    private string _nome;
    public double Preco { get; set; } // pode acessar leitura mas o set e apenas nessa classe
    public int Quantidade { get; private set; } // Auto Properties (utilizado em implementação de get e set sem logica envolvida


    //Properties

    public string Nome
    {
      get { return _nome; }
      set 
      {
      if(value != null && value.Length > 1)
        {
          _nome = value;
        }
      }
    }
    public void QuantidadeTotal(int quantidade)
    {
      Quantidade = quantidade;
    }
    public string ValorTotal()
    {
      double valorTotal = Preco * Quantidade;

      return $"O valor total e = {valorTotal}";
    }


  }
}
