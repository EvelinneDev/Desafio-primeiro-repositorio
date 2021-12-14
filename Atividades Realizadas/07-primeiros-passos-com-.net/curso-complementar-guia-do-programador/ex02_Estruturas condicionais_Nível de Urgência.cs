using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)

            
        {
            int urgencia;
            

            Console.WriteLine("Em uma escala de 0 a 10, digite o seu nível de urgência:");
            urgencia = int.Parse(Console.ReadLine());
           

            Console.WriteLine("Nível de Classificação:");

            if (urgencia > 0 && urgencia <= 3)
            {
                Console.WriteLine("BAIXO");
            }
            else if (urgencia > 3 && urgencia <=6)
            {
                Console.WriteLine("MÉDIO");
            }
            else if (urgencia > 6 && urgencia <= 9)
            {
                Console.WriteLine("ALTO");
            }
           
            else
            {
                Console.WriteLine("GRAVE");
            }

                      
            Console.ReadLine();

        }
    }
}
