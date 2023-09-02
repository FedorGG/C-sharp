Console.WriteLine("Введите число N:");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Целые числа в промежутке от -N до N:");
        for (int i = -N; i <= N; i++)
        {
            Console.WriteLine(i);
        }