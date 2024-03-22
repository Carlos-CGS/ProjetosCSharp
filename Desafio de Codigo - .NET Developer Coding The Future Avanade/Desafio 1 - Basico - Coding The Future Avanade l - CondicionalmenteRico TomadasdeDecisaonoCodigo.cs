using System;
class Program
{
    static void Main(string[] args)
    {

        int saldoTotal = int.Parse(Console.ReadLine());
        int valorSaque = int.Parse(Console.ReadLine());
        int valorFinal = saldoTotal - valorSaque;
        
        //TODO: Criar as condições necessárias para impressão da saída, vide tabela de exemplos.
        if (saldoTotal > valorSaque){
          Console.WriteLine($"Saque realizado com sucesso. Novo saldo: {valorFinal}");
        } else {
          Console.WriteLine($"Saldo insuficiente. Saque nao realizado!");
        }
    }
}