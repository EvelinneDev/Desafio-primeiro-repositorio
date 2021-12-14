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
            int n1;
            int n2;
            int n3;

            Console.WriteLine("Digite o primeiro número:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceio número:");
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Resultado...");

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("O primeiro número é o maior!");
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("O segundo número é o maior!");
            }
            else if (n3 > n1 && n3 > n2)
            {
                Console.WriteLine("O terceiro número é o maior!");
            }
            else if (n1 == n2 && n1 == n3 && n2 == n3)
            {
                Console.WriteLine("Todos os números são iguais");
            }
            else
            {
                Console.WriteLine("Ocorreu um erro, escolha outros números");
            }



           
            
            Console.ReadLine();

        }
    }
}
