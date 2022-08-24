using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentos
    {
        private readonly string _argumentos;
        public string URL { get;}
        public ExtratorValorDeArgumentos(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento não pode ser nulo ou vazio! ", nameof(url));
            }

            int indiceInterrogacao = url.IndexOf('?');

            _argumentos = url.Substring(indiceInterrogacao + 1);

            this.URL = url;
        }
        // moedaOrigem=moedaDestino&moedaDestino=dolar
        public string GetValor(string nomeParametro)
        {
            string termo = nomeParametro + "="; // moedaDestino + "="
            int indiceTermo = _argumentos.IndexOf(termo);

            string resultado = _argumentos.Substring(indiceTermo + termo.Length); // dólar

            int indiceEComercial = resultado.IndexOf('&');

            if (indiceEComercial == -1)
            {
                return resultado;
            }
            else
            {
                return resultado.Remove(indiceEComercial);
            }

        }
    }
}
