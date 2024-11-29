using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Ler os pesos dos critérios
        var weights = Console.ReadLine().Split(',').Select(double.Parse).ToArray();

        // Ler a quantidade de candidatos
        int numberOfCandidates = int.Parse(Console.ReadLine());

        // Inicializar variáveis para armazenar o nome do candidato com a maior pontuação e a pontuação máxima
        string topCandidate = "";
        double maxScore = double.MinValue;

        // Processar cada candidato
        for (int i = 0; i < numberOfCandidates; i++)
        {
            // Ler os dados do candidato
            var input = Console.ReadLine().Split(',');
            string name = input[0];
            var scores = input.Skip(1).Select(double.Parse).ToArray();

            // TODO: Calcule a pontuação total
            double totalScore = 0;
            for (int j = 0; j < weights.Length; j++)
            {
                totalScore += weights[j] * scores[j];
            }

            // Verificar se este candidato tem a maior pontuação
            if (totalScore > maxScore)
            {
                maxScore = totalScore;
                topCandidate = name;
            }
        }

        // Imprimir o nome do candidato com a maior pontuação
        Console.WriteLine($"Candidato {topCandidate}");
    }
}