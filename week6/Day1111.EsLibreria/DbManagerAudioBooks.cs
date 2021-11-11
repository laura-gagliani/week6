using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1111.EsLibreria
{
    public class DbManagerAudioBooks : IAudioBooks
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Libreria;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void AddBook(AudioBook item)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into AudioLibro values (@titolo, @autore, @durata)"; 
                command.Parameters.AddWithValue("@titolo", item.Titolo);
                command.Parameters.AddWithValue("@autore", item.Autore);
                command.Parameters.AddWithValue("@durata", item.Durata);


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

        public AudioBook FindBookByISBN(int code)
        {
            AudioBook item = new AudioBook();
            int countRows = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from AudioLibro where IdAudiobook=@id";
                command.Parameters.AddWithValue("@id", code);


                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    item.ISBN = (int)reader["IdAudiobook"];
                    item.Titolo = (string)reader["Titolo"];
                    item.Autore = (string)reader["Autore"];
                    item.Durata = (int)reader["Durata"];

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

        public AudioBook FindBookByTitle(string title)
        {
            AudioBook item = new AudioBook();
            int countRows = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from AudioLibro where Titolo=@t";
                command.Parameters.AddWithValue("@t", title);


                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    item.ISBN = (int)reader["IdAudiobook"];
                    item.Titolo = (string)reader["Titolo"];
                    item.Autore = (string)reader["Autore"];
                    item.Durata = (int)reader["Durata"];

                    countRows++;
                }

                connection.Close();

                if (countRows == 1)
                {
                    return item;
                }
                else if (countRows == 0)
                {
                    Console.WriteLine("\nAudiolibro non trovato");
                    return null;
                }
                else
                {
                    Console.WriteLine("\nErrore. Titolo non univoco!");
                    return null;
                }
            }
        }

        public List<AudioBook> GetBooks()
        {
            throw new NotImplementedException();
        }

        public void ModifyDuration()
        {
            throw new NotImplementedException();
        }
    }
}
