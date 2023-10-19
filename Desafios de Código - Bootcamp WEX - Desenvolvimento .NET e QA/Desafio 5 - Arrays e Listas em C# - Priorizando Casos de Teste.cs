using System;

namespace PriorizacaoTestes {
  class Program {
    static void Main(string[] args) {
      // TODO: Defina um array 'testes' para armazenar as complexidades dos testes:
      string[] testes = new string[3];

      // TODO: Defina um array 'complexidades' que contém as possíveis complexidades dos testes:
      string[] complexidades = {"baixa", "media", "alta"};

      for (int i = 0; i < 3; i++) {
        // Solicita ao usuário a complexidade do teste e armazena-o em testes[i]:
        testes[i] = Console.ReadLine().ToLower();
      }

      int maiorComplexidadeIndex = EncontrarMaiorComplexidadeIndex(testes, complexidades);
      string testePrioritario =  $"Teste {maiorComplexidadeIndex + 1}";

      // Aqui é exibido o teste prioritário na tela:
      Console.WriteLine($"O teste a ser executado primeiro e o " + testePrioritario +".");

      // Esse trecho aguarda a entrada do usuário antes de encerrar o programa
      Console.ReadLine();
    }

    static int EncontrarMaiorComplexidadeIndex(string[] testes, string[] complexidades) {
      int maiorIndex = 0;

      // Aqui é implementada a lógica necessária para encontrar o índice do teste com a maior complexidade:
      // Utiliza o "loop FOR" para encontrar o índice:
      for (int i = 1; i < testes.Length; i++) {
        // No trecho de código abaixo é comparado a complexidade de diferentes testes 
        // E encontra o índice do teste com a maior complexidade
        if (Array.IndexOf(complexidades, testes[i]) > Array.IndexOf(complexidades, testes[maiorIndex])) {
          maiorIndex = i;
        }
      }
      return maiorIndex;
    }
  }
}