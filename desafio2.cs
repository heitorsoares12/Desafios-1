using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int   a, b, c, d              ;
           a = int.Parse(Console.ReadLine());
           b = int.Parse(Console.ReadLine());
           c = int.Parse(Console.ReadLine());
           d = int.Parse(Console.ReadLine());
           
            
            Console.WriteLine("DIFERENCA = " +   (  a   *  b    -  c   *   d  ));
            Console.ReadKey();
        }
    }
}