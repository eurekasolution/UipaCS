using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConsoleApp1
{
    internal class Test13DB
    {
        public static void Main13(string[] args)
        {
            Console.WriteLine("DB Test");

            string connectionString = "Server=localhost;Database=csharp;Uid=csharp;Pwd=csharp;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("mysql connect ok");
                MySqlCommand command = null;
                string query = null;

                query = "INSERT INTO users (id, name, pass) VALUES (@value1, @value2, @value3 )";
                command = new MySqlCommand(query, connection);
                // 파라미터(value1, .., value3)

                /*
                string pid = null;
                string pname = null;
                string ppass = null;

                Console.Write("id : ");
                pid = Console.ReadLine();
                Console.Write("name : ");
                pname = Console.ReadLine();
                Console.Write("pass : ");
                ppass = Console.ReadLine();


                command.Parameters.AddWithValue("@value1", pid);
                command.Parameters.AddWithValue("@value2", pname);
                command.Parameters.AddWithValue("@value3", ppass);

                int affectedRows = command.ExecuteNonQuery();
                if(affectedRows > 0)
                {
                    Console.WriteLine("Insert Ok");
                }else
                {
                    Console.WriteLine("Insert Fail");
                }

                */

                query = "UPDATE users SET pass=@value1, name=@value2 WHERE idx=@value3 ";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@value1", "4321");
                command.Parameters.AddWithValue("@value2", "아무개");
                command.Parameters.AddWithValue("@value3", "3");

                int affectedRows = command.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    Console.WriteLine("Update Ok");
                }
                else
                {
                    Console.WriteLine("Update Fail");
                }

                // DELETE FROM users WHERE 조건;

                // select *

                query = "select * from users order by idx asc";
                command = new MySqlCommand(query, connection);


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
