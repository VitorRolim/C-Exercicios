Aluno aluno1 = new Aluno();
aluno1.Nome = "Kauã";
//aluno1.notas = [7, 9, 4, 4];
Console.WriteLine("Digite a quantidade de bimestres");
int qtdebi = int.Parse(Console.ReadLine());
for(int i = 0; i < qtdebi; i++)
{
    Console.WriteLine("Digite as notas do aluno");
    int notasbi = int.Parse(Console.ReadLine());
    aluno1.notas.Add(notasbi);
}

Console.WriteLine($"\nO aluno {aluno1.Nome} teve as notas: ");

foreach (int nota in aluno1.notas)
{
    Console.WriteLine($"{nota}");
}

Console.WriteLine($"A média do aluno foi: {aluno1.notas.Average()}");
