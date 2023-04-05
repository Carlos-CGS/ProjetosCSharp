//Abaixo solicitações de input do usuário com o nome do aluno, notas da prova, teste e trabalho.
Console.WriteLine("Digite o nome do Aluno !");
string aluno = Console.ReadLine();
Console.WriteLine("Digite a nota da primeira prova !");
double prova1 = Double.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota do primeiro teste !");
double teste1 = Double.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota do primeiro trabalho !");
double trabalho1 = Double.Parse(Console.ReadLine());

//Abaixo código que cria a média do primeiro semestre, sendo que a prova tem peso dois.
double mediaSemestre = (((prova1 *2) + teste1 + trabalho1)/ 4);

//Abaixo código que verifica se a média é menor que 70 e imprimi mensagem informando se o aluno esta aprovado.
if(mediaSemestre < 70)
{
    Console.WriteLine($"O Aluno " + aluno + " está Reprovado, média do semenste - " + mediaSemestre);
} 
else 
{
    Console.WriteLine($"O Aluno " + aluno + " está Aprovado, média do semestre - " + mediaSemestre);
}
