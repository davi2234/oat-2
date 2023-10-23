using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua altura");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe seu sexo ( F ( Femenino OU M (Masculino ) )");
            int sexo = int.Parse(Console.ReadLine());
            double pesoideal;

            if (sexo == 'M')
            {
                pesoideal = (72.7 * altura) - 58;

            } else if (sexo == 'F') {
                pesoideal = (62.1 * altura) - 44.7;
                    }
            else
            {
                Console.WriteLine("Sexo invalido");
                return;
            }
            Console.WriteLine("o peso ideal é " + pesoideal + " kg.");
            
               
            
            }
           

            }
        }
    

