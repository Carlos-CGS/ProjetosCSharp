using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_POO.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        // Abaixo um construtor, obrigando a ter uma string nome ao declarar pessoa.(classe pai)
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade} anos.");
        }

    }

    
}