using ConsoleApp;

RepositorioLibro repositorioLibro = new RepositorioLibro();

while (true)
{
    Console.WriteLine("----MENÚ----");
    Console.WriteLine("1. Registrar Libro");
    Console.WriteLine("2. Eliminar Libro");
    Console.WriteLine("3. Editar Libro");
    Console.WriteLine("4. Mostrar lista de Libros");
    Console.WriteLine("5. Salir");
    Console.WriteLine("-------------");

    Console.WriteLine("Seleccione una opcion: ");
    string opcion = Console.ReadLine();
    switch (opcion)
    {
        case "1":
            LogicaLibro.RegistrarLibro(repositorioLibro);
            break;
        case "2":
            LogicaLibro.EliminarLibro(repositorioLibro);
            break;
        case "3":
            LogicaLibro.EditarLibro(repositorioLibro);
            break;
        case "4":
            LogicaLibro.MostrarLibros(repositorioLibro);
            break;
        case "5":
            Console.WriteLine("¡Hasta Luego!");
            return;
        default:
            Console.WriteLine("Opcion invalida. Intente de nuevo.");
            break;
    }
    Console.WriteLine();
}
