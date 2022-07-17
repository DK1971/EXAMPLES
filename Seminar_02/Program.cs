using System;

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			void Example_10()
			{
			//Задача 10: Напишите программу, которая принимает на вход трёхзначное число,
			//а на выходе показывает вторую цифру этого числа.
				Console.Write("Введите трёхзначное число:  ");
				int numberX = Convert.ToInt32(Console.ReadLine());
				if (numberX > 99 && numberX < 1000)
				{
					Console.WriteLine("Вторая цифра числа " + (numberX/10%10));
				}
				else
				{
					Console.WriteLine("Введенное число не трёхзначное!");
				}
			}
			
			void Example_13()
			{
			//Напишите программу, которая с помощью деления выводит третью цифру заданного числа
			//или сообщает, что третьей цифры нет.
			
			
			}
			
			void Example_15()
			{
			//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
			//и проверяет, является ли этот день выходным.
			
			
			}

		   //Example_10();
		   //Example_13();
		   //Example_15();
        }
    }
}
