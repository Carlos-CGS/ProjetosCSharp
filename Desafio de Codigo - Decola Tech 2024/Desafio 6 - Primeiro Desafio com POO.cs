using System;

class Pessoa
{
    private string nome;
    private int idade;

    public Pessoa(string n, int i)
    {
        nome = n;
        idade = i;
    }

    public string GetNome()
    {
        return nome;
    }

    public int GetIdade()
    {
        return idade;
    }
}

class Program
{
    static void Main()
    {
        string nome = Console.ReadLine();
        int idade = int.Parse(Console.ReadLine());

        Pessoa pessoa = new Pessoa(nome, idade);

        Console.WriteLine($"Nome: {pessoa.GetNome()}, Idade: {pessoa.GetIdade()}");
    }
}