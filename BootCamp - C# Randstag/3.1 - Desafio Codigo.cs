using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Leitura do orçamento
        int budget = int.Parse(Console.ReadLine());

        // Leitura dos custos de treinamento
        var costs = Console.ReadLine()
                            .Split(',')
                            .Select(int.Parse)
                            .OrderBy(x => x)
                            .ToList();

        List<int> selectedTrainings = new List<int>();
        int totalCost = 0;

        // TODO: Implemente a lógica necessária para selecionar os treinamentos dentro do orçamento
        foreach (var cost in costs)
        {
            if (cost + totalCost <= budget)
            {
                selectedTrainings.Add(cost);
                totalCost += cost;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(string.Join(",", selectedTrainings));
    }
}