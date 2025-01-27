// 2. Um usuário quer calcular suas despesas mensais. O exercício consiste em solicitar ao usuário que insira suas despesas, até que ele digite um valor negativo, sinalizando o fim da entrada. O aluno deve somar as despesas e apresentar o total, utilizando while, do while e for.

double despesas, total = 0;
Console.WriteLine("Digite suas despesas mensais, e para sair digite um número negativo e veja o total de despesas: ");

/*
while (true)
{
    despesas = Convert.ToDouble(Console.ReadLine());
    if (despesas < 0)
        break;
    total += despesas;
}
Console.WriteLine("O valor total de suas despesas mensais é: " + total);
*/

/*
do
{
    despesas = Convert.ToDouble(Console.ReadLine());
    if (despesas >= 0)
    {
        total += despesas;
    }
}while (despesas >= 0);
Console.WriteLine("O valor total de suas despesas mensais é: " + total);
*/

/*
for (; ;)
{
    despesas = Convert.ToDouble(Console.ReadLine());
    if (despesas < 0)
        break;
    total += despesas;
}
Console.WriteLine("O valor total de suas despesas mensais é: " + total);
*/
