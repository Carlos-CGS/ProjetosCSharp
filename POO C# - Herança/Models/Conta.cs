using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_POO.Models
{
    //abstract abaixo faz a classe ser abstrada, ou seja classe modelo, nn pode ser instanciada
    public abstract class Conta
    {
        // protected abaixo protege a variavel contra alterações externas exceto das classes filhas.
        protected decimal saldo;

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo é {saldo}.");
        }
    }
}