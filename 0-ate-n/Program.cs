using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ate_n
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número");
            int numero = Convert.ToInt32(Console.ReadLine());
            string str = "O número inserido foi: " + numero + ".";
            Console.WriteLine(str);
            for (int i = 0; i <= numero; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
