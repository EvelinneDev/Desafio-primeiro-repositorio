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


            //Mensagem de boas vindas para 10 novos alunos com estrutura Foreach

            String[] Alunos = { "João", "Everton", "Jessica", "Evelinne", "Cris", "Poly", "Menez", "Diego", "Junior", "Amanda" };

            foreach (String BemVindo in Alunos)
            {
                Console.WriteLine("Seja bem vindo(a), " + BemVindo + "!");
            }
            Console.ReadLine();
        }
    }
}
       
    

