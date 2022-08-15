using System;
using System.Linq;

namespace Exercise
{
	class Program
	{
		static void Main(string[] args)
		{	
 			void Exercise_34()
			{
				// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
                // Напишите программу, которая покажет количество чётных чисел в массиве.
                // Output: [345, 897, 568, 234] -> 2

				Random random = new Random();
				int size = random.Next(5, 11); //длина массива от 5 до 10
				int [] array = new int [size];
				FillArray (array, 100, 999);
				PrintArray (array);

				int count = 0;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] % 2 == 0) count++;
				}
				Console.WriteLine();
				Console.WriteLine($"В массиве четных чисел - {count}.");
				Console.WriteLine();

				void FillArray (int[]array, int startN = -10, int finishN = 10)
				{
					finishN++;
					Random random = new Random();
					for (int i = 0; i < array.Length; i++)
					{
						array [i] = random.Next(startN, finishN);
					}
				}
				void PrintArray (int[]array)
				{
					Console.WriteLine();
					Console.WriteLine("Вывод массива: ");
					for (int i = 0; i < array.Length; i++)
					{
						Console.Write(array[i] + "\t");
					}
					Console.WriteLine();
				}		

            }
			void Exercise_36()
			{
				// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
				// Найдите сумму элементов, стоящих на нечётных позициях. 
                // Output: [3, 7, 23, 12] -> 19 или [-4, -6, 89, 6] -> 0
				
				Random random = new Random();
				int size = random.Next(5, 11);
				int [] array = new int [size];
				int sum = 0;
				FillArray (array, 1, 10);
				PrintArray (array);

				for (int i = 1; i < array.Length; i+=2)
				{
					sum += array[i];
				}
			
				Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях - {sum}.");
				Console.WriteLine();

				/*void FillArray (int[]array, int startN = -10, int finishN = 10)
				{
					finishN++;
					Random random = new Random();
					for (int i = 0; i < array.Length; i++)
					{
						array [i] = random.Next(startN, finishN);
					}
				}
				void PrintArray (int[]array)
				{
					Console.WriteLine();
					Console.WriteLine("Вывод массива: ");
					for (int i = 0; i < array.Length; i++)
					{
						Console.Write(array[i] + "\t");
					}
					Console.WriteLine();
				}*/
            }

			void Exercise_38()
			{
				// Задача 38: Задайте массив вещественных чисел. Найдите разницу
				// между максимальным и минимальным элементов массива. 
                // Output: [3,21 7,04 22,93 -2,71 78,24] -> 75,53
               
			    double[] array = new double[5];
                Random rand = new Random();

				for (int i = 0; i < array.Length; i++)
				{
                    array[i] = Math.Round(rand.NextDouble() * 10 - 5, 2);
              		Console.Write(array[i] + "\t");
				}
				Console.WriteLine();
                double max = array [0];
				double min = array [0];
				for (int i = 1; i < array.Length; i++)
				{
                    if (array[i] > max ) max = array [i];
					else if (array[i] < max ) min = array [i];
				}
				double difference = Math.Round(max - min, 2);
				Console.WriteLine($"Разница между максимальным {max} и минимальным {min} элементами массива: {difference}");
           		Console.WriteLine();
		    }

			//Exercise_34();
			//Exercise_36();
			//Exercise_38();
			
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
