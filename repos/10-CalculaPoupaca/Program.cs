﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculaPoupaca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto -10");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após "+ contadorMes +  " meses, você terá " + valorInvestido);

                // contadorMes = contadorMes + 1;
                //contadorMes += 1;
                contadorMes++;
            }

           

            Console.ReadLine();
        }
    }
}
