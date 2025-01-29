// 9. Um cliente deseja saber o total de suas compras em um supermercado. o aluno deve solicitar que o usuário insira o valor de cada compra até que ele digite 0. A soma dos valores das compras deve ser implementada usando as três estruturas de repetição;

double valorCompra;
double totalCompras = 0;

Console.WriteLine("Digite para mim o valor de cada ítem, ou pressione '0' para ver o valor total: ");
/*
while (true)
{
    valorCompra = Convert.ToDouble(Console.ReadLine());
    if (valorCompra == 0)
        break;
    if (valorCompra != 0)
    {
        totalCompras += valorCompra;
    }
}
Console.WriteLine("O valor total de sua compra é: " + totalCompras);
*/

/*
do
{
    valorCompra = Convert.ToDouble(Console.ReadLine());
    totalCompras += valorCompra;
} while (valorCompra != 0);
Console.WriteLine("O valor total de sua compra é: " + totalCompras);
*/

/*
for (; ; )
{
    valorCompra = Convert.ToDouble(Console.ReadLine());
    if (valorCompra == 0)
        break;
    if (valorCompra != 0)
    {
        totalCompras += valorCompra;
    }
}
Console.WriteLine("O valor total de sua compra é: " + totalCompras);
*/