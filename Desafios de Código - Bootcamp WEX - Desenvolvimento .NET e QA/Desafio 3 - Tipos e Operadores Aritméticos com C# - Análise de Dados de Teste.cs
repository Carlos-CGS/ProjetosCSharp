using System;

namespace AnaliseDadosTeste {
  class Program {
    static void Main(string[] args) {
      // Solicita ao usuário a quantidade de testes bem-sucedidos:
      double testesBemSucedidos = double.Parse(Console.ReadLine());

      // Solicita ao usuário a quantidade de testes totais:
      double testesTotais = double.Parse(Console.ReadLine());

      // TODO: Implemente as condições para o cálculo da taxa de sucesso:
      double taxaSucesso = (testesBemSucedidos / testesTotais)*100;

      // TODO: Implemente uma estrutura condicional (if/else) para avaliar a taxa de sucesso e tomar decisões com base nela:
      if (taxaSucesso >= 80) {
        Console.WriteLine("A funcionalidade esta pronta para lancamento.");  
      } else {
        Console.WriteLine("A funcionalidade nao esta pronta para lancamento.");  
      }
    }
  }
}