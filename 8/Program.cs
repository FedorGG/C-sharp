using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число:");
        int Number = int.Parse(Console.ReadLine());
        if (Number % 7 == 0 && Number % 23 == 0)
        {
            Console.WriteLine("Кратно");
        }
        else
        {
            int ost = Number % Number;
            Console.WriteLine("Не кратно");
        }
    }
}