using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Lab2CSharp
{

    class Program
    {

        private static FileInfo ArrFile = new FileInfo();
        private static string chek;
        static void Main(string[] args)
        {
            MainMenu();
            Console.Write("\nPress enter.");
            Console.ReadLine();
        }
        //вибір варіанту введення даних
        public static void ChooseInputType()
        {
            Console.Write("Do you want to generate your file?y/n ");
            chek = Console.ReadLine();
            if (chek[0] == 'y')
                ArrFile.RandomElementInput();
            else
            {
                Console.Write("Write the name of file you need to sort/n(For example 'data.txt': ");
                ArrFile.AskWay(Console.ReadLine());
            }
        }
        //вибір варіанту відкриття вихідного файлу
        public static void ChooseOutputType()
        {
            Console.Write("Show this array?y/n ");
            chek = Console.ReadLine();
            if (chek[0] == 'y')
                ArrFile.output(); 
        }
        //вибрати алгоритм
        public static void MainMenu()
        {
            bool repeat=true;
            while (repeat == true)
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
                Console.WriteLine("||          External BiSorting algorithm.            ||");
                Console.WriteLine("||                                                   ||");
                Console.WriteLine("=======================================================");
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Balanced Biphasic BiSorting");
                Console.WriteLine("0. Exit");
                int key = int.Parse(Console.ReadLine());
                if(key==1)
                {
                    ChooseInputType();
                    ChooseOutputType();
                    Console.WriteLine("Sorting can take a few minutes. Please wait.");
                    BalancedBiphasicSorting.BiSorting(ArrFile);
                    Console.Write("\nSorting has been successfully finished!");
                    ChooseOutputTypeOfRezults();
                }
                else if (key==0) 
                    repeat = false;
                else
                    Console.WriteLine("U chose nonexistent point.Try again");            
           }
        }
        //вибір варіанту виведення результатів
        public static void ChooseOutputTypeOfRezults()
        {
            bool repeat = true;
            while (repeat == true)
            {
                Console.WriteLine("\n\tMenu");
                Console.WriteLine("1. Output rezult on the screen");
                Console.WriteLine("2. Open rezult in file");
                int key = int.Parse(Console.ReadLine());
                if (key == 1)
                {
                    StreamReader Reading = new StreamReader("Result.txt");     // standarts file, open for reading
                    Console.Write(Reading.ReadToEnd()); //считываем все данные с потока и выводим на экран
                    Reading.Close();
                    Console.Write("\nPress enter.");
                    Console.ReadLine();
                    repeat = false;
                }
                else if (key == 2)
                {
                    Process.Start("Result.txt"); //Запускаем приложение
                    repeat = false;
                    Console.Write("\nPress enter.");
                    Console.ReadLine();
                }
                else Console.WriteLine("U chose nonexistent point.Try again");

            }
        }
    }
}
