public class Veiculo
{
    public int Id { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public double Preco { get; set; }
}

public class Loja
{
    public string Loja { get; set; }
    public string Cidade { get; set; }
    public List<Veiculo> Veiculos { get; set; }
}