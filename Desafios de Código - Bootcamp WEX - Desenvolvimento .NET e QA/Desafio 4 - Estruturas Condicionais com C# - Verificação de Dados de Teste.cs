using System;

namespace VerificacaoDadosTeste {
  class Program {
    static void Main(string[] args) {
      // Aqui é solicitado ao usuário que insira o ID do teste:
      int idTeste;
      if (int.TryParse(Console.ReadLine(), out idTeste)) {
        // Solicita ao usuário que insira a descrição do teste:
        string descricaoTeste = Console.ReadLine();

        // Verifica se o ID do teste é válido e a descrição está dentro dos limites:
        if (idTeste > 0 && descricaoTeste.Length <= 50) {
          // TODO: Adicione um Console.WriteLine para verificar se o ID do teste é válido e a descrição está dentro dos limites:
          // TODO: Lembre-se: ID de teste valido. e Descricao valida.
          Console.WriteLine("ID de teste valido.");
          Console.WriteLine("Descricao valida.");

        } else {
          //TODO: Adicione um Console.WriteLine para verificar se o ID do teste é válido:
          //TODO: Lembre-se da validação solicitada na descrição do desafio.
          Console.WriteLine("ID de teste invalido ou descricao muito longa.");

        }
      } else {
        Console.WriteLine("ID de teste invalido.");
      }
    }
  }