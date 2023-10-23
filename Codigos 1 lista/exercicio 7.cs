using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Programa para saber se o número e par ou impar");
            Console.WriteLine("Digite um número para saber se e impar ou par");
            int a = int.Parse(Console.ReadLine());

             if (a % 2 == 0)
                a += 5;
             else
            {
                a += 8;
            } Console.WriteLine("Resultado: " + a);


        }
    }
}

