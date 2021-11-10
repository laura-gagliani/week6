using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1110.ADO
{
    class DbManager : IDbManager
    {
        const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Videoteca;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void EliminaFilm(int filmId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "delete from Film where FilmId = @id ";
                command.Parameters.AddWithValue("@id", filmId);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 1)
                {
                    Console.WriteLine("\nFilm eliminato correttamente");
                }

                else
                {
                    Console.WriteLine("\nErrore nell'eliminazione");
                }
                connection.Close();

            }

        }

        public void GetAllFilms()
        {
            //qui ora ci vuole un oggetto che permetta la connessione (seguendo la connection string) al DB
            //e poi nel DB io parlo in linguaggio Sql! 
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection; //associo la connessione ad un comando
                command.CommandType = CommandType.Text; //gli stiamo dicendo che è un comando di tipo testo (scegliendo in CommandType che è un enum!)
                command.CommandText = "select * from Film";

                SqlDataReader reader = command.ExecuteReader(); //il metodo fa eseguire il mio comando e lo memorizza nel reader!
                                                                //io poi dovrò recuperare i dati da reader 

                while (reader.Read()) //ovvero "finché c'è un record da leggere", come se fosse un foreach (riga della tabella)
                {
                    var id = reader["FilmId"]; //o chiamo il nome della colonna oppure chiamo reader[0], reader[1] nell'ordine in cui compaiono nel DB
                    var titolo = reader["Titolo"];
                    var genere = reader["Genere"];
                    var durata = reader["Durata"];

                    Console.WriteLine($"{id} - {titolo} - genere: {genere} - durata: {durata} minuti");
                }
                connection.Close();

            } 
        }

        public void GetFilmByDurataMax(int durataMax)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from Film where Durata < @d";
                command.Parameters.AddWithValue("@d", durataMax);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var id = reader["FilmId"];
                    var titolo = reader["Titolo"];
                    var genere = reader["Genere"];
                    var durata = reader["Durata"];

                    Console.WriteLine($"{id} - {titolo} - genere: {genere} - durata: {durata} minuti");

                }

                connection.Close();
            }
        }

        public void GetFilmByGenere(string genere)
        {
            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from Film where Genere = @parametro";
                command.Parameters.AddWithValue("@parametro", genere);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) 
                {
                    var id = reader["FilmId"]; 
                    var titolo = reader["Titolo"];
                    //var genereFilm = reader["Genere"];
                    var durata = reader["Durata"];

                    Console.WriteLine($"{id} - {titolo} - genere: {genere} - durata: {durata} minuti");
                }
                connection.Close();
            }

        }

        public void GetFilmByGenereEDurataMin(string genere, int durataMin)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from Film where Durata < @d AND Genere = @g";
                command.Parameters.AddWithValue("@d", durataMin);
                command.Parameters.AddWithValue("@g", genere);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var id = reader["FilmId"];
                    var titolo = reader["Titolo"];
                    //var genere = reader["Genere"];
                    var durata = reader["Durata"];

                    Console.WriteLine($"{id} - {titolo} - genere: {genere} - durata: {durata} minuti");

                }

                connection.Close();
            }
        }

        public void GetFilmByTitolo(string titolo)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from Film where Titolo = @t";
                command.Parameters.AddWithValue("@t", titolo);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var id = reader["FilmId"];
                    var genere = reader["Genere"];
                    var durata = reader["Durata"];

                    Console.WriteLine($"{id} - {titolo} - genere: {genere} - durata: {durata} minuti");

                }
                
                connection.Close();
            }
        }

        public void GetNumeroDiFilm() //TODO
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "select count(*) from Film";

                int numeroFilm = (int)command.ExecuteScalar();

                Console.WriteLine($"\nNella videoteca ci sono {numeroFilm} film ");

                connection.Close();
            }
            
        }

        

        public void InserisciFilm(string titolo, string genere, int durata)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into FIlm values (@titolo, @durata, @genere)";
                command.Parameters.AddWithValue("@titolo", titolo);
                command.Parameters.AddWithValue("@durata", durata);
                command.Parameters.AddWithValue("@genere", genere);
                //ora dovrò mettere non una query ma una insert
                int rigaInserita = command.ExecuteNonQuery();

                if (rigaInserita == 1 )
                {
                    Console.WriteLine("\nFilm inserito correttamente");
                }
                else
                {
                    Console.WriteLine("\nErrore. Non è stato possibile inserire il film");
                }

                connection.Close();
            }
        }

        public void ModificaDurataFilm(int filmId, int nuovaDurata)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "update Film set Durata = @durata where FilmId = @id";
                command.Parameters.AddWithValue("@durata", nuovaDurata);
                command.Parameters.AddWithValue("@id", filmId);
                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 1)
                {
                    Console.WriteLine("\nCampo aggiornato con successo");
                }
                else
                {
                    Console.WriteLine("\nErrore nell'aggiornamento!");
                }

                connection.Close();
            }
        }
    }
}
