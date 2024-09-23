Dictionary<string, string> quiz = new Dictionary<string, string>();

quiz.Add("Qual a capital do Rio de janeiro?", "Rio de Janeiro");
quiz.Add("Qual a capital do Brasil?", "Brasilia");
quiz.Add("Quem ganhou o Goty de 2020", "The Last of Us 2");

int pontuacao = 0;

foreach(var pergunta in quiz)
{
    Console.WriteLine(pergunta.Key);
    string resposta = Console.ReadLine();
    if(resposta == pergunta.Value)
    {
        Console.WriteLine("Parabéns a resposta esta certa");
        pontuacao++;
        Console.WriteLine("Sua pontuação é de: "+ pontuacao);
    }
    else
    {
        Console.WriteLine("Que pena voce errou");
    }
}