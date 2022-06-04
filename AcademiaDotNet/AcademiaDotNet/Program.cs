using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //const double pi = 3.1415;
            //double radius = 5.3;
            //double area = pi * (radius * radius);

            //console.writeline("o valor da área é:" + area);


            List<string> nomes = new List<string>();

            nomes.Add("João");
            nomes.Add("Lucas");


            Console.WriteLine("Posição da lista: " + nomes[1] + "\n" + ", Tamanho da Lista: " + nomes.Count());

            bool existeNaLista = nomes.Contains("João");

            Console.WriteLine("Existe na Lista o nome ray ?: " + existeNaLista);
        }
    }
}
