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

namespace ByteBank.SistemaAgencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá mundo!");
            Console.WriteLine(123);
            Console.WriteLine(10.5);
            Console.WriteLine(true);

            Object conta = new ContaCorrente(123,34232);
            Desenvolvedor desenvolvedor = new Desenvolvedor("siohfvsuio");

            string contaToString = conta.ToString();

            Console.WriteLine("Resultado: " + contaToString);
            Console.WriteLine(conta);

        }

        static void TestandoStrings()
        {
            // [0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]
            // "[0-9]{4,5}[-][0-9]{4}"; 
            // "[0-9]{4,5}[-]{0,1}[0-9]{4}"; 
            // "[0-9]{4,5}-{0,1}[0-9]{4}"; 
            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            // As chaves faz a quantificação, há quantidade de quantificação vai depender do número que esta dentos
            // A variável padrao é uma "Expressão Regular" que mostra ou defini um padrao

            string textoTeste = "Meu nome é Adolfo, me ligue em 99784-4546";
            Match resultado = Regex.Match(textoTeste, padrao);
            Console.WriteLine(resultado);

            /*A classe Regex.IsMatch() retorna o valor verdadeiro ou falso, ou seja, se possui ou não esse padrão
             
            A classe Regex.Match() retorna valores de objetos, porem é só converter esse valor para string ou armazenar em 
            uma variavel tipo Match, como é feita na variável resultado*/

        }
    }
}