using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número positivo ou negativo");
            int a = int.Parse(Console.ReadLine());
            int b = 0;

            if (a < 0)

            {
                b = a * 3;
                Console.WriteLine(" O triplo do numero " + a + " é " + b);
            } else
            {
                b = a * 2;
                Console.WriteLine(" O dobro do numero " + a + " é " + b);
            }
            
             
            
            
        }
    }
}
