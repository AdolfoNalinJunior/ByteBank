using ByteBank.Modelos;
using ByteBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
using System.Text.RegularExpressions;
using ByteBank.Modelos.Funcionarios;
using System.Net.Http.Headers;

namespace ByteBank.SistemaAgencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array de inteiros, com 5 posições

            int[] idades = null;
            //new int[5];

            idades[0] = 28;
            idades[1] = 15;
            idades[2] = 28;
            idades[3] = 35;
            idades[4] = 50;

            Console.WriteLine(idades[4]);
        } 
    }   
}