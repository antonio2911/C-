using System;

namespace funcoesParaString
{
  class Program
  {
    static void Main(string[] args)
    {
      string original = "abcd EFGHIJ klm ABC abc     ";
      string s1 = original.ToUpper(); // Tudo Maiusculo
      string s2 = original.ToLower(); // tudo Minusculo
      string s3 = original.Replace(" ", "_"); // substitui todo valor por outro
      string s4 = original.Trim(); // apagar os espaço em branco na antes e depois da string
      string s5 = original.Substring(4); // corta a string indicando o indice
      string s6 = original.Substring(4, 10); // Sobrecarga indicando o inicio e o final do corte
      string s7 = original.Replace("ABC", "zyx"); // substitui todo valor por outro
      bool s8 = string.IsNullOrEmpty(original); // boolean que diz se a string e vazia
      bool s9 = string.IsNullOrWhiteSpace(original); // verifica se e null ou somente spaco vazio return true caso contrario false

      int n1 = original.IndexOf("bc"); // retorna o indice de acordo o paramentro
      int n2 = original.IndexOf("bc"); // retorna o ultimo indice de acordo o paramentro


      Console.WriteLine($"-ToUpper ({s1}) -");
      Console.WriteLine($"-ToLower ({s2}) -");
      Console.WriteLine($"-Replace ({s3}) -");
      Console.WriteLine($"-Trim {s4} -");
      Console.WriteLine($"-Substring {s5} -");
      Console.WriteLine($"-Substring {s6} -");
      Console.WriteLine($"-Replace {s7} -");
      Console.WriteLine($"-IsNullOrEmpty {s8} -");
      Console.WriteLine($"-IsNullOrWhiteSpace {s9} -");
      Console.WriteLine($"-IndexOf {n1} -");
      Console.WriteLine($"-IndexOf {n2} -");
    }
  }
}
