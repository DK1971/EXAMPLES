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
			}
			Example_24();		
		}
	}
}

