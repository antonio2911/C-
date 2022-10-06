using System;

namespace TrabalhandoComTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Ola seja bem vindo, tudo bem? feliz e ser alegre e feliz com a gente e alegre";
            string palavra = "alegre";
            Console.WriteLine("Tamanho: " + texto.Length);
            Console.WriteLine("Localizar: " + texto.IndexOf(palavra));
            Console.WriteLine("Localizar ultimo: " + texto.LastIndexOf(palavra));

            //Substituir texto

            string nome = "José Augusto Neto";
            Console.WriteLine(nome);
            string substituir = nome.Replace("Augusto", "Antonio");
            Console.WriteLine(substituir);
            Console.WriteLine(nome);

           

        }
    }
}
