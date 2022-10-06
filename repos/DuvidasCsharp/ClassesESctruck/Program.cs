using System;

namespace ClassesESctruck
{
  class Program
  {
    static void Main(string[] args)
    {
      //struct
      Point p;
      p.x = 10;
      p.y = 15;
      Console.WriteLine($"valor de p primeira instancia = {p}");
      Point p2 = p;
      Console.WriteLine($"valor de p2 copia p1 = {p2}");
      //copia p
      p.x = 400;
      p.y = 100;
      Console.WriteLine($"valor de p1 atualizado mostrando que o 2 apenas copiou o 1 na primeira estanciação = {p}");
      Console.WriteLine($"valor de p2 apos alterar p1 = {p2}");
      p = new Point();
      Console.WriteLine($"Valor de p1 apos chama o new object = {p}");
      Console.WriteLine("");

      //class
      Console.WriteLine("Classes");
      ClassExemplo Produto1 = new ClassExemplo("Tv", 3500, 2);
      Console.WriteLine($"Produto um apontando para o objeto instanciado = {Produto1.Imprimir()}");
      ClassExemplo Produto2 = Produto1;
      Console.WriteLine($"Produto dois recebendo o apontamento de produto um antes da atribuição do novo valor em produto 1 = {Produto2.Imprimir()}");
      Produto1.Produto = "Liquidificador";
      Produto1.Quantidade = 3;
      Produto1.Valor = 150;

      Console.WriteLine($"Produto um apontando para o objeto instanciado Atualizado = {Produto1.Imprimir()}");
      Console.WriteLine($"Produto dois recebendo o apontamento de produto um = {Produto2.Imprimir()}");
      Console.WriteLine("Exemplo que o apontamento funciona não gerando uma copia mas sempre apontando para o produto 1");
    }
  }
}
