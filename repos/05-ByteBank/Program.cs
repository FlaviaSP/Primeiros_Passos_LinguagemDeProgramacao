using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente();

            //gabriela.nome = "Gabriela";
            //gabriela.profissao = "Desenvolvedora";
            //gabriela.cpf = "123.456.789-10";


            ContaCorrente conta = new ContaCorrente();

            //conta.titular = gabriela;
            //conta.titular = new Cliente();
            //conta.titular.nome = "Gabriela Costa";
            //conta.titular.cpf = "123.456.789-10";
            //conta.titular.profissao = "Desenvolvedora";

            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 563417;

            if(conta.titular == null)
            {
                Console.WriteLine("Ops, a referência em conta. titulart é NULL");
            }

            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular);
            //Console.WriteLine(conta.titular.nome);
            //Console.WriteLine(conta.titular.cpf);
            //Console.WriteLine(conta.titular.pro);

            Console.ReadLine();
        }
    }
}
