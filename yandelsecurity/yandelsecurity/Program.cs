using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yandelsecurity
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<User> userList = new List<User>();

            Console.WriteLine("ALPHA YANDEL SECURITY SYSTEM");
            Console.WriteLine("");
            Console.WriteLine("PROCEED TO REGISTER AN USER");
            Console.WriteLine("");


            Console.Write("USERNAME: ");
            string username = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("PASSWORD: ");
            string password = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("EMAIL: ");
            string email = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("NAME: ");
            string name = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("SURNAME: ");
            string surname = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("ADDING USER TO LIST....");

            User newuser = new User(userList.Count + 1, username, password, email, name, surname, false);
            userList.Add(newuser);

            Console.WriteLine("USER ADDED TO LIST!");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("PROCEED TO LOG IN:");

            Console.Write("USERNAME: ");
            string loginusername = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("PASSWORD: ");
            string loginpassword = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("");
            var u = userList.SingleOrDefault(un => un.Username == loginusername);
            if (u != null)
            {
                if (new User().UserLogin(u, loginusername, loginpassword))
                {
                    Console.WriteLine("LOG IN SUCCESSFULLY!");
                    Console.WriteLine("USER INFORMATION!");

                    Console.WriteLine("USERNAME: " + u.Username);
                    Console.WriteLine("RANDOM KEY: " + u.UserKey);
                    Console.WriteLine("ENCODED PASSWORD: " + u.PasswordKey);
                    Console.WriteLine("ENCODED EMAIL: " + u.EmailKey);
                    Console.WriteLine("NAME: " + u.Name);
                    Console.WriteLine("SURNAME: " + u.Surname);
                }
                else
                {
                    Console.WriteLine("YADEL SYSTEM IS PURE SHIT!");
                }
            }
            else
            {
                Console.WriteLine("U FUKIN RETARD THIS USER DOES NOT EXIST!");

            }
            Console.ReadLine();
        }
    }
}
