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
            Console.WriteLine("Digite o primeiro número:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número:");
            int numero3 = int.Parse(Console.ReadLine());

            if (numero1 < numero2 && numero1 < numero3)
            {
                Console.WriteLine("numero1 é o menor número!");
            }
            else if (numero2 < numero1 && numero2 < numero3)
            {
                Console.WriteLine("numero2 é o menor número!");
            }
            else if (numero1 < numero2 && numero1 < numero3)
            {
                Console.WriteLine("numero3 é o menor número!");
            }
            else if (numero1 == numero2 && numero2 == numero3) 
            {
                Console.WriteLine("Os números são iguais");
            }

            Console.ReadLine();

        }
    }
}
