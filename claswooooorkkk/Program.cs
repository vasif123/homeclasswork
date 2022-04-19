using claswooooorkkk.Models;
using System;

namespace claswooooorkkk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Password Deyerini Daxil Et");
            User user = new User(Console.ReadLine());
            user.Password = "Vasii123";
        }
    }
}
