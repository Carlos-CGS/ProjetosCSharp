using System;

class Desafio {
  public static void Main() {
    int quantidadeEntradas = 3;
      
    while (quantidadeEntradas > 0) {
      var numeroQuantidade = Int32.Parse(Console.ReadLine());
        
      if (numeroQuantidade >= 1 && numeroQuantidade <= 500) {
        string[] tartarugas = Console.ReadLine().Split(" ");
        var maiorVelocidade = Int32.Parse(tartarugas[0]);
          
// TODO: Crie as outras condições necessárias para a resolução do desafio:
        for ( int i = 1; i < numeroQuantidade; i++ ) {
          var tartaruga = Int32.Parse(tartarugas[i]);
            
          if ( tartaruga > maiorVelocidade ) {
            maiorVelocidade = tartaruga;
          }
        }

        if( maiorVelocidade < 10) {
          Console.WriteLine(1);
        } else if ( maiorVelocidade >= 10 && maiorVelocidade < 20) {
          Console.WriteLine(2);
        } else if ( maiorVelocidade >= 20) {
          Console.WriteLine(3);
        }
        quantidadeEntradas--;
      } else {
        Console.WriteLine("Insira um número entre 1 e 500");
      }
    }
  }
}
