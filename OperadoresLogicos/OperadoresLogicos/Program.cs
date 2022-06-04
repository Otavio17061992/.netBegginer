using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresLogicos
{
     class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            if (a == 1)
            {
                Console.WriteLine("entrou no bloco do if");
            }

            else if ( a == 2)
            {
                Console.WriteLine( "entrou no else if");
            }
        }
    }
}
