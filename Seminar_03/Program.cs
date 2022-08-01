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
			void Example_21()
			{
				//Задача 21. Напишите программу, которая принимает на вход координаты двух точек 
				//и находит расстояние между ними в 3D пространстве.
				//Output: A (3,6,8); B (2,1,-7), -> 15.84 или A (7,-5, 0); B (1,-1,9) -> 11.53
					Console.WriteLine("Введите координаты точки A");
					Console.Write("x: ");
					double x1 = Convert.ToInt32(Console.ReadLine());
					Console.Write("y: ");
					double y1 = Convert.ToInt32(Console.ReadLine());
					Console.Write("z: ");
					double z1 = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine($"Координата точки A ({x1},{y1},{z1})");

					Console.WriteLine("Введите координаты точки B");
					Console.Write("x: ");
					double x2 = Convert.ToInt32(Console.ReadLine());
					Console.Write("y: ");
					double y2 = Convert.ToInt32(Console.ReadLine());
					Console.Write("z: ");
					double z2 = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine($"Координата точки B ({x2},{y2},{z2})");
					double distance = 0;

					distance = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z2 - z1, 2));
					Console.WriteLine($"Расстояние между точками AB: {distance}");
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
		Example_21();
		//Example_23();
		}
	}
}
