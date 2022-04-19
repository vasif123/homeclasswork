using claswooooorkkk.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace claswooooorkkk.Models
{
    class User : IAccount
    {
        public string FullName;
        public string Email;
        public string Password;


       

        public bool Passwordchecker(string password)
        {
            
                bool check = false;
                bool checker = false;


                while (check)
                {
                    bool checkLower = false;
                    bool checkUpper = false;
                    bool checkDigit = false;

                    if (password.Length >= 8)
                    {
                        foreach (char item in password )
                        {
                            if (char.IsUpper(item))
                            {
                                checkUpper = true;
                            }
                            else if (char.IsLower(item))
                            {
                                checkLower = true;
                            }
                            else if (char.IsDigit(item))
                            {
                                checkDigit = true;
                            }

                            if (checkLower == true && checkUpper && checkDigit)
                            {
                                Password = password;
                                check = false;
                                checker = true;
                                break;
                            }
                        }

                        if (checkDigit == false || checkLower == false || checkUpper == false)
                        {
                            Console.WriteLine("Sifreni Duzgun Daxil Et:");
                            password = Console.ReadLine();
                             checker = false;
                            check = false;
                    }
                    }
                    else
                    {
                        Console.WriteLine("Sifre Minimum 8 simvol Olmalidir");
                        password = Console.ReadLine();
                        checker = false;
                        check = false;
                }
                }
            return checker;
            
        }

        public string Showinfo(string FullName, string Password)
        {
            Console.WriteLine($"{FullName} {Password}");
            return FullName;
        }

        public User(string password)
        {
            Password = password;
        }
    }
}
