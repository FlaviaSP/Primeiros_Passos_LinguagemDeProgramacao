using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContaCorrente.TotalContasCriadas);
            ContaCorrente conta = new ContaCorrente(867, 85697423);


            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contadaGabriela = new ContaCorrente(867, 858487);
            Console.WriteLine(ContaCorrente.TotalContasCriadas);



            Console.ReadLine();
        }
    }
}
