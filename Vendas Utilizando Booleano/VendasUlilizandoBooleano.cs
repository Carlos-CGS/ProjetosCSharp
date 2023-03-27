int quantidadeEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
Console.WriteLine($"Quantidade Compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if (possivelVenda)
{
    Console.WriteLine("Venda Realizda!");
}
else
{
    Console.WriteLine("Desculpe, não temos a quantidade em estoque.");
}
