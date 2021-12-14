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
            //Exibir Cardápio de uma pizzaria com 10 sabores de pizza.
            String[] Cardapio = { "Calabresa", "Frango", "Queijo", "Chocolate", "Portuguesa", "3 Queijos", "Cartola", "Lombo", "Frango com Catupiry", "Nordestina" };

            foreach (String Sabor in Cardapio)
            {
                Console.WriteLine("Temos o sabor: " + Sabor + "! APROVEITE A REFEIÇÃO!");
            }
           
            Console.ReadLine();
             
            
        }
    }
}
       
    

