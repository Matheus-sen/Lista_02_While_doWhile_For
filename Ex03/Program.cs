// 3. Uma escola deseja saber quantos alunos foram aprovados em uma disciplina. O aluno deverá solicitar que o usuário insira as notas dos alunos (de 0 a 10) e, ao digitar -1, encerrará a entrada. Em seguida, deve contar quantos alunos tiveram nota maior ou igual a 6, utilizando as três estruturas de repetição.

int alunosAprovados = 0;
double nota;

/*
while (true)
{
    Console.WriteLine("Digite a nota do aluno ou digite '-1' para finalizar e ver a quantidade de aprovados: ");
    nota = Convert.ToDouble(Console.ReadLine());
    if (nota >= 6 && nota <= 10)
    {
        alunosAprovados++;
    }
    if (nota == -1)
        break;
}
Console.WriteLine("O total de alunos aprovados com nota maior ou igual a 6 é: " + alunosAprovados);
*/

/*
do
{
    Console.WriteLine("Digite a nota do aluno ou digite '-1' para finalizar e ver a quantidade de aprovados: ");
    nota = Convert.ToDouble(Console.ReadLine());
    if (nota >= 6 && nota <= 10)
    {
        alunosAprovados++;
    }
} while (nota >= 0 && nota <= 10);
Console.WriteLine("O total de alunos aprovados com nota maior ou igual a 6 é: " + alunosAprovados);
*/

/*
for (; ; )
{
    Console.WriteLine("Digite a nota do aluno ou digite '-1' para finalizar e ver a quantidade de aprovados: ");
    nota = Convert.ToDouble(Console.ReadLine());
    if (nota >= 6 && nota <= 10)
    {
        alunosAprovados++;
    }
    if (nota == -1)
        break;
}
Console.WriteLine("O total de alunos aprovados com nota maior ou igual a 6 é: " + alunosAprovados);
*/
