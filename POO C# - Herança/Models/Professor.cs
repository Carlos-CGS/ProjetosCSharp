using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_POO.Models
{
    public class Professor : Pessoa
    {
        public Professor()
        {

        }
        //Abaixo instanciei a string nome, conforme instanciado na classe pai (Pessoa)
        public Professor(string nome) : base(nome)
        {
            Nome = nome;
        }
        
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e meu salário é {Salario}");
        }

    }
}