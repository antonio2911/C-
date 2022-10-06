using System;
using System.IO;

namespace UsingBlock
{
  class Program
  {
    static void Main(string[] args)
    {
      //garante que objetos Idisposable serão fechados de forma automatica

      string path = @"C:\Users\antonio.pardim\Documents\file.txt";

      using(FileStream fs = new FileStream(path, FileMode.Open))
      {
        using(StreamReader sr = new StreamReader(fs))
        {
          while (!sr.EndOfStream)
          {
            string line = sr.ReadLine();
            Console.WriteLine(line);
          }
        }
      }
    }
  }
}
