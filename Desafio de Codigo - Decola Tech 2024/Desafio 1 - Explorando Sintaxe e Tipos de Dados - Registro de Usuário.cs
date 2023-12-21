using System;

class Program
{
    static void Main(string[] args)
    {

// TODO: Declare as variáveis para guardar as informações de nome, email e senha:
  string registroNome = "";
  string registroEmail = "";
  string registroSenha = "";

// Obtém o email e nome do usuário a partir da entrada do console
    registroEmail = Console.ReadLine();
    registroNome = Console.ReadLine();


// TODO: Imprima a mensagem formatada com o nome do usuário e o email de registro:
    Console.WriteLine($"{registroNome}, verifique o email: {registroEmail} para ativar.");
    }
}