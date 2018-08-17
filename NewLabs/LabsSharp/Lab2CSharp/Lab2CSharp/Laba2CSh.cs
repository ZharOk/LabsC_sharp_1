using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab2CSharp
{

    class FileInfo
    {
        private string path;            // name and path to standarts file
        private int key;               // size of standarts file in kilobytes
        public string getPath()
        {
            return path;
        }    //отримати шлях до файлу
        public int TakeScale()
        {
            return key;
        }       //отримати розмір
        public void AskWay(string standarts)
        {
            path = standarts;
        }  
        public void setFileS(int standarts)
        {
            key = standarts;
        }  
        public void RandomElementInput()                               //generate RandomElement file
        {
            Console.WriteLine("Please input name of generete file(*.txt): ");
            AskWay(Console.ReadLine());
            Console.WriteLine("Input number of array elements : ");
            setFileS(int.Parse(Console.ReadLine()));

            Random RandomElement = new Random();
            StreamWriter WF = new StreamWriter(path);    // standarts file, open for writing
            for (int i = 0; i < key; i++)
            {
                string tmp = Convert.ToString(RandomElement.Next(1, 200));
                WF.Write(tmp + "\n");
            }
            WF.Close();
        }
        public void output()                                    // output file
        {
            Console.WriteLine("File " + path + ": ");
            StreamReader Reading = new StreamReader(path);     // standarts file, open for reading
            Console.Write(Reading.ReadToEnd()); //считываем все данные с потока и выводим на экран
            Reading.Close();
        }
    }

    class BalancedBiphasicSorting
    {
        public static void BiSorting(FileInfo File)
        {
            bool sorted = false;
            string path = File.getPath();
            while (!sorted)
            {
                StreamReader RF = new StreamReader(path);
                path = "Result.txt";
                StreamWriter WF1 = new StreamWriter("help1.txt");    // temporary files, open for writing
                StreamWriter WF2 = new StreamWriter("help2.txt");    // to sort the standarts file
                int help1 = int.Parse(RF.ReadLine());
                int help2= 1;
                WF1.Write(help1 + " \n");
                while (!RF.EndOfStream)
                {
                    help2 = int.Parse(RF.ReadLine());
                    if (help2 < help1) 
                    {
                        help1 = help2;
                        WF2.Write(help2 + " \n");   //записати у 2 тимчасовий файл
                    }
                    else
                    {
                        help1 = help2;
                        WF1.Write(help2 + " \n"); //записати у 1 тимчасовий файл
                    }
                }
                WF1.Close();
                WF2.Close();
                RF.Close();

                StreamReader RF1 = new StreamReader("help1.txt");
                StreamReader RF2 = new StreamReader("help2.txt");
                StreamWriter WF = new StreamWriter(path);
                help1 = int.Parse(RF1.ReadLine()); //зчитати елемент з 1 тимчасового файлу
                help2 = int.Parse(RF2.ReadLine()); //зчитати елемент з 2 тимчасового файлу
                while ((!RF1.EndOfStream) && (!RF2.EndOfStream)) //поки не кінець 1 і 2 тимчасового файлів
                {
                    if (help1 < help2)
                    {
                        WF.Write(help1 + " \n"); //записати у резьтуючий файл
                        help1 = int.Parse(RF1.ReadLine());
                    }
                    else
                    {
                        WF.Write(help2 + " \n"); //записати у резьтуючий файл
                        help2 = int.Parse(RF2.ReadLine());
                    }
                }
                if (RF1.EndOfStream) //якщо кінець 1 тимчасового файлу
                {
                    WF.Write(help2 + " \n");
                    while (!RF2.EndOfStream)
                    {
                        WF.Write(help2 + " \n");
                        help2 = int.Parse(RF2.ReadLine());
                    }
                    WF.Write(help2 + " \n");
                }
                else
                    if (RF2.EndOfStream) //якщо кінець 2 тимчасового файлу
                    {
                        WF.Write(help2 + " \n");
                        while (!RF1.EndOfStream)
                        {
                            WF.Write(help1 + " \n");
                            help1 = int.Parse(RF1.ReadLine());
                        }
                        WF.Write(help1 + " \n");
                    }
                RF1.Close();
                RF2.Close();
                WF.Close();

                StreamReader RF3 = new StreamReader(path);
                help1 = int.Parse(RF3.ReadLine());
                while (!RF3.EndOfStream)
                {
                    help2 = int.Parse(RF3.ReadLine());
                    if (help1 > help2) //якщо результучий файл ще не посортований, повторити ще раз процес
                    {
                        sorted = false;
                        break;
                    }
                    else
                        sorted = true;
                    help1 = help2;
                }
                RF3.Close();
            }
        }
    }
}
