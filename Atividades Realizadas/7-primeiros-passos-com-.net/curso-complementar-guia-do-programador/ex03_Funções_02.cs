using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício
{
    internal class Program
    {
        static void Main(string[] args)

            // Criar um programa que calcule a área de um triângulo,
            // recebendo uma base de 250 e uma altura de 350 como parâmentros
        {
            Console.WriteLine("A área do terreno é de: ");
            float AreaTriangulo = triangulo(250, 350);
            Console.WriteLine("A área do triângulo é: " + AreaTriangulo + "m²");

            Console.ReadLine();
        }

        static int triangulo(int Base , int altura)
        {
           
            int area = (Base * altura) /2;
            return area;

        }
    }
}
