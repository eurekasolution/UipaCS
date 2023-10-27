using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConsoleApp1
{
    internal class Test13DB
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("DB Test");

            string connectionString = "Server=localhost;Database=csharp;Uid=csharp;Pwd=csharp;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("mysql connect ok");

                // select *

                string query = "select * from users order by idx asc";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader(); 
                
                while(reader.Read())
                {
                    // idx, id, name, pass
                    string idx = reader["idx"].ToString();
                    string name = reader["name"].ToString();
                    string pass = reader["pass"].ToString();
                    string id = reader["id"].ToString();

                    Console.WriteLine($"{idx}\t{id}\t{name}\t{pass}");
                }

            }catch(Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
