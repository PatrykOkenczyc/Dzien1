﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Ćwiczenie 1 --- ");
            Console.WriteLine("Napisz przykładowe zdanie: ");
            string zdanie = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Podaj znak który ma być szukany: ");
                string szukane = Console.ReadLine();
                if (szukane.ToLower() == "koniec")
                    break;

                int iteracja = 0;
                int ilosc = 0;
                while (zdanie != null && iteracja < zdanie.Length && !(iteracja + szukane.Length > zdanie.Length))
                {

                    if (zdanie.Substring(iteracja, szukane.Length) == szukane)
                    {
                        ilosc++;
                    }                    
                    iteracja++;
                }
                Console.WriteLine($"W zdaniu '{zdanie}' wyraz/znak '{szukane}' wystąpił '{ilosc}' razy");

                Console.ReadKey();
            }
        }
    }
}
