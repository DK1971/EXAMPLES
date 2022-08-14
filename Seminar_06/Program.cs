using System;
using System.Linq;

namespace Exercise
{
	class Program
	{
		static void Main(string[] args)
		{	
 			void Exercise_39()
			{
				// Задача 39: Напишите программу, которая перевернёт одномерный массив
				// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
                // Output: [1 2 3 4 5] -> [5 4 3 2 1] или [6 7 3 6] -> [6 3 7 6]
				
				Random random = new Random();
				int size = random.Next(5, 11);
				int[] array = new int[size];
				FillArray (array, 1, 10);
				PrintArray (array);
					
				int halfSize = size / 2;
				int maxIndex = size - 1;
				for (int i = 0; i < halfSize; i++)
				{
					int temp = array[i];
					array[i] = array[maxIndex - 1];
					array[maxIndex - 1] = temp;
				}
					Console.WriteLine();
					PrintArray (array);	
			}	

			void Exercise_39_1()
			{
				// Задача 39: Напишите программу, которая перевернёт одномерный массив
				// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
                // Output: [1 2 3 4 5] -> [5 4 3 2 1] или [6 7 3 6] -> [6 3 7 6]
				
				Random random = new Random();
				int size = random.Next(5, 11);
				int[] array = new int[size];
				
				for (int i = 0; i < array.Length; i++)
				{
				array [i] = random.Next(1, 10);
				//Console.Write($"{i} \t");
				}
				Console.Write("Массив 1: ");	
				for (int i = 0; i < array.Length; i++)
				{
					Console.Write(array[i] + "\t");
				}
				Console.WriteLine();	

				
				Console.Write("Массив 2: ");
				int halfSize = size / 2;
				int maxIndex = size - 1;
				for (int i = 0; i < halfSize; i++)
				{
					int temp = array[i];
					array[i] = array[maxIndex - 1];
					array[maxIndex - 1] = temp;
				}
					//Console.Write(array[i] + "\t");	
			}	

			//Exercise_39();
			Exercise_39_1();

        }
		static void FillArray (int[]array, int startN = -10, int finishN = 10)
		{
			finishN++;
			Random random = new Random();
			for (int i = 0; i < array.Length; i++)
			{
				array [i] = random.Next(startN, finishN);
			}
		}
					
		static void PrintArray (int[]array)
		{
			Console.WriteLine("Массив: ");
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write(array[i] + "\t");
			}
			Console.WriteLine();
		}
	}
}
