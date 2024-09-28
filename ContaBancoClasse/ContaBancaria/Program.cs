

Console.WriteLine("Digite o nome do titular: ");
string titular = Console.ReadLine();
Console.WriteLine("Digite a idade do titular: ");
int idade = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o genero do titular: ");
string genero = Console.ReadLine();
Titular titular1 = new Titular(titular, idade, genero);
titular1.Nome = titular;
titular1.Idade = idade;
titular1.Genero = genero;


Console.WriteLine("Digite o numero da conta: ");
int numConta = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a agência da conta: ");
int agencia = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o saldo da conta: ");
double saldo = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o limite da conta: ");
double limite = double.Parse(Console.ReadLine());

ContaBancaria conta = new ContaBancaria(titular1,numConta,agencia,saldo,limite);
/*conta.NumConta = numConta;
conta.Agencia = agencia;
conta.Saldo = saldo;
conta.Limite = limite;
conta.Titular = titular1;*/// CONECTAR DUAS CLASSES

conta.ExibirContaBancaria();


//conta.ExibirContaBancaria();

/*
 Carro lamborghini = new()
{
    AnoCarro = 2014,
    Fabricante = "lamborghini",
    Modelo = "Huracan"
};

Console.WriteLine(lamborghini.DescricaoDetalhada);

 */
Produto produto1 = new()
{
    Nome = "Computer",
    Marca = "Gigabyte",
    Preco = 2500.98,
    Estoque = 50
};

Produto produto2 = new()
{
    Nome = "Computer2",
    Marca = "MSI",
    Preco = 2500.98,
    Estoque = 50
};

EstoqueProdutos estoque = new EstoqueProdutos();

Console.WriteLine(produto2.AdicionarProduto);
Console.WriteLine(produto1.InformacaoDetalhada);
 
 
