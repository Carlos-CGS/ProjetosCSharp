using System;

class Program
{
    static int CalcularDano(int ataque, int defesa)
    {
        //TODO: Implemente a função calcular dano
        if (ataque < defesa){
          return 0;
        } else {
          return ataque - defesa;
        }
    }

    static void Main(string[] args)
    {
        int ataque = int.Parse(Console.ReadLine());

        int defesa = int.Parse(Console.ReadLine());

        int danoCausado = CalcularDano(ataque, defesa);
        Console.WriteLine("O dano causado pelo ataque foi: " + danoCausado);
    }
}