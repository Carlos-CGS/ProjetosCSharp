using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Leitura da entrada do usuário
        string input = Console.ReadLine();

        // Processamento da entrada
        var partes = input.Split(';').Select(p => p.Trim()).ToArray();

        // Divide as partes em currículos e palavras-chave
        List<string> curriculos = partes[0].Split(',').Select(c => c.Trim()).ToList();
        List<string> palavrasChave = partes[1].Split(',').Select(p => p.Trim()).ToList();

        // Filtragem dos currículos com base nas palavras-chave
        List<string> curriculosRelevantes = FiltrarCurriculosPorPalavrasChave(curriculos, palavrasChave);

        // Verificação se há currículos relevantes
        if (curriculosRelevantes.Count == 0)
        {
            Console.WriteLine("Nenhum curriculo encontrado");
        }
        else
        {
            // Formatação da saída
            string resultado = string.Join("; ", curriculosRelevantes);
            Console.WriteLine(resultado);
        }
    }

    static List<string> FiltrarCurriculosPorPalavrasChave(List<string> curriculos, List<string> palavrasChave)
    {
        // TODO: Filtre os currículos que contêm todas as palavras-chave
        var curriculosRelevantes = curriculos
        .Where(curriculo => palavrasChave.All(palavra =>
            curriculo.IndexOf(palavra, StringComparison.OrdinalIgnoreCase) >= 0))
        .ToList();

        return curriculosRelevantes;
    }
}