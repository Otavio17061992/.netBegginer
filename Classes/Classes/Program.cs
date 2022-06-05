using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "Ray Carneiro";
            pessoa1.CPF = "1233223324";
            pessoa1.NumeroContaCorrente = "0203040";

            double valorDoDeposito;

            Console.WriteLine(" Digite o Quanto deseja Depositar?");
            valorDoDeposito = double.Parse(Console.ReadLine()); 

            Console.WriteLine("O valor da conta corrente é de: "+ pessoa1.EfetuarDeposito(valorDoDeposito));
           
                


        }
    }
}
