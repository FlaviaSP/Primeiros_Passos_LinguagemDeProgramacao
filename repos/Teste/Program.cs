using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatorial = 5;
            int result = 1;
            int i = 1;

            //for (var i = 1; i <= fatorial; i += 1)
            //{
            //    result = result * i;
            //    Console.WriteLine(i);
            //}

            while (i <= fatorial)
            {
                result = result * i;
                Console.WriteLine(i);
                i += 1;
            }
             


            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
