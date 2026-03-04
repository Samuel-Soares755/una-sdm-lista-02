public class Livro
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Ano { get; set; }
    public string Genero { get; set; }
}

public class Biblioteca
{
    public string Biblioteca { get; set; }
    public List<Livro> Livros { get; set; }
}