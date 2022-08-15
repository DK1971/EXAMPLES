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
				Console.Write("Введите число: ");
				string number = Console.ReadLine();
				if (number.Length > 2)
				{
				Console.WriteLine(number[2]);
				}
				else
				{
					Console.WriteLine("В числе нет третьей цифры!");
				}
			
			}
			
			void Example_15()
			{
			//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
			//и проверяет, является ли этот день выходным.
				Console.Write("Введите цифру, обозначающую день недели:  ");
				int day = Convert.ToInt32(Console.ReadLine());
				if (day == 6 || day == 7)
				{
					Console.WriteLine("Ура! Выходной!");
				}
				else if (day >= 1 && day <= 5)
				{
					Console.WriteLine("Это будний день, работай bro!");
				}
				else
				{
					Console.WriteLine("Некорректный ввод, введи цифру от 1 до 7");
				}
			
			}
			
		   //Example_10();
		   //Example_13();
		   //Example_15();
        }
    }
}
