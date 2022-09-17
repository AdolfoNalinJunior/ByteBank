using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ListaDeObject
    {
        private Object[] _itens;
        private int _proximaPosicao;
        public int Tamanho { get { return _proximaPosicao; } }

        public ListaDeObject(int quantidade = 5)
        {
            _itens = new Object[quantidade];
            _proximaPosicao = 0;
        }

        public void Adicionar(Object item)
        {
            //Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");

            VerificarCapacidade(_proximaPosicao + 1);
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

                //Console.WriteLine("Aumentando capacidade do Array");
                Object[] novoArray = new Object[novoTamanho];

                for (int indice = 0; indice < _itens.Length; indice++)
                {
                    novoArray[indice] = _itens[indice];
                }
                _itens = novoArray;
            }
        }

        public void Remover(Object item)
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

        public Object GetIndice(int indici)
        {
            if (indici < 0 || indici >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indici));
            }

            return _itens[indici];
        }

        public void AdicionarVarios(params Object[] itens)
        {
            foreach (Object item in itens)
            {
                Adicionar(item);
            }
        }

        public Object this[int indici]
        {
            get
            {
                return GetIndice(indici);
            }
        }
    }
}
