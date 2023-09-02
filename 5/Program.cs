Console.WriteLine("Введите трехзначное число: ");
        int value = Convert.ToInt32(Console.ReadLine());

        int lastValue = value % 10;
      Console.WriteLine("Последняя цифра трёхзначного числа: " + lastValue);