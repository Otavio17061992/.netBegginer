using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double saldoConta = 200.0;
            Console.WriteLine("Digite o valor que deseja sacar: ");
            var sacar = Convert.ToDouble(Console.ReadLine());


            saldoConta = saldoConta - sacar;

            if ( saldoConta > 0.0 && saldoConta < 200)
            {
                Console.WriteLine("você sacou:" + sacar);
                Console.WriteLine("Seu saldo atual é de: {0} ", saldoConta);
            } else if ( sacar > saldoConta)
            {
                Console.WriteLine("Seu saldo é insuficiente");
            }
            
            else if ( sacar > 200)
            {
                Console.WriteLine("Esse valor ultrapassa o limite diario");
            }
            

        }
    }
}
