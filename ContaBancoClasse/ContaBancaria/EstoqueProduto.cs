public class EstoqueProdutos()
{
    private List<Produto> Produtos { get; set; } = new List<Produto>();


    public void AdicionaProduto(Produto produto)
    {
        Produtos.Add((produto));
        Console.WriteLine($"Produto: {produto.Nome}adicionado ao estoque");
    }

    public void ExibirProdutosEstoques()
    {
        
            if(Produtos.Count == 0)
            {
                Console.WriteLine("Estoque vazio!");
            }
            else
            {
                foreach (var produto in Produtos)
                {
                    Console.WriteLine($"A quantidade de estoque é {produto.InformacaoDetalhada}");
                }
            }
    }
}