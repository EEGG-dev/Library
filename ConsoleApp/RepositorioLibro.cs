namespace ConsoleApp;
using Microsoft.Data.SqlClient;

public class RepositorioLibro
{
    public void Agregar(Libro libro)
    {
        string query = "INSERT INTO Libros(Id, Titulo, Autor) VALUES (@Id, @Titulo, @Autor)";
        using SqlConnection connection = new SqlConnection(CadenaConexion.VALOR);
        using SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@Id", libro.Id);
        command.Parameters.AddWithValue("@Titulo",libro.Titulo);
        command.Parameters.AddWithValue("@Autor",libro.Autor);
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }
    public List<Libro> Consultar()
    {
        string query = "SELECT Id, Titulo, Autor FROM Libros";
        List<Libro> libros = new List<Libro>();
        using SqlConnection connection = new SqlConnection(CadenaConexion.VALOR);
        using SqlCommand command = new SqlCommand(query, connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            string Id = reader.GetString(0);
            string Titulo = reader.GetString(1);
            string Autor = reader.GetString(2);
            Libro libro = new Libro(Id, Titulo, Autor);
            libros.Add(libro);
        }
        reader.Close();
        connection.Close();
        return libros;
    }

    public void Editar(Libro libro, string Id)
    {
        string query = "UPDATE Libros SET Titulo = @Titulo, Autor = @Autor WHERE Id = @Id";
        SqlConnection connection = new SqlConnection(CadenaConexion.VALOR);
        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@Id", Id);
        command.Parameters.AddWithValue("@Titulo",libro.Titulo);
        command.Parameters.AddWithValue("@Autor",libro.Autor);
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

    
    public void Eliminar(string Id)
    {
        string query = "DELETE FROM Libros WHERE Id = @Id";
        using SqlConnection connection = new SqlConnection(CadenaConexion.VALOR);
        using SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@Id", Id);
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }
}
