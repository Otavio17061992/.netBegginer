using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis_e_Tipagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   string[] flowers;
               flowers = new string[] {"Rose", "Jasmine", "Lili", "Hibiscus",
                                       "Tulip", "Sun Flower", "Petuni"};
               foreach (string flower in flowers)
                   Console.Write(flower + "\n");
               Console.Write("\nThe Number of Elements in the Array is: ");
               Console.Write(flowers.Length + "\n");
            */

            int[] arr = new int[] { 2, 10, 5, 8, 4, 11 };
            Console.WriteLine("Array Before Sorting:\n");
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("\n");
            Array.Sort(arr);
            Console.WriteLine("Array After Sorting:\n");
            foreach (int value in arr)
            {
                Console.WriteLine(value + " ");
            }
        }
    }
}
