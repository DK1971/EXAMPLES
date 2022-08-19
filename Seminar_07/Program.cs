using System;
using System.Linq;

namespace Exercise
{
	class Program
	{
		static void Main(string[] args)
		{	
 			void Exercise_47()
			{
			// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
			// Output: [1 2 3 4 5] -> [5 4 3 2 1] или [6 7 3 6] -> [6 3 7 6]
				
				Random random = new Random();
				int size = random.Next(5, 11);
				int[] array = new int[size];
				FillArray (array, 0, 10);
				PrintArray (array);
				
				int halfSize = size / 2;
				int maxIndex = size - 1;
				for (int i = 0; i < halfSize; i++)
				{
					int temp = array[i];
					array[i] = array[maxIndex - i];
					array[maxIndex - i] = temp;
				}
				PrintArray (array);	
			}	

            void Exercise_50()
			{
			// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
            // и возвращает значение этого элемента или же указание, что такого элемента нет.
							
				Random random = new Random();
				int size = random.Next(5, 11);
				int[] array = new int[size];
				FillArray (array, 0, 10);
				PrintArray (array);
				
				int halfSize = size / 2;
				int maxIndex = size - 1;
				for (int i = 0; i < halfSize; i++)
				{
					int temp = array[i];
					array[i] = array[maxIndex - i];
					array[maxIndex - i] = temp;
				}
				PrintArray (array);	
			}	

            void Exercise_52()
			{
			// Задача 52. Задайте двумерный массив из целых чисел. 
            // Найдите среднее арифметическое элементов в каждом столбце.
            		
				Random random = new Random();
				int size = random.Next(5, 11);
				int[] array = new int[size];
				FillArray (array, 0, 10);
				PrintArray (array);
				
				int halfSize = size / 2;
				int maxIndex = size - 1;
				for (int i = 0; i < halfSize; i++)
				{
					int temp = array[i];
					array[i] = array[maxIndex - i];
					array[maxIndex - i] = temp;
				}
				PrintArray (array);	
			}	

        //Exercise_47();
        //Exercise_50();
        //Exercise_52();
       
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
