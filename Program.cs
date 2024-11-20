using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_to_verify_user_name_and_password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username, password;
            Console.WriteLine("Enter Username:");
            username = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            password = Console.ReadLine();
            if (username == "aisha.noor9341@gmail.com")
            {
                if (password == "BUKC")
                {
                    Console.WriteLine("Welcome onboard!");
                }
                else
                {
                    Console.WriteLine("Incorrect Password!");
                }
            }
            else
            {
                Console.WriteLine("Incorrect Username!");
            }
        }
    }
}
