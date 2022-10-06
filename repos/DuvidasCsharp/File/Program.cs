using System;
using System.IO;

namespace Files
{
  class Program
  {
    static void Main(string[] args)
    {
      // @ e para não colocar duas barras
      string sourcePath = @"C:\Users\antonio.pardim\Documents\file.txt";
      string targetPath = @"C:\Users\antonio.pardim\Documents\fileDestino.txt";
      FileStream fileStream = null;
      StreamReader sr = null;

      try 
      {
        // tem bastante metodos e mais performatico
        FileInfo fileInfo = new FileInfo(sourcePath);
        //copiar arquivo
        fileInfo.CopyTo(targetPath);
        // ler linha
        string[] lines = File.ReadAllLines(sourcePath);
        foreach(string line in lines)
        {
          //imprimir linha
          Console.WriteLine(line);
        }

        fileStream = new FileStream(sourcePath, FileMode.Open);
        sr = new StreamReader(fileStream);
        string linha = sr.ReadLine();
        Console.WriteLine(linha);
      }
      catch(IOException e)
      {
        Console.WriteLine("Um erro ocorreu" + e.Message);
      }
      finally
      {
        if(fileStream != null)
        {
          fileStream.Close();
        }
        if(sr != null)
        {
          sr.Close();
        }
      }
    }
  }
}
