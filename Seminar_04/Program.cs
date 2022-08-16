using System;

namespace Example
{
	class Program
	{
		static void Main(string[] args)
		{			
			void Example_24()
			{
				//Задача 24: Напишите программу, которая принимает на вход число (А)
               			//и выдаёт сумму чисел от 1 до А.

               			Console.Write("Введите число: ");
                		int numberA = Convert.ToInt32(Console.ReadLine());
               			int sum = 0;

                		for (int i = 1; i <= numberA; i++)
                		{
                    			sum += i;
               			}
               			Console.WriteLine($"Сумма чисел от 1 до {numberA} равна {sum}");
				Console.WriteLine();
			}
			
			void Example_25()
			{
               			//Задача 25: Используя определение степени числа, напишите цикл, который 
				//принимает на вход два натуральных числа (A и B) и возводит число A в степень B.

				Console.Write("Введите число A: ");
				int numberA = Convert.ToInt32(Console.ReadLine());
				Console.Write("Введите число B: ");
				int numberB = Convert.ToInt32(Console.ReadLine());
				int result = numberA;
				for (int i = 1; i < numberB; i++)
                		{
					result *= numberA;
				}
				Console.WriteLine($"Число {numberA} в степени {numberB} равно {result}");
				Console.WriteLine();
			}

			void Example_26()
			{
               			//Задача 26: Напишите программу, которая принимает на вход число 
				//и выдаёт количество цифр в числе.

				Console.Write("Введите число: ");
                		string input = Console.ReadLine();
				Console.WriteLine("Количество цифр в числе: " + input.Length.ToString());
				Console.WriteLine();
			}

			void Example_27()
			{
               			//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
				//Output: 452 -> 11 или 82 -> 10

				Console.Write("Введите число: ");
            			int number = Convert.ToInt32(Console.ReadLine());
				int sum = 0;
				while (number > 0)
				{
					sum += number % 10;
					number /= 10;
				}
				Console.WriteLine($"Сумма цифр в числе: {sum}");
				Console.WriteLine();
			}

			void Example_28()
			{
				//Задача 28: Напишите программу, которая принимает на вход число N 
				//и выдаёт произведение чисел от 1 до N.
				Console.Write("Введите число: ");
               			int numberA = Convert.ToInt32(Console.ReadLine());
              			int result = 1;
				int i = 1;
				while (i <= numberA)
				{
					result = result * i;
					i++;
				} 
				Console.WriteLine($"Проиведение чисел от 1 до {numberA} равно {result}");
				Console.WriteLine();
			}
			
			void Example_29()
			{
                		//Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел 
				//и выводит отсортированный по модулю массив.
				//Output: -2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
				
				int size = 8;
				int[] array = new int [size];
				Random rand = new Random();
												
				for(int i = 0; i < array.Length; i++)
				{
					array[i] = rand.Next(-10,10);		//Заполняем случайными числами от -10 до 10
				}
				Console.WriteLine("Не отсортированный массив:");				
				for (int i = 0; i < array.Length; i++)
				{
					Console.Write(array[i] + " ");
				}
				Console.WriteLine();		

				for (int i = array.Length - 1; i > 0; i--)
				{
					for (int j = 0; j < i; j++)
					{
						if (Math.Abs(array[j]) > Math.Abs(array[j + 1]))
						{
							int temp = array [j];
							array [j] = array [j + 1];
							array [j + 1] = temp;
						}
					}
				}
				Console.WriteLine("Отсортированный массив: ");	
				for (int i = 0; i < array.Length; i++)
				{
					Console.Write(array[i] + " ");
				}
				Console.WriteLine();
			}

			//Example_24();	
			//Example_25();	
			//Example_26();
			//Example_27();
			//Example_28();
			//Example_29();
		}
	}
}
