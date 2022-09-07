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
using System.IO;
using System.Runtime.InteropServices;

namespace ByteBank.SistemaAgencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array de inteiros, com 5 posições

            int[] idades = new int[5];

            idades[0] = 28;
            idades[1] = 15;
            idades[2] = 28;
            idades[3] = 35;
            idades[4] = 50;

            int acumulador = 0;

            for (int indeci = 0; indeci < idades.Length; indeci++)
            {
                int idade = idades[indeci];

                Console.WriteLine($"Acessando o array idade no índice {indeci}");
                Console.WriteLine($"Valor de idade é [{indeci}] = {idade}");

                acumulador += idade;
            }
            
            int media = acumulador / idades.Length;

            Console.WriteLine($"A media é {media}");
        } 
    }   
}