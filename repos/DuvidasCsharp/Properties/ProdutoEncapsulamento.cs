using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
  class ProdutoEncapsulamento
  {
    private string _name;
    private double _price;
    private int _quantity;

    //Getteres e setters

    public string GetName()
    {
      return _name;
    }

    public void SetName(string nome)
    {
      _name = nome;
    }

    public double GetPrice()
    {
      return _price;
    }

    public void SetPrice(double preco)
    {
      if(preco > 0)
      {
        _price = preco;
      }
    }
    //construtores
    public ProdutoEncapsulamento()
    {

    }
    public ProdutoEncapsulamento(int quantidade)
    {
      _quantity = quantidade;
    }

   public ProdutoEncapsulamento(string nome, double preco, int quantidade) : this(quantidade)
    {
      _name = nome;
      _price = preco;
    }

    public string ValorTotalEstoque()
    {
      double valorTotal = _price * _quantity;
      return $"O valor total no estoque e = {valorTotal}" ;
    }

    public void AdicionarProduto(int quantidade)
    {
      _quantity += quantidade; 
      Console.WriteLine($"Novo saldo de produto e = {_quantity}");
    }


  }
}
