using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using taskkk.Interfaces;

namespace taskkk.Models
{
    internal class User:IAccount
    {
        private string _fullname;
        public string FullName
        {
            get => _fullname;
            set
            {
                while (!FullNameChekcer(value))
                {
                    Console.WriteLine("Adiniz en azi 2 herfden ibaret olmalidir");
                    value = Console.ReadLine();

                }
                _fullname = value;
            }
        }
        private string _email;
        public string Email
        {
            get => _email;
            set
            {
                Regex email= new Regex(@"^[\w -\.] +@([\w -] +\.) +[\w -]{ 2,4}$");
                if (email.IsMatch(value))
                {
                    _email = value;
                }
                else
                {
                    Console.WriteLine("Duzgun email addresi daxil edin");
                    value = Console.ReadLine();
                }
            }
        }
        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                while (!PasswordChecker(value))
                {
                    Console.WriteLine("passwordda en azi 8 herf olmalidir");
                    value=Console.ReadLine();
                }
                _password = value;
            }
        }

        public bool PasswordChecker(string str)
        {
            
            if (str.Length<8)
            {
                
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Fullname:{_fullname}; Email:{_email}");
        }
        public User( string fullName, string email, string password)
        {
            FullName = fullName;
            Email = email;
            Password = password;
            
        }

        public bool FullNameChekcer(string fullname)
        {
            string[] arr = fullname.Split();
            bool check = true;
            if (arr.Length != 2) return false;
            if (arr[0].Length < 2 || arr[1].Length < 2) return false;

            foreach (char item in arr[0])
            {
                if (!char.IsLetter(item))
                {
                    check = false;
                }
            }

            foreach (char item in arr[1])
            {
                if (!char.IsLetter(item))
                {
                    check = false;
                }
            }

            return check;
        }
    }
}
