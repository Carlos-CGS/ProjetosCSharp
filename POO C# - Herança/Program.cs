using Exemplo_POO.Models;
using Exemplo_POO.Interfaces;

Pessoa p1 = new Pessoa("Carlos");
p1.Idade = 31;
p1.Apresentar();

Console.WriteLine("_____________________________________");

// ContaCorrente c1 = new ContaCorrente(123, 1000);   <<, esta é outra forma de atribuir valor ao instanciar uma classe
Console.WriteLine("   ");
ContaCorrente c1 = new ContaCorrente(123, 1000);
c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();

Console.WriteLine("_____________________________________");
Console.WriteLine("  ");

Aluno a1 = new Aluno("Jose");
a1.Idade = 15;
a1.Nota = 80;
a1.Apresentar();

Console.WriteLine("_____________________________________");
Console.WriteLine("  ");
Professor prof1 = new Professor("Marcio");
prof1.Idade = 55;
prof1.Salario = 2400;
prof1.Apresentar();

Console.WriteLine("_____________________________________");
Console.WriteLine(" ");

Corrente cc1 = new Corrente();
cc1.Creditar(800);
cc1.ExibirSaldo();
