using System;
internal class Program
{
    private static void Main(string[] args)
    {
        void Example_01()
        {
        // Задача 1. Определить два числа, сравнить числа - какое больше, а какое нет. 
        // Вывести результат на консоль.
           int numberA = 9;
           int numberB = 9;

           if (numberA > numberB)
           {
             Console.WriteLine("Первое число больше второго!");
           }
           else if (numberA < numberB)
           {
             Console.WriteLine("Второе число больше первого!");
           }
           else
           {
             Console.WriteLine("Числа равны!");
           }
        }
        
        void Example_02()
        {
        // Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
           int numberFirst = 9;
           int numberSecond = 3;
           int numberThird = 11;
           int max = numberFirst;
           if (max < numberSecond)
           {
              max = numberSecond;
           }
           if (max < numberThird)
           {
              max = numberThird;
           }
           Console.WriteLine(max);
           }
		
	void Example_03()
	{
	// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
	   Console.Write("Введите число:  ");
	   int numberX = Convert.ToInt32(Console.ReadLine());
	   if (numberX % 2 == 0)
	   {
	   Console.WriteLine("Число " + numberX + " четное");
	   }
	   else
	   {
           Console.WriteLine("Число " + numberX + " нечетное");
	   }
	}

	void Example_04()	
	{
	// Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
	   Console.Write("Введите число:  ");
	   int numberX = Convert.ToInt32(Console.ReadLine());
	   int count = 2;
	   while (count <= numberX)
	   {
	   if (count % 2 == 0)
		Console.WriteLine(count);
		count+=2;
	   }
	}
			
	void Example_04_1()	
	{
	   // Задача 4-1. Еще одно решение задачи 4.
	   int numberX = 11;
	   for (int i = 1; i < numberX; i++)
	   {
		if (i % 2 == 0) Console.WriteLine(i);
	   }
	}

        Example_01();
        //Example_02();
		//Example_03();
		//Example_04();	
		//Example_04_1();
    }

