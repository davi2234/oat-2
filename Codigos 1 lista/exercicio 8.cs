using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Primeiro Valor");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo Valor");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Terceiro Valor");
            int c = int.Parse(Console.ReadLine());

            if ( a > b )
            {
                int temp = a;
                a = b;
                b = temp;

            }if ( b > c ) { 
                int temp = b;
                b = c;
                c = temp;

            
            } if ( a > b ) {
                int temp = a;
                a = b;
                b = temp;

            
            } Console.WriteLine("Valores em ordem decrescente: " + c + "," + b + "," + a);
        }
    }
}
