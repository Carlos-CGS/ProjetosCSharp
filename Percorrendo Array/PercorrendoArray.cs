int[]arrayInteiros = new int[5];
arrayInteiros[0] = 23;
arrayInteiros[1] = 43;
arrayInteiros[2] = 12;
arrayInteiros[3] = 56;
arrayInteiros[4] = 87;

for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição contador: {contador} - {arrayInteiros[contador]}");
}

foreach(int valor in arrayInteiros)
{  
    Console.WriteLine(valor);
}