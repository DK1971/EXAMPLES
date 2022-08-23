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
			// Задача 47. Задайте двумерный массив размером m×n, 
			// заполненный случайными вещественными числами.
							
				Random random = new Random();
				int rows = random.Next(4, 8);
                		int columns = random.Next(4, 8);
				double [,] array = new double [rows, columns];
				FillArray (array);
				PrintArray (array);
				
			}	

           		void Exercise_50()
			{
			// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
            		// и возвращает значение этого элемента или же указание, что такого элемента нет.
				
				Random random = new Random();
				int rows = random.Next(4, 8);
                		int columns = random.Next(4, 8);
				int [,] array = new int [rows, columns];
				FillArray(array);
				PrintArray(array);		

				Console.WriteLine("Введите номер строки: ");
				int row = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Введите номер столбца: ");
				int column = Convert.ToInt32(Console.ReadLine());

				if (row < rows && row >= 0 && column < columns && columns >= 0)
				{
					Console.WriteLine ($"Элементы {array [row, column]}");
				}
				else
				{
					Console.WriteLine ($"Элементы не существуют");
				}
				
			}	

           		void Exercise_52()
			{
			// Задача 52. Задайте двумерный массив из целых чисел. 
            		// Найдите среднее арифметическое элементов в каждом столбце.
            		
				Random random = new Random();
				int rows = 3;
                		int columns = 5;
				int [,] array = new int [rows, columns];
				FillArray (array, 0, 10);
				PrintArray (array);	

				Console.WriteLine();
				for (int j = 0; j < columns; j++)
				{
					double sum = 0;
					for (int i = 0; i < rows; i++)
					{
						sum += array[i,j];
					}
				Console.Write(Math.Round(sum / rows, 2) + "\t");
				}
				
			}	


       		//Exercise_47();
        	//Exercise_50();
        	//Exercise_52();

       
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
