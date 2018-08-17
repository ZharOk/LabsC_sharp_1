using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab1CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
			bool Active = true;
			while (Active)
			{
				Console.Clear();
                Console.WriteLine("=======================================================");
                Console.WriteLine("||                                                   ||");
                Console.WriteLine("|| Laboratory work of C# №1 ,  by Dima Bevz, IC-4102 ||");
                Console.WriteLine("||        mob.phone: +38 (063) 27 94 073             ||");
                Console.WriteLine("||       e-mail: dominusfortuna@gmail.com            ||");
                Console.WriteLine("||                                                   ||");
                Console.WriteLine("=======================================================");
                Console.WriteLine("||                                                   ||");
                Console.WriteLine("||          Internal sorting algorithm.              ||");
                Console.WriteLine("||                                                   ||");
                Console.WriteLine("=======================================================");
				Console.WriteLine("\n  Menu");
                Console.WriteLine("1. CocktailSort.");
				Console.WriteLine("0. End program.");
				int reception = 0;
				try
				{
					reception = int.Parse(Console.ReadLine());
				}
				catch
				{
					continue;
				}
				switch (reception)
				{
					case 1:
                        Laba1CSh laba1CSh = new Laba1CSh();
                        laba1CSh.Active();
						break;
					case 0:
						return;
					default:
						break;
				}
				Console.WriteLine("Press enter.");
				Console.Read();
			}
            Console.Read();
        }
	}
}
