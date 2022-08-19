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

			void Exercise_40()
         {
         // Задача 40: Напишите программу, которая принимает на вход три числа и 
         // проверяет, может ли существовать треугольник со сторонами такой длины.

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

         void Exercise_41()
         {
         // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

            Console.Write("Сколько чисел хотите ввести: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < m; i++)
            {
               Console.Write("Введите число: ");
               int number = Convert.ToInt32(Console.ReadLine());
               if (number > 0)  count++;
            }
            Console.WriteLine();
            Console.WriteLine($"Было введено {count} чисел(а) больше нуля");
         }

         void Exercise_42()
         {
         // Задача 42: Напишите программу, которая преобразовывает десятичное число в двоичное.
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

         void Exercise_43()
         {
         // Напишите программу, которая найдёт точку пересечения двух прямых, 
         // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
         // значения b1, k1, b2 и k2 задаются пользователем

            int b1 = 2;
            int k1 = 0;
            int b2 = 1;
            int k2 = 1;

            if (k1 == k2)
            {
               Console.WriteLine("Нет точки пересечения, прямые параллельны!");
            }
            else
            {
               double x = (b2 - b1)/(k1 - k2);
               double y = k1 * x + b1;
               double y2 = k2 * x + b2;
               Console.WriteLine($"Координаты точки пересечения А ({Math.Round(x,2)}, {Math.Round(y)})");
               Console.WriteLine($"Координаты точки пересечения А ({Math.Round(x,2)}, {Math.Round(y2)})");
            }
         }

         void Exercise_44()
         {
         // Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
         // Первые два числа Фибоначчи: 0 и 1
         // Output: Если N = 5 -> 0 1 1 2 3; Если N = 3 -> 0 1 1; Если N = 7 -> 0 1 1 2 3 5 8

            double numberFirst = 0;
            double numberSecond = 1;
            Console.Write ("Enter a number: ");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
               Console.Write(numberFirst + "\t");
               double temp = numberFirst;
               numberFirst = numberSecond;
               numberSecond = numberFirst + temp;
            }
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

            int [] arraySecond = new int [array.Length];
            for (int i = 0; i < size; i++)
            {
               arraySecond [i] = array [i];
            }
            PrintArray (arraySecond);
         }


		   //Exercise_39();
		   //Exercise_40();
         //Exercise_41();
         //Exercise_42();
         //Exercise_43();
         //Exercise_44();
         //Exercise_45();
       
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
