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

         //2- Paulo é um pizzaiolo que precisa descobrir a área de uma circunferência
         //para conseguir fazer pizza perfeita e ganhar o concurso nacional. Crie um 
         //programa C# fazendo o uso das funções, que calcule a área de um círculo,
         //recebendo o raio valor 30 desejado por Paulo.
         // area = pi r^2

        float RecebeArea = Pizza(30);
        Console.WriteLine("A area da pizza deve ser de aproximadamente: " + RecebeArea + "cm");

        Console.ReadLine();

        static float Pizza(int raio)
        {
            float pi = 3.14f;
            float area = pi * (raio * raio);
            return area;
        }
       
    }
}
