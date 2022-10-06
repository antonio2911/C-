using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProdutos
{
  public class Cadastro
  {
    public string Nome;
    public double Preco;
    public int Quantidade;
    //Por padrão os contrutores vem depois dos atributos e antes dos metodos
    public Cadastro()
    {

    }
    public Cadastro(string nome, double preco, int quantidade)
    {
      Nome = nome;
      Preco = preco;
      Quantidade = quantidade;
    }
    //sobrecarga
    public Cadastro(string nome, double preco)
    {
      Nome = nome;
      Preco = preco;
      Quantidade = 1;
    }


    // Final construtores
    public double ValorTotalEstoque()
    {
      double ValorTotalEstoque = Preco * Quantidade;
      return ValorTotalEstoque;
    }

    public void AdicionarProduto(int quantidade)
    {
      this.Quantidade += quantidade;

    }
    public void RemoverProduto(int quantidade)
    {
      this.Quantidade -= quantidade;
    }

    //como mudar a saida da class sobrescrevendo o objeto com override
    public override string ToString()
    {
      return $"{Nome}, R${Preco.ToString("F2", CultureInfo.InvariantCulture)}, " +
        $" {Quantidade} unidades, Total: R${ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
    }
  }
}
