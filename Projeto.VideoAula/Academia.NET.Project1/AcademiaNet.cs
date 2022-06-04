using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Variaveis_e_Tipagem;

namespace Academia.NET.Project1
{
    internal class AcademiaNet
    {
        static void Main(string[] args)
        {
            /*  double saldo = 100.0;
              saldo  -= 23.0;

              Console.WriteLine("O salado atual é: " + saldo);
            */

            List<int> intermediate_list = new List<int>();
            int index;
            for (index=0; index < 10; index++)
                intermediate_list.Add(index);
            int[] arr_sample = intermediate_list.ToArray();
            for (index=0; index < 10; index++)
                Console.WriteLine(arr_sample[index]);

        }
    }
}
