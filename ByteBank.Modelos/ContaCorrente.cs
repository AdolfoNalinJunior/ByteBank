using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    /// <summary>
    /// Defini uma Conta Correte do Banco Bytebank.
    /// </summary>
    public class ContaCorrente
    {
        
        public Cliente Titular { get; set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }
        public int ContadorSaqueNaoPermitidos { get; private set; }
        public static double TaxaOperacacao { get; set; }
        public static int TotalDeContasCriadas { get; private set; }
        public int Agencia { get; }
        public int Numero { get; }
        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }
        /// <summary>
        /// Cria uma instancia de ContaCorrente com os argumentos utilizados.
        /// </summary>
        /// <param name="agencia">Repersenta o valor da propria <see cref="Agencia"/> e deve ser maior que zero.</param>
        /// <param name="numero">Representa o valor da proprio <see cref="Numero"/> e deve ser maior que zero.</param>
        /// <exception cref="ArgumentException"></exception>
        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0. ", nameof(agencia));
            }
            else if (numero <= 0)
            {
                throw new ArgumentException("O argumento número deve ser maior que 0. ", nameof(numero));
            }


            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;

            TaxaOperacacao = 30 / TotalDeContasCriadas;
        }

  
        /// <summary>
        /// Realiza o saque e atualiza o valor da propriedade <see cref="Saldo"/>
        /// </summary>
        /// <param name="valor">Representa o valor do saque <see cref="Saldo"/></param>
        /// <exception cref="ArgumentException">Exceção lançada quando um valor negativo é utilizado no argumento <paramref name="valor"/></exception>
        /// <exception cref="SaldoInsuficienteException">Exceção lançada quando o valor de <paramref name="valor"/> é maior que a propriedade <see cref="Saldo"/></exception>
        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para os saque!!", nameof(valor));
            }

            else if (_saldo < valor)
            {
                ContadorSaqueNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }


            contaDestino.Depositar(valor);
        }
    }
}
