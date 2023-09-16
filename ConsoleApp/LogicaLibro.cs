namespace ConsoleApp;

public static class LogicaLibro
{
    public static void RegistrarLibro(RepositorioLibro repositorioLibro)
    {
        Console.WriteLine("---- Registro Libros ----");

        Console.Write("Ingrese el ID del Libro: ");
        string id = Console.ReadLine();

        Console.Write("Ingrese el titulo del Libro: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese el autor del Libro: ");
        string cargo = Console.ReadLine();
    }

     public static void MostrarLibros(RepositorioLibro repositorioLibro)
    {
        
        Console.WriteLine("---- Lista de Libros ----");
        List<Libro> libros = repositorioLibro.Consultar();
        
        foreach (Libro libro in libros)
        {
            Console.WriteLine($"ID: {libro.Id} | Titulo: {libro.Titulo} | Autor: {libro.Autor}");
        }
    }

    public static void EditarLibro(RepositorioLibro repositorioLibro)
    {
        Console.WriteLine("---- Edicion Libros ----");

        Console.WriteLine("Ingrese el Id del libro que desea editar: ");
        string id = Console.ReadLine();
        Libro libro = repositorioLibro.Consultar().Find(e => e.Id == id);
        if (libro != null)
        {
            Console.Write("Ingrese el titulo del libro: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el autor del libro: ");
            string autor = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("No se encontro un libro con el Id especificado: ");
        }
    }

    public static void EliminarLibro(RepositorioLibro repositorioLibro)
    {
        Console.WriteLine("---- Eliminacion de Libros ----");
        Console.WriteLine("Ingrese el ID del libro que desea eliminar: ");
        string id = Console.ReadLine();

        repositorioLibro.Eliminar(id);
        Console.WriteLine("Libro eliminado exitosamente...");
    }
}
