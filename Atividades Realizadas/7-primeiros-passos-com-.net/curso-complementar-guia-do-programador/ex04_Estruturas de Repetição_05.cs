using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Realizar contagem regressiva de 1000 a 1 para que um foguete seja lançado ao espaço.

            Console.WriteLine("A contagem regressiva foi iniciada");

            for (int Contador = 1000; Contador > 0; Contador--)
            {
            Console.WriteLine("Contagem regressiva... " + Contador );
            }
            Console.WriteLine("O FOGUETE FOI LANÇADO!!!");
            Console.ReadLine();

            
        }
    }
}
