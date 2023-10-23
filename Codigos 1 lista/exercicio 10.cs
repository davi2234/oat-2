using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu peso em kg");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe sua altura");
            double altura = double.Parse(Console.ReadLine());
            double imc;

            imc = peso / ( altura * altura);

            Console.Write("IMC = " + imc.ToString("F2") + " - Condição: ");

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Acima do peso");
            }
            else
            {
                Console.WriteLine("Obeso");
            }
    }
}
}