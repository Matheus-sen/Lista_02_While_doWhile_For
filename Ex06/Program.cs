// 6. Durante uma eleição, um mesário deve contar os votos. O aluno deverá pedir ao usuário para inserir os votos (1 para candidato A, 2 para candidato B) até que ele digite 0. O programa deve contar quantos votos cada candidato recebeu, implementando a solução com while, do while e for.


int voto, candidatoA = 0, candidatoB = 0;
Console.WriteLine("Insira os votos (1 para o candidato A e 2 para o candidato B) ou pressione '0' para ver o resultado: ");

/*
while (true)
{
    voto = Convert.ToInt32(Console.ReadLine());
    if (voto == 0)
        break;
    if (voto == 1)
    {
        candidatoA++;
    }else if (voto == 2)
    {
        candidatoB++;
    }else
    {
        Console.WriteLine("Candidato não existente, favor insira 1 para o candidato A e 2 para o candidato B ");
    }
}
Console.WriteLine("A quantidade de votos de cada canditado é: \nCANDIDATO A: " + candidatoA + "\nCANDIDATO B: " + candidatoB);
*/

/*
do
{
    voto = Convert.ToInt32(Console.ReadLine());
    if (voto == 1)
    {
        candidatoA++;
    }
    else if (voto == 2)
    {
        candidatoB++;
    }
    else
    {
        Console.WriteLine("Candidato não existente, favor insira 1 para o candidato A e 2 para o candidato B ");
    }
}while (voto != 0);
Console.WriteLine("A quantidade de votos de cada canditado é: \nCANDIDATO A: " + candidatoA + "\nCANDIDATO B: " + candidatoB);
*/

/*
for (; ; )
{
    voto = Convert.ToInt32(Console.ReadLine());
    if (voto == 0)
        break;
    if (voto == 1)
    {
        candidatoA++;
    }
    else if (voto == 2)
    {
        candidatoB++;
    }
    else
    {
        Console.WriteLine("Candidato não existente, favor insira 1 para o candidato A e 2 para o candidato B ");
    }
}
Console.WriteLine("A quantidade de votos de cada canditado é: \nCANDIDATO A: " + candidatoA + "\nCANDIDATO B: " + candidatoB);
*/