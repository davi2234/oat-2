﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            int c = int.Parse(Console.ReadLine());

            
            if (a + b < c)
            {
                Console.WriteLine("A soma de A e B é menor do que C.");
            }
            else
            {
                Console.WriteLine("A soma de A e B é maior ou igual a C.");
            }
        }
    }
}
