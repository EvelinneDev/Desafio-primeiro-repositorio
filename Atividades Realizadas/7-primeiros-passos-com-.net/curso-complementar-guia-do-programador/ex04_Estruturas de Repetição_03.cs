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
            //Exibir aos Clientes de um mercado o horário de funcionamento.

            int Hora = 7;

            while (Hora >= 7 && Hora <= 17)
            {
                Console.WriteLine("|| São " + Hora + " horas || O Mercado está aberto! ||");
                Hora++;
            }
            Console.WriteLine("O Mercado fechou! Funcionamos das 7h às 17h.");
            Console.ReadLine();
             
            
        }
    }
}
       
    

