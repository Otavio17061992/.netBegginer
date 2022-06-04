using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDias
{
    internal class Program
    {

        enum DiasDaSemana
        {   
            Domingo = 0,
            SegundaFeira = 1,
            TerceFeira = 2,
            QuartaFeira = 3,
            QuintaFeira = 4,
            SextaFeira = 5,
            Sabado = 6,
        };


        static void Main(string[] args)
        {
            int diaDaSemana = (int)DiasDaSemana.SegundaFeira;

            Console.WriteLine("Hoje é: " + diaDaSemana );
        }
    }
}
