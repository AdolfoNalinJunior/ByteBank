using ByteBank.Modelos;
using ByteBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string url = "paginas?argumentos";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(url);
            string argumento = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumento);

            string vazia = "";
            Console.WriteLine(String.IsNullOrEmpty(vazia));

            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length); 
            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length + 1));

        }
    }
}