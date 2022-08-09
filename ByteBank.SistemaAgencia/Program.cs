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
            DateTime dataFimPagamento = new DateTime(2022, 8, 3);
            DateTime dataCorrente = DateTime.Now;
            TimeSpan diferenca = dataCorrente - dataFimPagamento;

            string mensagem = "Vencimento em: " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(mensagem);
        }
    }
