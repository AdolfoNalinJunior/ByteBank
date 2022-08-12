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
            Console.WriteLine(url);
            string argumento = url.Substring(8);
            Console.WriteLine(argumento);
        }
    }
}