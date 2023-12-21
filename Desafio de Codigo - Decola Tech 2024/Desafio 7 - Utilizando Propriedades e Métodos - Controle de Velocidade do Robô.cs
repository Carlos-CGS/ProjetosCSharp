using System;

class Robo
{
    public int VelocidadeAtual { get; set; } = 0;
    public int VelocidadeMaxima { get; }
    public int VelocidadeMinima { get; }

    public Robo(int vmin, int vmax)
    {
        VelocidadeMinima = vmin;
        VelocidadeMaxima = vmax;
        VelocidadeAtual = vmin;
    }

    public void Acelerar()
    {
        if (VelocidadeAtual < VelocidadeMaxima)
        {
            VelocidadeAtual++;
        }
    }

    public void Desacelerar()
    {
        if (VelocidadeAtual > VelocidadeMinima)
        {
            VelocidadeAtual--;
        }
    }
}

class Program
{
  static void Main()
  {
    string[] valores = Console.ReadLine().Split(' ');
    int vmin = int.Parse(valores[0]);
    int vmax = int.Parse(valores[1]);

    Robo robo = new Robo(vmin, vmax);
        
    string comandos = Console.ReadLine();

    foreach (char comando in comandos)
    {
        if (comando == 'A')
        {
            robo.Acelerar();
        }
        else if (comando == 'D')
        {
            robo.Desacelerar();
        }
    }
    Console.WriteLine(robo.VelocidadeAtual);
  }
}