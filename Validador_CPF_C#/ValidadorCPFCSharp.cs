using System;

class ValidadorCPFCSharp
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o CPF a ser validado: ");
        var cpf = Console.ReadLine();

        if (ValidarCPF(cpf))
        {
            Console.WriteLine($"O CPF " + cpf + " é válido!");
        }
        else
        {
            Console.WriteLine($"O CPF " + cpf + " é inválido!");
        }
    }

    public static bool ValidarCPF(string cpf)
    {
        // Verifica se o valor digitado é nulo ou vazio
        if (string.IsNullOrEmpty(cpf))
        return false;

        // Ignora os pontos e traços contidos no cpf digitado
        cpf = cpf.Replace(".", "").Replace("-", "");

        // Verifica se o CPF tem uma quantidade de caracteres diferente de onze
        if (cpf.Length != 11)
        return false;

        // Verifica se todos os caracteres do CPF são dígitos
        if (!cpf.All(char.IsDigit))
        return false;

        // Transforma os valores da variável CPF em um array
        var cpfArray = cpf.ToCharArray();
        
        // Primeira Parte (Primeiro Dígito Verificador)
        var peso = 10;
        var soma = 0;

        for (var i = 0; i < 9; i++)
        soma += (cpfArray[i] - '0') * peso--;
        var resto = soma % 11;

        if (resto < 2)
            resto = 0;
        else
            resto = 11 - resto;

        if ((cpfArray[9] - '0') != resto)
            return false;

        // Segunda Parte (Segundo Dígito Verificador)
        peso = 11;
        soma = 0;

        for (var i = 0; i < 10; i++)
        soma += (cpfArray[i] - '0') * peso--;
        resto = soma % 11;

        if (resto < 2)
            resto = 0;
        else
            resto = 11 - resto;

        if ((cpfArray[10] - '0') != resto)
            return false;

    return true;
    }
}