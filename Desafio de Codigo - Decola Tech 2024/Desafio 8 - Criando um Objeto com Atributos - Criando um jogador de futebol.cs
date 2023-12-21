using System;

class Jogador
{
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }
    public int Idade { get; set; }
    public string Posicao { get; set; }

    public Jogador()
    {
    }

    public static Jogador NovoJogador(string nome, string nacionalidade, int idade, string posicao)
    {
        Jogador novoJogador = new Jogador
        {
            Nome = nome,
            Nacionalidade = nacionalidade,
            Idade = idade,
            Posicao = posicao
        };
        return novoJogador;
    }
}

class Program
{
    static void Main()
    {
        string nome = Console.ReadLine();
        string nacionalidade = Console.ReadLine();
        int idade = Convert.ToInt32(Console.ReadLine());
        string posicao = Console.ReadLine();

        Jogador jogadorCriado = Jogador.NovoJogador(nome, nacionalidade, idade, posicao);

        Console.WriteLine("Jogador criado!");
        Console.WriteLine(jogadorCriado.Nome);
        Console.WriteLine(jogadorCriado.Nacionalidade);
        Console.WriteLine(jogadorCriado.Idade);
        Console.WriteLine($"Posição: {jogadorCriado.Posicao}");
    }
}
