using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число:");
        int fNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int sNumber = int.Parse(Console.ReadLine());
        if (fNumber % sNumber == 0)
        {
            Console.WriteLine("Второе число кратно первому");
        }
        else
        {
            int ost = fNumber % sNumber;
            Console.WriteLine("Второе число не кратно первому. Остаток от деления " + ost);
        }
    }
}