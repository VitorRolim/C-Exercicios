public class Disciplina()
{
    public string NomeDisciplina { get; set; }

    public List<Aluno> alunos { get; set; } = new List<Aluno>();
}