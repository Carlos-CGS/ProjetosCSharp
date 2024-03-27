using System;

class Program
{
    static bool VerificarAtributo(string atributo, int valorMinimo, int valorMaximo, int valorAtributo)
    {
        //TODO: Implemente a função VerificarAtributo
        if (valorAtributo > valorMinimo && valorAtributo < valorMaximo){
          return true;
        } else{
          return false;
        }
    }

    static void Main(string[] args)
    {
        string atributo = Console.ReadLine();

        int valorMinimo = int.Parse(Console.ReadLine());

        int valorMaximo = int.Parse(Console.ReadLine());

        int valorAtributo = int.Parse(Console.ReadLine());
        
        if (VerificarAtributo(atributo, valorMinimo, valorMaximo, valorAtributo) == true){
          Console.WriteLine("O valor do atributo está dentro do intervalo especificado");
        }else{
          Console.WriteLine("O valor do atributo está fora do intervalo especificado");
        }
    }
}