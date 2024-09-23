using System.Runtime.Serialization;

Dictionary<string, List<double>> Aluno = new Dictionary<string, List<double>>(1);


/*foreach(string nome in Aluno.Keys)
{
    Console.WriteLine(nome);
}*/

/*notasAlunos["João"] = new List<double> { 8.5, 9.0, 7.5 };
notasAlunos["Maria"] = new List<double> { 7.0, 8.0, 6.5 };*/

Console.WriteLine("Digite o nome do aluno");
string nomeDoAluno = Console.ReadLine();
Aluno.Add(nomeDoAluno, new List<double>() { 1 });

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Digite a nota do aluno");
    double notaAluno = double.Parse(Console.ReadLine());
    Aluno[nomeDoAluno].Add(notaAluno);
}

foreach (var notasAluno in Aluno.Values)
{
    Console.WriteLine($"Notas dos alunos: {notasAluno}");
}
{

}
foreach (var alunos in Aluno)
{
    double soma = 0;
    for (int i = 0; i < alunos.Value.Count; i++)
    {
        soma += alunos.Value[i];
    }
    double media = soma / alunos.Value.Count;
    Console.WriteLine($"Média de {alunos.Key}: {media}");
}