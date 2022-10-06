using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
  class ThisEProperties
  {
  public string Nome;
   public double Preco;
    public int Quantidade;

    //contrutor padrão
    public ThisEProperties()
    {
      Quantidade = 0;
    }
    // Passando o contrutor acima no this e agora recebendo a quantidade como parametro
    public ThisEProperties(string nome, double preco) : this()
    {
      Nome = nome;
      Preco = preco;
    }

    // reaproveita o nome e o preco do construtor de 2 argumentos
    public ThisEProperties(string nome, double preco, int quantidade) : this(nome, preco)
    {
      Quantidade = quantidade;
    }
  }
}
