using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string> { "Carlos henrique", "lucas caetano", "Vitor Felipe" };

            foreach (var item in nomes)
            {
                Console.WriteLine(" O primeiro nome é: " + item + "\n");
            }
        }
    }
}
