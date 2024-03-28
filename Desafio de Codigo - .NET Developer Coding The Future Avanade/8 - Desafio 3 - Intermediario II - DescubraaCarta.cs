using System;

public enum Naipe { Paus = 0, Ouros = 1, Copas = 2, Espadas = 3 }
public enum Valor { As = 1, Valete = 2, Dama = 3, Rei = 4 }

public class Carta
{
    private Naipe naipe;
    private Valor valor;

    public Carta(Naipe n, Valor v)
    {
        naipe = n;
        valor = v;
    }

    public Naipe GetNaipe()
    {
        return naipe;
    }

    public Valor GetValor()
    {
        //TODO: Implemente o GetValor();
        return valor;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Input para escolher a carta desejada
        int valorEscolhido, naipeEscolhido;
        do
        {
          valorEscolhido = int.Parse(Console.ReadLine());
        } while (valorEscolhido < 1 || valorEscolhido > 4);

        do
        {
          naipeEscolhido = int.Parse(Console.ReadLine());
        } while (naipeEscolhido < 0 || naipeEscolhido > 3);

        // Criação da carta escolhida pelo usuário
        Carta cartaEscolhida = new Carta((Naipe)naipeEscolhido, (Valor)valorEscolhido);

        // Exibição da carta escolhida pelo usuário
        string nomeValor = "", nomeNaipe = "";

        switch (cartaEscolhida.GetValor())
        {
            case Valor.As:
                nomeValor = "Ás";
                break;
            case Valor.Valete:
                nomeValor = "Valete";
                break;
            case Valor.Dama:
                nomeValor = "Dama";
                break;
            case Valor.Rei:
                nomeValor = "Rei";
                break;
        }

        switch (cartaEscolhida.GetNaipe())
        {
            case Naipe.Paus:
                nomeNaipe = "Paus";
                break;
            case Naipe.Ouros:
                nomeNaipe = "Ouros";
                break;
            //TODO: Complete o código
            case Naipe.Copas:
                nomeNaipe = "Copas";
                break;
            case Naipe.Espadas:
                nomeNaipe = "Espadas";
                break;
        }

        Console.WriteLine($"Carta escolhida: {nomeValor} de {nomeNaipe}");
    }
}