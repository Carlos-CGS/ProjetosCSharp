using System;

class Program
{
    static void Main()
    {
        // Pergunta ao usuário quantos jogos deseja adicionar:
        int quantidadeJogos = int.Parse(Console.ReadLine());

        // TODO: Inicializa os arrays com base na quantidade informada pelo usuário:
       string [] nomesJogos = new string[quantidadeJogos];

        // TODO: Crei um Loop para adicionar jogos conforme a quantidade especificada:
       for (int i = 0; i < quantidadeJogos; i++){
        
        //TODO: Chame a função AdicionarJogo para obter o nome do jogo e armazená-lo no array:
         AdicionarJogo(i, nomesJogos);
        }
        // Exibe o resumo da adição de jogos
        ExibirResumoAdicaoJogos(quantidadeJogos, nomesJogos);
    }

    static void AdicionarJogo(int indice, string[] nomes)
    {
        // Entrada do nome do jogo
        nomes[indice] = Console.ReadLine();
    }

    static void ExibirResumoAdicaoJogos(int quantidadeJogos, string[] nomes)
    {
        Console.WriteLine($"Foi adicionado '{quantidadeJogos}' jogos: {string.Join(", ", nomes)} ao catalogo.");
    }
}