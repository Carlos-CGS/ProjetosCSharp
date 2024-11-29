using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Leitura da entrada como uma string
        string entrada = Console.ReadLine();

        // Separar a string e converter para uma lista de números
        decimal[] valores = entrada.Split(',').Select(decimal.Parse).ToArray();

        // Atribuir os valores às variáveis correspondentes
        decimal salarioBase = valores[0];
        int horasExtras = (int)valores[1];
        decimal valorHoraExtra = valores[2];
        decimal descontoIR = valores[3];
        decimal descontoINSS = valores[4];

        // TODO: Calcule o salário líquido
        decimal salarioLiquido = (salarioBase + (horasExtras * valorHoraExtra) - descontoIR - descontoINSS);

        // Exibição do resultado
        Console.WriteLine($"{salarioLiquido:F2}");
    }
}