using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp
{
    class Laba3CSh
    {

        private int[] mainArr;

        public void Active()
        {
            bool Started = true;
            while (Started)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("1. Read mainArr from keyboard.");
                Console.WriteLine("2. Read mainArr from file.");
                Console.WriteLine("3. Generate mainArr with random numbers.");
                Console.WriteLine("0. Return.");
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
                        mainArr = KeyboardArr();
                        break;
                    case 2:
                        mainArr = FileArr();
                        break;
                    case 3:
                        mainArr = GenerateArr();
                        break;
                    case 0:
                        return;
                    default:
                        break;
                }
                ShowArray(mainArr);
                Console.WriteLine("Enter searched element.");
                int SearchingElement = int.Parse(Console.ReadLine());
                Console.WriteLine("{0} is at index(if -1 then there is no number in mainArr) {1}\n", SearchingElement, Binsearch(mainArr, SearchingElement));
                Console.WriteLine("Press enter.");
                Console.Read();
            }
        }

        private int[] KeyboardArr()
        {
            int[] mainArr = null;

            Console.WriteLine("Enter elements :");
            string[] fissured = Console.ReadLine().Split(' ');
            try
            {
                mainArr = new int[fissured.Length];
                for (int i = 0; i < fissured.Length; i++)
                {
                    mainArr[i] = int.Parse(fissured[i]);
                }
            }
            catch
            {
                Console.WriteLine("Eror : Bad input data");
                Console.ReadLine();
                return new int[10];
            }
            return mainArr;
        }

        private int[] FileArr()
        {
            int[] mainArr = null;
            Console.WriteLine("Enter filename:");
            string filename = Console.ReadLine();
            string text;
            try
            {
                text = System.IO.File.ReadAllText(filename);
            }
            catch
            {
                Console.WriteLine("Can not open file " + filename);
                Console.ReadLine();
                return new int[10];
            }
            string[] fissured = text.Split(' ');
            try
            {
                mainArr = new int[fissured.Length];
                for (int i = 0; i < fissured.Length; i++)
                {
                    mainArr[i] = int.Parse(fissured[i]);
                }
            }
            catch
            {
                Console.WriteLine("Eror : Bad input data");
                Console.ReadLine();
                return new int[10];
            }

            return mainArr;
        }

        private int[] GenerateArr()
        {
            int[] auxiliaryArr = new int[100];
            Random rand = new Random();
            for (int i = 0; i < auxiliaryArr.Length; i++)
            {
                auxiliaryArr[i] = rand.Next((i + 1) * 10, (i + 1) * 10 + 10);
            }
            return auxiliaryArr;
        }

        void ShowArray(int[] auxiliaryArr)
        {
            for (int i = 0; i < auxiliaryArr.Length; i++)
            {
                Console.Write(auxiliaryArr[i] + " ");
            }
            Console.WriteLine("");
        }

        int Binsearch(int[] arr, int key)
        {
            int ng = 0;
            int vg = arr.Length - 1;
            int half = 0;
            int i = -1;
            while ((vg - ng > 1))
            {
                half = (vg + ng) / 2;
                if (arr[half] == key)
                {
                    i = half;
                    break;
                }
                if (arr[half] > key)
                {
                    vg = half;
                }
                else if (arr[half] < key)
                {
                    ng = half;
                }
            }

            return i;
        }
    }
}
