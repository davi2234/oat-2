using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Faça um algoritmo para receber um número qualquer e informar na tela se é
//par ou ímpar.

namespace exerciciio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número qualquer para saber se é impar ou par");
            int a = int.Parse(Console.ReadLine());

            if (2 % a == 0)
            {
                Console.WriteLine("O Número" + a + "é par");

            }
        }
    }
}
