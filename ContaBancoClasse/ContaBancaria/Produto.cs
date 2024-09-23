public class Produto()
{
    private double preco;
    private int estoque;
    public string Nome { get; set; }
    public string Marca { get; set; }
    public double Preco {  get => preco; set {
        if(value > 0)
            {
                preco = value;
            }
            else
            {
                Console.WriteLine("Entre com um numero positivo");
            }
        } }
    public int Estoque { get => estoque ; set { 
            if(value > 0)
            {
                estoque = value;
            }
            else
            {
                Console.WriteLine("Entre com um numero positivo");
            }
        } }

    public string InformacaoDetalhada => $"O nome do produto é {Nome}, a marca é {Marca} e a quantidade no estoque é: {Estoque}";

    public void AdicionarProduto()
    {

    }
}