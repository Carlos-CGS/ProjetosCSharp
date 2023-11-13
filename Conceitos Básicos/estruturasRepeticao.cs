Estruturas de repetição.

FOR (para)

int numero = 5;

for(int contador = 0; contador <= 10; contador++)
{
	Console.WriteLine($"{numero} X {contador} = {numero * contador}");
}

Explicação - for(int contador = 0) = declara variavem inicando com 0.
Explicação - contador <=10 = condição para verificação.
Explicação - contador++ = incrementar a variavel declarada.
___________________________________________________________

WHILE (enquanto) - Vrf e após executa.

int numero = 5;
int contador = 0;

while(contador <=10)
{
	Console.WriteLine($"{numero} X {contador} = {numero * contador}");
contador++;

abaixo>>> exemplo de break <<<
if (contador <=5)
{
	break;
}
>>> exemplo debrak acima <<<<<<

}


Explicação - break = parar fluxo de execução.
Explicação - condição é declarada dentro do while.
Explicação - deve-se se atentar a declarar um break para não gerar um loop infinito.
____________________________________________________________

DO WHILE (Faz, Enquento) primeiro executa o coódigo , depois vrf.

int soma = 0, numero = 0;

do
{
	Console.WriteLine{"Digite um numero (digite 0 para parar)";
	numero = Convert.ToInt32(Console.ReadLine());   <<< teve de converter o valor recebido de string para inteiro.

soma += numero;     <<<< pega o numero digitado e adicona a variavel soma.

}while(numero != 0);  <<< condição para parar loop, se o valor digitado for diferente de zero.


_____________________________________________________________

MENU INTERATIVO

string opcao;
bool exibirMenu = true;

while(exibirMenu)
{
	Console.WriteLine("Digite uma opção:");
	Console.WriteLine("1 - Cadastrar cliente");
	Console.WriteLine("2 - Apagar cliente");
	Console.WriteLine("3 - Sair do programa");

	opcao = Console.ReadLine();
	
	switch(opcao)
	{
		case "1":
		Console.WriteLine("Cadastro de Cliente");
		break;

		case "2":
		Console.WriteLine("Apagar Cliente");

		case "3":
		Console.WriteLine("Encerrar");
		exibirMenu = false;
ou poderia usar Environment.Exit(0);
		break;

		default:
		Console.WriteLine("Opção Inválida");
		break;
	}

Console.WriteLine("O programa encerrou");

Explicação - Enviormente.Exit = encerra o porgrama por completo.
Explicação - uma opção para sair do swith sme enecerrar o programa foi o exibir menu true ou false.
