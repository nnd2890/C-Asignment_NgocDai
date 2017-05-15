using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace ConsoleApplication1
{
    class Model
    {

        
        public MySqlConnection conn;
        public MySqlCommand command;

        public Model()
        {
            String connString = "Server=localhost;Database=User;Port=3306;User ID = root;Password = ";
            conn = new MySqlConnection(connString);
            conn.Open();
        }

        public void addUser()
        {
            // insert information for table
            User u = new User();
            Console.WriteLine("Input Acount");
            u.Account = Console.ReadLine();
            Console.WriteLine("Input Password");
            u.Password = Console.ReadLine();
            Console.WriteLine("Input Phone");
            u.Phone = Console.ReadLine();

            command = conn.CreateCommand();
            command.CommandText = "INSERT INTO u1 (account,password,phone) VALUES ('" + u.Account + "','" + u.Password + "','" + u.Phone + "')";
            command.ExecuteNonQuery();
            command.Dispose();
            Console.WriteLine("Add cuscces.");
        }

        public void list()
        {
            command = conn.CreateCommand();
            command.CommandText = "sellect * from u1 ";
            try
            {
                command = conn.CreateCommand();
                command.CommandText = "SELECT * From u1";
                command.ExecuteNonQuery();
                MySqlDataReader reader;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["account"]);
                    Console.WriteLine(reader["password"]);
                    Console.WriteLine(reader["phone"]);
                    Console.WriteLine("----------------");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public void delete()
        {
            User u = new User();
            command = conn.CreateCommand();
            Console.WriteLine("Input Acount");
            u.Account = Console.ReadLine();
            command.CommandText = "delete from u1 where account = '" + u.Account + "'";
            command.ExecuteNonQuery();
            Console.WriteLine("Delete success.");
        }

        public void updateUser()
        {
            User u = new User();
            Console.WriteLine("Input Acount");
            u.Account = Console.ReadLine();
            Console.WriteLine("Input new Password");
            u.Password = Console.ReadLine();
            Console.WriteLine("Input new Phone");
            u.Phone = Console.ReadLine();

            command = conn.CreateCommand();
            command.CommandText = "UPDATE u1 SET password='" + u.Password + "', phone='" + u.Phone + "' WHERE account='" + u.Account + "'";
            command.ExecuteNonQuery();
            Console.WriteLine("Update success.");
        }


    }
}
