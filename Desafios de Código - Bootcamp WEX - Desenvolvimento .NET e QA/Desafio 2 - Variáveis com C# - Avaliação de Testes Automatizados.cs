using System;

namespace AvaliacaoTestesAutomatizados {
  class Program {
    static void Main(string[] args) {
      // Solicita ao usuário a entrada para o número de testes passados
      double testesPassados = Convert.ToDouble(Console.ReadLine());

      // Solicita ao usuário a entrada para o número total de testes
      double totalTestes = Convert.ToDouble(Console.ReadLine());

      // TODO: Calcule a taxa de sucesso e armazená-la na variável taxaSucesso:
      double taxaSucesso = (testesPassados/totalTestes)*100;

      // Exibe a taxa de sucesso com 2 casas decimais
      Console.WriteLine($"Taxa de sucesso: {taxaSucesso:F2}%");
    }
  }
}