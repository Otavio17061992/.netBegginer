using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double saldoConta = 100.0;
            Console.WriteLine("Digite o valor que deseja sacar:");
            var debitar = Convert.ToDouble(Console.ReadLine());

            saldoConta =  saldoConta - debitar;

            switch (saldoConta)
            {
                case 50.0:
                    Console.WriteLine("você debitou" + debitar);
                    break;

                case 10.0:
                    Console.WriteLine("você debitou" + debitar);

                    break;

                default:
                    break;
            }
        }
    }
}
