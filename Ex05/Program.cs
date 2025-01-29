//5. Um gerente de loja quer saber quantos produtos estão em estoque. O aluno deve solicitar que o usuário insira a quantidade de produtos recebidos e vendidos até que ele digite 0. Depois disso, o programa deve calcular a quantidade total de produtos em estoque, utilizando as três estruturas de repetição;

int produtoEstoque = 0;
int produtos = 0;
//int totalProdutos = produtoEstoque + produtos;

Console.WriteLine("Insira a quantidade de produtos em estoque ou digite '0' para encerrar e ver a quantidade total de produtos em estoque");

/*
while (true)
{
    produtos = Convert.ToInt32(Console.ReadLine());
    if (produtos == 0)
        break;
    produtoEstoque += produtos;
}
int totalProdutos = produtoEstoque + produtos;
Console.WriteLine("A quantidade total de produtos em estoque é: " + totalProdutos);
*/

/*
do
{
    produtos = Convert.ToInt32(Console.ReadLine());
    produtoEstoque += produtos;
}while (produtos != 0);
int totalProdutos = produtoEstoque + produtos;
Console.WriteLine("A quantidade total de produtos em estoque é: " + totalProdutos);
*/

/*
for (; ; )
{
    produtos = Convert.ToInt32(Console.ReadLine());
    if (produtos == 0)
        break;
    produtoEstoque += produtos;
}
int totalProdutos = produtoEstoque + produtos;
Console.WriteLine("A quantidade total de produtos em estoque é: " + totalProdutos);
*/