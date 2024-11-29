using System;
using System.Linq;
using System.Collections.Generic;

// Definição da classe Contrato, que contém as propriedades Nome, Departamento, Dias e ValorDiaria.
class Contrato
{
    public string Nome { get; set; }          // Nome do contrato
    public string Departamento { get; set; }  // Departamento associado ao contrato
    public int Dias { get; set; }             // Número de dias do contrato
    public decimal ValorDiaria { get; set; }  // Valor diário do contrato
}

class Program
{
    static void Main(string[] args)
    {
        // Leitura do orçamento a partir da entrada do usuário e conversão para decimal.
        decimal orcamento = decimal.Parse(Console.ReadLine());

        // Leitura dos contratos, separados por ';', a partir da entrada do usuário.
        string[] contratos = Console.ReadLine().Split(';');

        // Criação de uma lista de objetos do tipo Contrato a partir dos dados fornecidos.
        List<Contrato> listaContratos = contratos.Select(c =>
        {
            // Divisão dos dados do contrato individual por ','.
            var dados = c.Split(',');
            return new Contrato
            {
                Nome = dados[0],                         // Atribui o nome do contrato
                Departamento = dados[1],                // Atribui o departamento
                Dias = int.Parse(dados[2]),             // Atribui o número de dias do contrato
                ValorDiaria = decimal.Parse(dados[3])   // Atribui o valor diário do contrato
            };
        }).ToList();

        // TODO: Calcule o custo total de todos os contratos na lista.
        decimal custoTotal = listaContratos.Sum(c => c.Dias * c.ValorDiaria);

        // Agrupa os contratos por departamento e calcula o custo total por departamento.
        var custoPorDepartamento = listaContratos
            .GroupBy(c => c.Departamento)              // Agrupa por departamento
            .Select(g => new { Departamento = g.Key, Custo = g.Sum(c => c.Dias * c.ValorDiaria) }) // Calcula o custo por departamento
            .OrderByDescending(g => g.Custo)           // Ordena os departamentos pelo custo em ordem decrescente
            .First();                                  // Seleciona o departamento com o maior custo

        // Exibe o custo total formatado com duas casas decimais.
        Console.WriteLine($"{custoTotal:F2}");

        // Verifica se o custo total excede o orçamento e exibe a mensagem apropriada.
        Console.WriteLine(custoTotal > orcamento ? "Orcamento excedido" : "Dentro do orcamento");

        // Exibe o departamento com o maior custo.
        Console.WriteLine(custoPorDepartamento.Departamento);
    }
}