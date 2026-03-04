public class Curso
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Duracao { get; set; }
    public string Turno { get; set; }
}

public class Universidade
{
    public string Nome { get; set; }
    public string Cidade { get; set; }
    public List<Curso> Cursos { get; set; }
}