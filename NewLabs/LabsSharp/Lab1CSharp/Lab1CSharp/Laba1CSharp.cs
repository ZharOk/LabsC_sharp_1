using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab1CSharp
{
	class Laba1CSh
	{
		private int[] mainArr;

		public void Active()
		{
			bool Started = true;
			while (Started)
			{
				Console.Clear();
                Console.WriteLine("1. Read Array from keyboard.");
                Console.WriteLine("2. Read Array from file.");
                Console.WriteLine("3. Generate Array with random numbers.");
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
				OutputArr(mainArr);
				CocktailSort(mainArr);
				OutputArr(mainArr);
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
				Console.WriteLine("Can't open file " + filename);
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
				auxiliaryArr[i] = rand.Next(100);
			}
			return auxiliaryArr;
		}

		int[] CocktailSort(int[] auxiliaryArr)
		{
            Console.WriteLine("Sorting can take a few minutes. Please wait.");
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i <= auxiliaryArr.Length - 2; i++)
                {
                    if (auxiliaryArr[i] > auxiliaryArr[i + 1]) //перевірка чи два елементи знаходяться в неправильному порядку
                    {
                        int temp = auxiliaryArr[i];
                        auxiliaryArr[i] = auxiliaryArr[i + 1];
                        auxiliaryArr[i + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
                swapped = false;
                for (int i = auxiliaryArr.Length - 2; i >= 0; i--)
                {
                    if (auxiliaryArr[i] > auxiliaryArr[i + 1])
                    {
                        int temp = auxiliaryArr[i];
                        auxiliaryArr[i] = auxiliaryArr[i + 1];
                        auxiliaryArr[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
			return auxiliaryArr;
		}

		void OutputArr (int[] auxiliaryArr)
		{
			for (int i = 0; i < auxiliaryArr.Length; i++)
			{
				Console.Write(auxiliaryArr[i] + " ");
            }
			Console.WriteLine("");
		}
	}
}
