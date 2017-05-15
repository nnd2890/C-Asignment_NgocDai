using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ConsoleApplication1
{
    class View
    {


        static void Main(string[] args)
        {
            int x = 0;
            
            do
            {
                Model m = new Model();
                Console.WriteLine("----------Menu-----------");
                Console.WriteLine(" 1. - Add User . ");
                Console.WriteLine(" 2. - List User . ");
                Console.WriteLine(" 3. - Delete User . ");
                Console.WriteLine(" 4. - Update User .");
                Console.WriteLine(" 5. - Exit . ");
                Console.WriteLine("Please input selected : ");
                x = Convert.ToInt32(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        m.addUser();
                        break;
                    case 2:
                        m.list();
                        break;
                    case 3:
                        m.delete();
                        break;
                    case 4:
                        m.updateUser();
                        break;
                    case 5:
                        Console.WriteLine("Exit program.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Please selected 1-5.");
                        break;
                }
            }
            while (x != 5);
        }
    }
}