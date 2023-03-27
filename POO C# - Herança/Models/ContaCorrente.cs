using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_POO.Models
{
    public class ContaCorrente
    {
        // Abaixo contrui um construtor escrevendo Ctor e apertando TAB
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        
        public int NumeroConta { get; set; }

        // propriedade privada, por encapsulamento, apenas a classe pode acessar e alterar, atraves da propriedade Sacar(public)
        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                //Acima saldo é ugaual a saldo menos o valor 
                Console.WriteLine("Saque realizado com sucesso !") ;      
            }else
            {
                Console.WriteLine("Saldo Insuficiente !");
            }
            
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo disponível é {saldo}.");
        }
    }
}