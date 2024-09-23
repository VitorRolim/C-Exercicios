class Carro()
{
    private int anoCarro;
    public string Modelo {  get; set; }
    public string Fabricante { get; set; }
    public int AnoCarro { get => anoCarro; set {
            if (value>1963 && value<2025)
            {
                anoCarro = value;
            }
            else
            {
                Console.WriteLine("Erro! Entre com o ano entre 1963 e 2024");
            }
        } }
    public string Tipo { get; set; }
    public string DescricaoDetalhada => $"A fabricante do carro é {Fabricante}, o modelo do carro é {Modelo} e o ano é de {AnoCarro}";
    public double velocidade = 0;

    public void Buzinar()
    {
        Console.WriteLine("Bi Bi");
    }

    public void Acelerar()
    {
        Console.WriteLine("Acelerando");
        if (velocidade > 0) {
            velocidade++;
        }
    }

    public void Frear(double velocidadeVeiculo)
    {
        Console.WriteLine("Freando");
        if (velocidade < 100)
        {
            velocidade++;
        }
    }
}