using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutoante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 3, Criando variaveis ponto flutuante");

            double salario;
            salario = 1250.70;

            Console.WriteLine(salario);

            double idade;
            idade = 15 / 2;
            Console.WriteLine(idade);

            idade = 15.0 / 2;
            Console.WriteLine(idade);

            idade = 15 / 2.0;
            Console.WriteLine(idade);

            double divisao = 5.0 / 2;
            Console.WriteLine(divisao);

            Console.WriteLine("A execução acabou. Tecle Enter");
            Console.ReadLine();

        }
    }
}
