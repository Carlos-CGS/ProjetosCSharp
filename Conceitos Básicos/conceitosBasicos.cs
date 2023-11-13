using System.Globalization;
using Newtonsoft.Json;

// Criação de Listas (Filas e Pilhas)

Queue<int> fila = new Queue<int>(); // << Criação de uma fila
fila.Enqueue(23); // << Adicionando valores na fila
fila.Enqueue(43);
fila.Enqueue(12);
fila.Dequeue(); // << Remove primeiro valor adionado na fila
foreach(int item in fila)
{
    Console.WriteLine(item);
}


Stack<int> pilha = new Stack<int>(); // << Criaçaõ de uma pilha
pilha.Push(32);
pilha.Push(45); // << adiciona itens a publa( um em cima do outro) ultimo a entrar, primeiro a sair
pilha.Push(87);
pilha.Pop(); // << remove itens da pilha(sempre o ultimo valor adionado)
foreach(int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
foreach(int item in pilha)
{
    Console.WriteLine(item);
}

// Criação de um Dicionário
Dictionary<string, string> estados = new Dictionary<string, string>(); // << Criação de um Dictionary
estados.Add("SP", "São Paulo");
estados.Add("RJ", "Rio de Janeiro"); // Onde Rj é a chave e Rio de Janeiro é o valor armazenado.
estados.Add("BA", "Bahia");
estados.Remove("BA"); // << Remove item do Dictionary
estados["SP"] = "São_Paulo"; //<< altera o valor das variáveis 
foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor Armazenado: {item.Value}"); // << exibe a cahve e o valor armazenado
}

string chave = "BA";
Console.WriteLine($"Verificando o elemento: {chave}");
if(estados.ContainsKey(chave))
{
    Console.WriteLine($"O valor existe: {chave}");
}
else
{
    Console.WriteLine($"Valor não existe, pode adicionar a chave: {chave}");
}


//Abaixo exemplo de como tratar uma exceção com try-catch
try{
    string[] linhas1 = File.ReadAllLines("arquivos/arquivoLeitura.txt");
    foreach (string linha1 in linhas1)   // << Este método faz a leitura de um arquivo externo
        {
            Console.WriteLine(linha1);
        }
    } catch(FileNotFoundException ex)
        {
            Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado >> {ex.Message}");
        }   // acima um exemplo de exceção especifica (especifica a exceção)

        catch(DirectoryNotFoundException ex)
        {
            Console.WriteLine($"Ocorreu um erro de leitura, diretório/pasta não encontrado >> {ex.Message}");
        } // acima um exemplo de exceção específica (não foi encontrada a pasta)

        catch(Exception ex)
        {
            Console.WriteLine($"Ocorreu uma exceção genérica >> {ex.Message}");
        }  // acima exemplo de exceção genérica.

        finally
        {
            Console.WriteLine("Programa rodou e esta sendo finalizado!");
        }


LeituraArquivo arquivo = new LeituraArquivo();  //<< Instanciei a classe leitura de outro form
var (sucess, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if(sucess)
    {
        Console.WriteLine($"Quantidade de linhas do arquivo = {quantidadeLinhas}");
        foreach(string linha in linhasArquivo)
        {
            Console.WriteLine(linha);
        } 
    }  
    else
        {
            Console.WriteLine("Não foi possível ler o arquivo!");
        }

// Como fazer um if-Ternário
int numero99 = 20;
bool ehPar = true;
// Inicio da declaração do If Ternário abaixo:
ehPar = numero99 % 2 == 0;
Console.WriteLine($"O número {numero99} é " + (ehPar ? "par" : "impar"));



// Abaixo Cerialização arquivo Json
// Para usar devo colocar no topo (using Newtonsoft.Json;)
DateTime dataAtual = DateTime.Now;

List<Venda> listaVendas3 = new List<Venda>();

Venda venda1 = new Venda(1, "Material de Escritório", 30.50M, dataAtual);
Venda venda2 = new Venda(2, "Licença Software", 120.80M, dataAtual);

listaVendas3.Add(venda1);
listaVendas3.Add(venda2); 

string arquivoSerializado = JsonConvert.SerializeObject(listaVendas3);  // << Serializa o arquivo em formato Json.
File.WriteAllText("Arquivos/vendas.json", arquivoSerializado);
Console.WriteLine(arquivoSerializado);


// chamando o método eh par
int numero43 = 43;
Console.WriteLine($"O numero {numero43} é par? = {numero43.EhPar()}");






