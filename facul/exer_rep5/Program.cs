int alunoMaisAlto = 0;
int alturaAlunoMaisAlto = 0;
int alunoMaisBaixo = 0;
int alturaAlunoMaisBaixo = 0;

for (int i = 1; i <= 10; i++)
{
    Console.Write($"Informe a altura do aluno {i}: ");
    int altura = Convert.ToInt32(Console.ReadLine());

    if (i == 1)
    {
        alunoMaisAlto = i;
        alturaAlunoMaisAlto = altura;
        alunoMaisBaixo = i;
        alturaAlunoMaisBaixo = altura;
    }
    else
    {
        if (altura > alturaAlunoMaisAlto)
        {
            alunoMaisAlto = i;
            alturaAlunoMaisAlto = altura;
        }
        if (altura < alturaAlunoMaisBaixo)
        {
            alunoMaisBaixo = i;
            alturaAlunoMaisBaixo = altura;
        }
    }
}

Console.WriteLine($"O aluno mais alto é o {alunoMaisAlto}, com {alturaAlunoMaisAlto} cm de altura.");
Console.WriteLine($"O aluno mais baixo é o {alunoMaisBaixo}, com {alturaAlunoMaisBaixo} cm de altura.");
