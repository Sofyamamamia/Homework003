//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//5 ->
//1 | 1
//2 | 8
//3 | 27
//4 | 64
//5 | 125

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число N:");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Число | Куб");
        Console.WriteLine("------|-----");

        for (int i = 1; i <= N; i++)
        {
            int cube = i * i * i;
            Console.WriteLine($"{i.ToString().PadLeft(5)} | {cube.ToString().PadLeft(5)}");
        }

        Console.ReadLine();
    }
}