using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1111.EsLibreria
{
    public class DbManagerPaperBooks : IPaperBooks
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Libreria;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        public void AddBook(PaperBook item)
        {
            using(SqlConnection connection = new SqlConnection(connectionString)) 
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into LibroCartaceo values (@titolo, @autore, @numpag, @copie)";
                command.Parameters.AddWithValue("@titolo", item.Titolo);
                command.Parameters.AddWithValue("@autore", item.Autore);
                command.Parameters.AddWithValue("@numpag", item.NumeroPagine);
                command.Parameters.AddWithValue("@copie", item.QuantitaMagazzino);

                int rows = command.ExecuteNonQuery();

                if (rows == 1)
                {
                    Console.WriteLine("\nLibro inserito con successo!");
                    }
                else
                {
                    Console.WriteLine("\nErrore nell'inserimento :(");
                }

                connection.Close();
            }
        }

        public PaperBook FindBookByISBN(int code)
        {
            PaperBook item = new PaperBook();
            int countRows = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from LibroCartaceo where IdPaperbook=@id";
                command.Parameters.AddWithValue("@id", code);
                

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    item.ISBN = (int)reader["IdPaperbook"];
                    item.Titolo = (string)reader["Titolo"];
                    item.Autore = (string)reader["Autore"];
                    item.NumeroPagine = (int)reader["NumeroPagine"];
                    item.QuantitaMagazzino = (int)reader["CopieMagazzino"];

                    countRows++;
                }
                
                connection.Close();

                if (countRows == 1)
                {
                    return item;
                }
                else if (countRows == 0)
                {
                    Console.WriteLine("\nErrore. Libro non trovato");
                    return null;
                }
                else
                {
                    Console.WriteLine("\nErrore. Codice non univoco!");
                    return null;
                }
            }
        }

        public PaperBook FindBookByTitle(string title)
        {
            PaperBook item = new PaperBook();
            int countRows = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from LibroCartaceo where Titolo=@t";
                command.Parameters.AddWithValue("@t", title);


                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    item.ISBN = (int)reader["IdPaperbook"];
                    item.Titolo = (string)reader["Titolo"];
                    item.Autore = (string)reader["Autore"];
                    item.NumeroPagine = (int)reader["NumeroPagine"];
                    item.QuantitaMagazzino = (int)reader["CopieMagazzino"];

                    countRows++;
                }

                connection.Close();

                if (countRows == 1)
                {
                    return item;
                }
                else if (countRows == 0)
                {
                    Console.WriteLine("\nLibro cartaceo non trovato");
                    return null;
                }
                else
                {
                    Console.WriteLine("\nErrore. Titolo non univoco!");
                    return null;
                }
            }
        }

        public List<PaperBook> GetBooks()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from LibroCartaceo";
                
                SqlDataReader reader = command.ExecuteReader();
                List<PaperBook> list = new List<PaperBook>();

                while (reader.Read())
                {
                    PaperBook item = new PaperBook();

                    item.ISBN = (int)reader["IDPaperbook"];
                    item.Titolo = (string)reader["Titolo"];
                    item.Autore = (string)reader["Autore"];
                    item.NumeroPagine = (int)reader["NumeroPagine"];
                    item.QuantitaMagazzino = (int)reader["CopieMagazzino"];

                    list.Add(item);
                }
                
                connection.Close();
                return list;
            }
        }

        public void ModifyStockQuantity(PaperBook item, int quantity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "update LibroCartaceo set CopieMagazzino=@q where IdPaperbook=@id";
                command.Parameters.AddWithValue("@q", quantity);
                command.Parameters.AddWithValue("@id", item.ISBN);

                int rows = command.ExecuteNonQuery();

                if (rows == 1)
                {
                    Console.WriteLine("\nCampo aggiornato con successo!");
                }
                else
                {
                    Console.WriteLine("\nErrore nell'aggiornamento :(");
                }

                connection.Close();
            }
        }
    }
}
