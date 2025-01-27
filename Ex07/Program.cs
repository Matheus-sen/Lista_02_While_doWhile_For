// 7. Um ciclista deseja saber a distância total que percorreu. Para isso, o aluno deve solicitar que o usuário insira as distâncias percorridas em cada dia até que um valor negativo seja digitado. A soma das distâncias deve ser calculada e exibida utilizando as três estruturas de repetição.

double distanciaPercorrida = 0;
double distanciaTotal = 0;
int contadorDias = 1;

/*
while (distanciaPercorrida >= 0)
{
    Console.WriteLine("Digite a distância percorrida no dia " + contadorDias + " ou digite um número negativo para encerrar e ver a distância total percorrida: ");
    distanciaPercorrida = Convert.ToDouble(Console.ReadLine());
    if (distanciaPercorrida >= 0)
    {
        distanciaTotal += distanciaPercorrida;
        contadorDias++;
    }
}
contadorDias--;
Console.WriteLine("A soma das distâncias de " + contadorDias + " dias percorridos é: " + distanciaTotal);
*/

/*
do
{
    Console.WriteLine("Digite a distância percorrida no dia " + contadorDias + " ou digite um número negativo para encerrar e ver a distância total percorrida: ");

    distanciaPercorrida = Convert.ToDouble(Console.ReadLine());

    if (distanciaPercorrida >= 0)
    {
        distanciaTotal += distanciaPercorrida;
        contadorDias++;
    }

} while (distanciaPercorrida >= 0);
contadorDias--;
Console.WriteLine("A soma das distâncias de " + contadorDias + " dias percorridos é: " + distanciaTotal);
*/

/*
for (; ; )
{
    Console.WriteLine("Digite a distância percorrida no dia " + contadorDias + " ou digite um número negativo para encerrar e ver a distância total percorrida: ");

    distanciaPercorrida = Convert.ToDouble(Console.ReadLine());

    if (distanciaPercorrida < 0)
        break;

    if (distanciaPercorrida >= 0)
    {
        distanciaTotal += distanciaPercorrida;
        contadorDias++;
    }
}
contadorDias--;
Console.WriteLine("A soma das distâncias de " + contadorDias + " dias percorridos é: " + distanciaTotal);
*/