using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{//Faça um algoritmo que leia dois valores inteiros A e B se os valores forem
 //iguais deverá se somar os dois, caso contrário multiplique A por B.Ao final de
 //qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e
 //mostrar seu conteúdo na tela.
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Digite o primeiro valor inteiro");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor inteiro");
            int B = int.Parse(Console.ReadLine());
            int C = 0;

            if(A == B)
            {
                C = A + B;
            } else
            {
                C = A * B;

            }
            {
                Console.WriteLine(" O valor de C É: " + C );
            } 
        }
    }
}
