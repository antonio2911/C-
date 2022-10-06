using System;
using System.Collections.Generic;

namespace Dicionario
{
  class Program
  {
    static void Main(string[] args)
    {
      Dictionary<string, string> cookies = new Dictionary<string, string>();

      cookies["user"] = "Maria";
      cookies["email"] = "maria@gmail.com";
      cookies["phone"] = "3199999999";
      cookies["phone"] = "88522146";// como não aceita repetição ele vai substitutir

      Console.WriteLine(cookies["phone"]);
      Console.WriteLine(cookies["email"]);

      cookies.Remove("email");
      if (cookies.ContainsKey("email"))
      {
        Console.WriteLine(cookies["email"]);
      }
      else
      {
        Console.WriteLine("Não contem email");
      }
      Console.WriteLine(cookies.Count);
      Console.WriteLine("all cookies");

     foreach(KeyValuePair<string,string> item in cookies)
      {
        Console.WriteLine(item.Key);
        Console.WriteLine(item.Value);
      }
    }
  }
}

//dicionario permite apenas uma chave
// os elementos são indexados pelo obj chave
// caracteristicas
// armazenamento rapido
// a ordem dos elementos não e garantida

//sortdDicionary => armazenamento em arvore ordem garantida em log ICompare<T>

//principais operações
/*
 add()
clear()
count()
constains(key)
constains(value)
remove(key)
 */