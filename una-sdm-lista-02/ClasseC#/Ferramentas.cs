public class Ferramenta
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Marca { get; set; }
    public int Quantidade { get; set; }
    public double Preco { get; set; }
}

public class Deposito
{
    public string Deposito { get; set; }
    public string Localizacao { get; set; }
    public List<Ferramenta> Ferramentas { get; set; }
}