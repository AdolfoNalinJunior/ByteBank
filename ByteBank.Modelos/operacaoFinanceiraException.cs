﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class OperacaoFinanceiraException : Exception
    {
        public double Saldo { get; set; }
        public double ValorSaque { get; set; }
        public OperacaoFinanceiraException()
        {

        }

        public OperacaoFinanceiraException(string mensagem) : base(mensagem)
        {

        }

        public OperacaoFinanceiraException(string mensagem, Exception excecaoInterna) : base(mensagem, excecaoInterna)
        {

        }
    }
}
