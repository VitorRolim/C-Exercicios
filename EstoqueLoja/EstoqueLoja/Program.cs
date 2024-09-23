Dictionary<string, int> estoqueLoja = new Dictionary<string, int>();

Console.Write("Digite o nome do produto: ");
string nomeProduto = Console.ReadLine();
Console.Write("Digite a quantidade de produtos: ");
int qtdeProduto = int.Parse(Console.ReadLine());


estoqueLoja.Add(nomeProduto,qtdeProduto);

string produto = nomeProduto;

Console.WriteLine($"Produto: {produto}: {estoqueLoja[produto]}");


