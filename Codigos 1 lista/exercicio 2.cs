using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Digite o seu nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite Seu Sexo F (Feminino) OU M (Masculino)");
                char sexo = char.Parse(Console.ReadLine());
                Console.WriteLine("Digite o seu Estado Civil");
                string estadocivil = Console.ReadLine();

                if (sexo == 'F' && estadocivil == "casada")
                {
                    Console.WriteLine("Digite o tempo de casada em anos");
                    int anoscasada = int.Parse(Console.ReadLine());
                    Console.WriteLine(nome + " Tem " + anoscasada + " anos de casada ");
                }
                else
                {
                    Console.WriteLine(nome + " Não é casada");
                }
            }
        }
    }
}
