using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int liczba_wylosowana = new Random().Next(1, 11);
            int liczba_uzytkownikanowa = 0;
            int liczba_uzytkownikastara = int.MaxValue;
            int ilosc_prob = 0;
            do
            {
                ilosc_prob++;
                Console.WriteLine("Podaj liczbę od 1 do 10: ");
                liczba_uzytkownikanowa = Convert.ToInt32(Console.ReadLine());
                              

                if (Math.Abs(liczba_uzytkownikanowa - liczba_wylosowana) <
                    Math.Abs(liczba_uzytkownikastara - liczba_wylosowana))
                    {
                    Console.WriteLine("Ciepło");

                    }
                else Console.WriteLine("Zimno");
                liczba_uzytkownikastara = liczba_uzytkownikanowa;


            } while (liczba_wylosowana != liczba_uzytkownikanowa);

            Console.WriteLine($"Gratulacje! Wygrałeś potrzebowałeś {ilosc_prob} prób.");
            Console.ReadKey();
        }
    }
}
