using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wage: ");
            int waga = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj wzrost: ");
            int wzrost = Convert.ToInt32(Console.ReadLine());           

            double bmi = waga / Math.Pow(Convert.ToDouble(wzrost) / 100, 2); 

            string raport = $"Twoje BMI wynosi: {bmi:F2} co wskazuje ";

            if (bmi < 18.5)
            {
                raport += "Niedowagę";
            }
            else if (bmi < 24.9)
            {
                raport += "Normę";
            }
            else if (bmi < 29.9)
            {
                raport += "Nadwagę";
            }
            else if (bmi < 34.9)
            {
                raport += "Otyłość I stopnia";
            }
            else if (bmi < 39.9)
            {
                raport += "Otyłość II stopnia";
            }
            else
            {
                raport += "Otyłość III stopnia";
            }
            
            Console.WriteLine(raport);
            Console.ReadKey();
        }
    }
}
