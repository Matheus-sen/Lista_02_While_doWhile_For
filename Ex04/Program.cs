// 4. Um grupo de amigos deseja calcular a idade média deles. Para isso, o aluno deve pedir que o usuário insira as idades e calcule a média até que o usuário digite 0. A solução deve ser implementada usando while, do while e for;


int idade, somaIdade = 0, contador = 0;
double idadeMedia;

Console.WriteLine("Digite a idade ou '0' para ver a média entre as idade: ");

/*
while (true)
{
    idade = Convert.ToInt32(Console.ReadLine());
    if (idade == 0)
        break;
    somaIdade += idade;
    contador++;
}
idadeMedia = somaIdade / contador;
Console.WriteLine("A média de idade é: " + idadeMedia);
*/

/*
do
{
    idade = Convert.ToInt32(Console.ReadLine());
    if (idade != 0)
    {
        somaIdade += idade;
        contador++;
    }
}while (idade != 0);
idadeMedia = somaIdade / contador;
Console.WriteLine("A média de idades é: " + idadeMedia);
*/

/*
for (; ; )
{
    idade = Convert.ToInt32(Console.ReadLine());
    if (idade == 0)
        break;
    somaIdade += idade;
    contador++;
}
idadeMedia = somaIdade / contador;
Console.WriteLine("A média de idade é: " + idadeMedia);
*/