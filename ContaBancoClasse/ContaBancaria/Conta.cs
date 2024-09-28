class ContaBancaria {

    public ContaBancaria(Titular titular, int numconta, int agencia, double saldo, double limite)
    {
        Titular = titular;
        NumConta = numconta;
        Agencia = agencia;
        Saldo = saldo;
        Limite = limite;
    }
    public int NumConta { get; set; }
    public Titular Titular { get; set; } //PEGAR INFORMAÇÃO DA CLASSE TITULAR
    public int Agencia { get; set; }
    public double Saldo { get; }
    public double Limite { get; set; }
    public int Senha { get; set; }
    //public string InformacoesConta => $"O nome do titular é {Titular.Nome}, a idade é: {Titular.Idade} e o genero é: {Titular.Genero}, o numero da conta é {NumConta}, a agência é {Agencia}, o saldo é de: R${Saldo} e o limite é de: R${Limite}";

    public void ExibirContaBancaria()
    {
        Console.WriteLine($"O nome do titular é {Titular.Nome}, a idade é: {Titular.Idade} e o genero é: {Titular.Genero}, o numero da conta é {NumConta}, a agência é {Agencia}, o saldo é de: R${Saldo} e o limite é de: R${Limite}");
    }

}
