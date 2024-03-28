using System;

public class ItemMagico
{
    //TODO:  Crie a classe ItemMagico com os atributos nome, descrição e poder
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int Poder { get; set; }
    
    // Construtor da Classe
    public ItemMagico(string nome, string descricao, int poder)
    {
        Nome = nome;
        Descricao = descricao;
        Poder = poder;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Recebe a entrada do usuário
        string nome = Console.ReadLine();

        string descricao = Console.ReadLine();

        int poder = int.Parse(Console.ReadLine());

        // Cria o item mágico
        ItemMagico item = new ItemMagico(nome, descricao, poder);

        // Imprime o item criado
        Console.WriteLine($"Item: {item.Nome}\nDescrição: {item.Descricao}\nPoder: {item.Poder}");
    }
}