// 8. Um atendente de suporte técnico deseja contar quantas chamadas atendeu em um dia. O aluno deverá pedir ao usuário que insira o tempo de duração de cada chamada em minutos até que ele digite 0. O programa deve calcular o total de minutos atendidos, utilizando while, do while e for;

int totalChamadas;
double duracaoChamada;
double totMinutos = 0;
int contadorChamadas = 0;

Console.WriteLine("Insira o tempo de duração de cada chamada recebida em minutos ou pressione '0' para encerrar e ver o total de minutos: ");

/*
while (true)
{
    duracaoChamada = Convert.ToDouble(Console.ReadLine());
    if (duracaoChamada == 0)
        break;
    if (duracaoChamada != 0)
    {
        totMinutos += duracaoChamada;
        contadorChamadas++;
    }
}
Console.WriteLine("O total chamadas atendidas durante o dia foi " + contadorChamadas + " e a quantidade total de minutos foi de: " + totMinutos);
*/

/*
do
{
    duracaoChamada = Convert.ToDouble(Console.ReadLine());
    if (duracaoChamada == 0)
        break;
    if (duracaoChamada != 0)
    {
        totMinutos += duracaoChamada;
        contadorChamadas++;
    }
} while (duracaoChamada != 0);
Console.WriteLine("O total chamadas atendidas durante o dia foi " + contadorChamadas + " e a quantidade total de minutos foi de: " + totMinutos);
*/

/*
for (; ; )
{
    duracaoChamada = Convert.ToDouble(Console.ReadLine());
    if (duracaoChamada == 0)
        break;
    if (duracaoChamada != 0)
    {
        totMinutos += duracaoChamada;
        contadorChamadas++;
    }
}
Console.WriteLine("O total chamadas atendidas durante o dia foi " + contadorChamadas + " e a quantidade total de minutos foi de: " + totMinutos);
*/