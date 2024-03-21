using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
             
            
            Console.WriteLine("Podaj swoje imię");

            var name = Console.ReadLine();

            Console.WriteLine("\nPodaj miasto w którym się urodziłeś");

            var city = Console.ReadLine();
                        
            Console.WriteLine("\nPodaj rok urodzenia");

            var year = GetYear();

            Console.WriteLine("\nPodaj miesiąc urodzenia");

            var month = GetMonth();

            Console.WriteLine("\nPodaj dzień urodzenia");

            var day = GetDay(year, month);

            DateTime today = DateTime.Now;

            DateTime dateofbirth = new DateTime(year, month, day);
            
            TimeSpan difference = today - dateofbirth;

            int age = (int)(difference.Days / 365.25);


            Console.WriteLine($"Cześć {name} urodziłeś się w {city}. Masz {age} lat.");
            try
            {

            }
            finally
            {
                Console.WriteLine();
            }
            
        }
        
        private static int GetYear()
        {
           while (true)
            {
            
            if (!int.TryParse(Console.ReadLine(), out int year))
            {
                Console.WriteLine("podałeś nieprawidłowe dane. Spróbuj ponownie.");
                    continue;
            }
                return year;

            }
        }
        public static int GetMonth()
        {
            while (true)
            {

                if (!int.TryParse(Console.ReadLine(), out int month)
                    ||month >12 
                    ||month <1)
                {
                    Console.WriteLine("podałeś nieprawidłowe dane. Spróbuj ponownie.");
                    continue;
                }
                return month;

            }

        }
        public static int GetDay(int year, int month)
        {
            while (true)
            {

                if (!int.TryParse(Console.ReadLine(), out int day)
                    || day > DateTime.DaysInMonth(year, month)
                    || day < 1)
                {
                    Console.WriteLine("podałeś nieprawidłowe dane. Spróbuj ponownie.");
                    continue;
                }
                return day;

            }

        }











    }
}
    
