using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite um valor!");
            numero =  int.Parse(Console.ReadLine());
            Console.WriteLine("Seu numero é "+numero+"!");
            Console.ReadKey();
        }
    }
}
