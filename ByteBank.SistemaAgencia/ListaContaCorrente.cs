using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ListaContaCorrente
    {
        private ContaCorrente[] _itens;
        private int _proximaPosicao;

        public ListaContaCorrente(int quantidade = 5)
        {
            _itens = new ContaCorrente[quantidade];
            _proximaPosicao = 0;
        }

        public void Adicionar(ContaCorrente item)
        {
            Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");

            VerificarCapacidade(_proximaPosicao  + 1);
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }
            else
            {
                int novoTamanho = _itens.Length * 2;
                if (novoTamanho < tamanhoNecessario)
                {
                    novoTamanho = tamanhoNecessario;
                }

                Console.WriteLine("Aumentando capacidade do Array");
                ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];

                for (int indice = 0; indice < _itens.Length; indice++)
                {
                    novoArray[indice] = _itens[indice];
                    Console.WriteLine(".");
                }
                _itens = novoArray;
            }
        }
                               // joãoRicardo
        public void Remover(ContaCorrente item)
        {
            int indiceItem = -1;

            for (int i = 0; i < _proximaPosicao; i++)
            {
                if (_itens[i].Equals(item))
                {
                    indiceItem = i;
                    break;
                }
            }

            for (int i = indiceItem; i < _proximaPosicao - 1; i++)
            {
                _itens[i] = _itens[i + 1];
            }

            _proximaPosicao--;
            _itens[_proximaPosicao] = null;
        }

        public void EscreverListaTela()
        {
            for (int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente conta = _itens[i];
                Console.WriteLine($"conta número no índici {i}: {conta.Numero} {conta.Agencia}");
            }
        }
    }
}
