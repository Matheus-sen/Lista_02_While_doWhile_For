// 10. Um vendedor de passagens deseja saber quantas passagens ele vendeu em um dia. O aluno deve pedir ao usuário para inserir o valor das passagens vendidas até que ele digite um valor negativo. O total de passagem vendidas deve ser calculado e apresentado utilizando while, do while e for;

double valorPassagem;
int passagemVendida = 0;

Console.WriteLine("Digite o valor de cada passagem vendida, e após finalizar insira um número negativo para ver o total de vendas: ");

/*
while (true)
{
    valorPassagem = Convert.ToDouble(Console.ReadLine());
    if (valorPassagem < 0 )
        break;
    if (valorPassagem >= 0)
        passagemVendida++;
}
Console.WriteLine("Você vendeu um total de " + passagemVendida + " passagens.");
*/

/*
do
{
    valorPassagem = Convert.ToDouble(Console.ReadLine());
    if (valorPassagem >= 0)
        passagemVendida++;
}while(valorPassagem >= 0);
Console.WriteLine("Você vendeu um total de " + passagemVendida + " passagens.");
*/

/*
for (; ; )
{
    valorPassagem = Convert.ToDouble(Console.ReadLine());
    if (valorPassagem < 0)
        break;
    if (valorPassagem >= 0)
        passagemVendida++;
}
Console.WriteLine("Você vendeu um total de " + passagemVendida + " passagens.");
*/