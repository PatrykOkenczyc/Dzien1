using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Ćwiczenie 1 --- ");
            Console.WriteLine("Podaj dwie liczby: ");
            int liczba1 = Convert.ToInt32(Console.ReadLine());
            int liczba2 = Convert.ToInt32(Console.ReadLine());

            int suma1 = liczba1 + liczba2;

            Console.WriteLine("Liczba 1: " + liczba1);
            Console.WriteLine("Liczba 2: " + liczba2);
            Console.WriteLine("Suma: " + suma1);
            Console.WriteLine("Długość: " + suma1.ToString().Length);
            Console.ReadKey();

            
        }

    }
}
