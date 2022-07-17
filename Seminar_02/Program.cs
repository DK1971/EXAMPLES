using System;
internal class Program
{
    private static void Main(string[] args)
    {
        void Example_10()
        {
        //Задача 10: Напишите программу, которая принимает на вход трёхзначное число.
        //A на выходе показывает вторую цифру этого числа.
            Console.Write("Введите число:  ");
			int numberX = Convert.ToInt32(Console.ReadLine());
			if (numberX > 99 && numberX < 1000)
            {
                Console.WriteLine("Вторая цифра числа " + (numberX/(10%10));
            }
            else
            {
                Console.WriteLine("Введенное число не трёхзначное!");
            }
        }
    
    Example_10();
    }
}
