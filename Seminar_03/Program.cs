using System;

namespace Example
{
	class Program
	{
		static void Main(string[] args)
		{			
			void Example_19()
			{
			//Задача 19: Напишите программу, которая принимает на вход пятизначное число,
			//и проверяет, является ли оно палиондромом.
			Console.Write("Введите пятизначное число:  ");
			string input = Console.ReadLine();
			char[] inputArray = input.ToCharArray();
			Array.Reverse(inputArray);
			string output = new string(inputArray);
			Console.WriteLine(output);
			if (input == output)
			  Console.WriteLine("Число " + input + " является палиондромом");
			  else
			    Console.WriteLine("Число " + input + " не является палиондромом");
			Console.ReadKey();
			}
			
			void Example_23()
			{
			//Задача 23. Напишите программу, которая принимает на вход число (N)
			//и выдаёт таблицу кубов чисел от 1 до N.
			//Output: 3 -> 1, 8, 27 или 5 -> 1, 8, 27, 64, 125
         	Console.Write("Ведите число N: ");
          	double num = Convert.ToDouble(Console.ReadLine());
            	Console.WriteLine("Таблица кубов от 1 до введенного числа N:");
			for (int i = 1; i <= num; i++)
            		Console.WriteLine(i*i*i);
			Console.ReadLine();		
			}
		//Example_19();
		//Example_23();
		}
	}
}
