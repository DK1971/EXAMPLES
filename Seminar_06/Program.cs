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
                    Console.Write(temp + "\t");	
				}
			    //Console.Write(array[i] + "\t");	
			}	

            void Exercise_40()
            {
                //Задача 40: Напишите программу, которая принимает на вход три числа и 
                //проверяет, может ли существовать треугольник со сторонами такой длины.

                Console.WriteLine("Введите числа сторон треугольника: ");
				Console.Write("AB: ");
				int x = Convert.ToInt32(Console.ReadLine());
				Console.Write("BC: ");
				int y = Convert.ToInt32(Console.ReadLine());
				Console.Write("AC: ");
				int z = Convert.ToInt32(Console.ReadLine());
					
                if (x >= y + z || y >= x + z || z >= x + y)
                Console.WriteLine($"Треугольник со сторонами AB:{x}, BC:{y} и AC:{z} существовать НЕ МОЖЕТ!");
                else Console.WriteLine($"Треугольник со сторонами AB: {x}, BC: {y} и AC: {z} существовать МОЖЕТ!");
                    
            }

            void Exercise_42()
            {
                // Задача 40: Напишите программу, которая преобразовывает десятичное число в двоичное.
                // Output: 3 -> 4, 5 -> 101, 11 -> 1011

                Console.Write("Введите число: ");
				int number = Convert.ToInt32(Console.ReadLine());
				int temp = number;
                int shift = 1;
                int binNumber = 0;

                while (temp > 0)
                {
                    binNumber += temp % 2 * shift;
                    shift *= 10;
                    temp /= 2;
                }
                Console.Write($"Десятичное число: {number} в двоичной системе: {binNumber}");
            }
            void Exercise_44()
            {
                // Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
                // Первые два числа Фибоначчи: 0 и 1
                // Output: Если N = 5 -> 0 1 1 2 3; Если N = 3 -> 0 1 1; Если N = 7 -> 0 1 1 2 3 5 8




            }
            
            void Exercise_45()
            {
                // Задача 45: Напишите программу, которая будет создавать копию заданного массива
                // с помощью поэлементного копирования.

                Random random = new Random();
				int size = random.Next(5, 11);
				int[] array = new int[size];
				FillArray (array, 1, 10);
				PrintArray (array);


            }


			//Exercise_39();
			//Exercise_39_1();
            //Exercise_40();
            //Exercise_42();
            //Exercise_44();
            Exercise_45();
       
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
