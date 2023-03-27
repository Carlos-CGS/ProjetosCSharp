Console.WriteLine("Digite uma letra...");
string letra = Console.ReadLine();

if (letra == "a" ||
    letra == "e" ||
    letra == "i" ||
    letra == "o" ||
    letra == "u") {
    Console.WriteLine("A letra digitada é uma Volgal");
}
else {
    Console.WriteLine("A letra digitada não é uma vogal.");
}