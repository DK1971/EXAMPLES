using System;
using System.Linq;

namespace Exercise
{
	class Program
	{
		static void Main(string[] args)
		{	
 			void Exercise_64()
			{
			// Задача 64: Задайте значения M и N. Напишите рекурсионный метод, 
            // который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
            // Output: M = 1; N = 9 -> "3, 6, 9"; M = 13; N = 20 -> "15, 18" 
            		 
			
				int rows = 5;
                		int columns = 6;
				int [,] array = new int [rows, columns];
				FillArray (array);
				PrintArray (array);

				for (int i = 0; i < rows; i++)
				{
				    for (int j = columns - 1; j > 0; j--)
				    {
					for (int k = 0; k < j; k++)
					{
					    if (array [i , k] < array [i, k + 1])
					    {
						int temp = array [i, k];
						array [i, k] = array [i, k + 1];
						array [i, k + 1] = temp;
					    }
					}
				    }
				}
				Console.WriteLine();
               	PrintArray(array);
			}	

            void Exercise_66()
			{
			// Задача 66: Задайте значения M и N. Напишите рекурсионный метод, 
            // который найдёт сумму натуральных элементов в промежутке от M до N.
            // Output: M = 1; N = 15 -> 120; M = 4; N = 8 -> 30	


            }

            void Exercise_68()
			{
			// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
            // Даны два неотрицательных числа M и N.
            // n = 2, m = 3 -> A(m,n) = 9
            
                Console.Write("Введите число n: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число m: ");
                int m = Convert.ToInt32(Console.ReadLine());
                int a;
                a = ackermannFunc(n, m);
                Console.WriteLine("Значение функции Аккермана (m,n): " + a);
                
                static int ackermannFunc(int n, int m)
                {
                    if (n == 0)
                        return m + 1;
                    else if (n != 0 && m == 0)
                        return ackermannFunc(n - 1, 1);
                    else if (n > 0 && m > 0)
                        return ackermannFunc(n - 1, ackermannFunc(n, m - 1));
                        return ackermannFunc(n,m);
                }
                 
            }

			//Exercise_64();
			//Exercise_66();
            //Exercise_68();

			}
			static void FillArray (int[,]array, int startN = 0, int finishN = 10)
			{
				int rows = array.GetLength(0);
				int columns = array.GetLength(1);
				finishN++;
				Random random = new Random();
				for (int i = 0; i < rows; i++)
				{
				   for (int j = 0; j < columns; j++)
				{
				array[i, j] = random.Next(startN, finishN);
				}
			    }
			}
			static void FillArray (double[,]array)
			{
			    int rows = array.GetLength(0);
			    int columns = array.GetLength(1);
			    Random random = new Random();
			    for (int i = 0; i < rows; i++)
			    {
				for (int j = 0; j < columns; j++)
				{
				    array[i , j] = Math.Round(random.NextDouble() * 10 - 5, 2);
				}
			    }
			}

			static void PrintArray (int[,]array)
			{
			    for (int i = 0; i < array.GetLength(0); i++)
				{
					for (int j = 0; j < array.GetLength(1); j++)
					{
						Console.Write(array[i, j] + "\t");
					}
					Console.WriteLine();
				}
			}      
			static void PrintArray(double[,]array)
			{
			    for (int i = 0; i < array.GetLength(0); i++)
			    {
				for (int j = 0; j < array.GetLength(1); j++)
				{
					Console.Write(array[i , j] + "\t");
				}
			Console.WriteLine();
			}
		}      
	}
}

