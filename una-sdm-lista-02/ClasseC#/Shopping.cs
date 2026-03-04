public class LojaShopping
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Categoria { get; set; }
    public int Andar { get; set; }
}

public class Shopping
{
    public string Nome { get; set; }
    public string Cidade { get; set; }
    public List<LojaShopping> Lojas { get; set; }
}