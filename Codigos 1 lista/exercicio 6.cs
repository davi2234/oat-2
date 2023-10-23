using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6

{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Digite o Primeiro valor , ( FALSO OU VERDADEIRO )");
                bool a = bool.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Segundo valor , (FALSO OU VERDADEIRO)");
                bool b = bool.Parse(Console.ReadLine());

                if (a && b)
                {
                    Console.WriteLine("os dois valor escolhidos sao verdadeiros");
                }
                else if (!a && !b)
                {
                    Console.WriteLine("os dois valor escolhidos sao falsos");
                }
                else
                {
                    Console.WriteLine(" um dos valores é Verdadeiro e o outro e Falso ");


                }
            }
        }
    }
}

