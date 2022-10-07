using System;
using System.Globalization;

namespace taskkk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int BirthDay = System.DateTime.Now.Month;
            //int DateTime = System.DateTime.Now.Year;
            

            //while (!int.TryParse(Console.ReadLine(), out year) || year < 0 || year > 2022)
            //{
            //    Console.WriteLine("");
            //}


            DateTime localDate = DateTime.Now;
            Console.WriteLine("Dogum ilinizi daxil edin");
            int year;
            year = int.Parse(Console.ReadLine());

            int age = localDate.Year - year;
            Console.WriteLine(age);


           // Console.WriteLine(localDate.Year);
        }
    }
}