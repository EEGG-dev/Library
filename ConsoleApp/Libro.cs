namespace ConsoleApp;

public class Libro
{
    public string Id {get; set;}
    public string Titulo {get; set;}
    public string Autor {get; set;}

    public Libro(string id, string titulo, string autor)
    {
        Id = id;
        Titulo = titulo;
        Autor = autor;
    }
}
