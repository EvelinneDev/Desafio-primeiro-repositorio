using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estruturade Repetição que contabilize a velocidade do carro sem ulrapassar o limite de 200 km/h. Exibir uma mensagem no final dizendo que chegou ao limite.

            int contador = 0;
            while (contador < 201)
            {
                Console.WriteLine("O Carro está a: " + contador + "Km/h");
                contador = contador + 10;
            }

                Console.WriteLine("O carro atingiu o LIMITE DE VELOCIDADE!");
                Console.ReadLine();
             
            
        }
    }
}
       
    

