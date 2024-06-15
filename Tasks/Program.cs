using System;

class Program
{
    static void Main()
    {
        // Задачи по условиям

        // Задача 1
        Console.WriteLine("Задачи по условиям");
        Console.WriteLine("Задача 1: Введите первое число:");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        double number2 = Convert.ToDouble(Console.ReadLine());

        if (number1 == number2)
        {
            Console.WriteLine("Числа равны.");
        }
        else if (number1 > number2)
        {
            Console.WriteLine("Первое число больше второго.");
        }
        else
        {
            Console.WriteLine("Первое число меньше второго.");
        }
        Console.ReadLine();

        // Задача 2
        Console.WriteLine("Задача 2: Введите число:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number >= 5 && number <= 10)
        {
            Console.WriteLine("Число больше 5 и меньше 10.");
        }
        else
        {
            Console.WriteLine("Неизвестное число.");
        }
        Console.ReadLine();

        // Задача 3
        Console.WriteLine("Задача 3: Введите число:");
        number = Convert.ToInt32(Console.ReadLine());

        if (number == 5 || number == 10)
        {
            Console.WriteLine("Число либо равно 5, либо равно 10.");
        }
        else
        {
            Console.WriteLine("Неизвестное число.");
        }
        Console.ReadLine();

        // Задача 4
        Console.WriteLine("Задача 4: Введите сумму вклада:");
        double deposit = Convert.ToDouble(Console.ReadLine());
        double finalAmount;

        if (deposit < 100)
        {
            finalAmount = deposit * 1.05;
        }
        else if (deposit <= 200)
        {
            finalAmount = deposit * 1.07;
        }
        else
        {
            finalAmount = deposit * 1.10;
        }

        Console.WriteLine($"Сумма вклада с процентами: {finalAmount}");
        Console.ReadLine();

        // Задача 5
        Console.WriteLine("Задача 5: Введите номер операции: 1. Сложение 2. Вычитание 3. Умножение");
        int operation = Convert.ToInt32(Console.ReadLine());

        switch (operation)
        {
            case 1:
                Console.WriteLine("Сложение");
                break;
            case 2:
                Console.WriteLine("Вычитание");
                break;
            case 3:
                Console.WriteLine("Умножение");
                break;
            default:
                Console.WriteLine("Операция неопределена");
                break;
        }
        Console.ReadLine();

        // Задачи по циклам

        // Задача 1
        Console.WriteLine("Задачи по циклам");
        Console.WriteLine("Задача 1: Введите сумму вклада:");
        decimal decimalDeposit = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Введите количество месяцев:");
        int months = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < months; i++)
        {
            decimalDeposit *= 1.07m;
        }

        Console.WriteLine($"Конечная сумма вклада: {decimalDeposit}");
        Console.ReadLine();

        // Задача 2
        Console.WriteLine("Задача 2: Таблица умножения");
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i * j}\t");
            }
            Console.WriteLine();
        }
        Console.ReadLine();

        // Задача 3
        while (true)
        {
            Console.WriteLine("Задача 3: Введите первое число:");
            int number1Loop = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int number2Loop = Convert.ToInt32(Console.ReadLine());

            if (number1Loop >= 0 && number1Loop <= 10 && number2Loop >= 0 && number2Loop <= 10)
            {
                Console.WriteLine($"Произведение: {number1Loop * number2Loop}");
                break;
            }
            else
            {
                Console.WriteLine("Введенные числа недопустимы. Пожалуйста, введите числа снова.");
            }
        }
        Console.ReadLine();

        // Задачи по массивам

        // Задача 1
        Console.WriteLine("Задачи по массивам");
        int[] numbersArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Задача 1: Нечетные числа в массиве:");
        foreach (int num in numbersArray)
        {
            if (num % 2 != 0)
            {
                Console.WriteLine(num);
            }
        }
        Console.ReadLine();

        // Задача 2
        string[] stringsArray = { "apple", "banana", "cherry", "date" };

        Console.WriteLine("Задача 2: Введите строку для поиска:");
        string input = Console.ReadLine();

        bool found = false;
        foreach (string str in stringsArray)
        {
            if (str == input)
            {
                found = true;
                break;
            }
        }

        if (found)
        {
            Console.WriteLine("Строка найдена!");
        }
        else
        {
            Console.WriteLine("Строка не найдена!");
        }
        Console.ReadLine();

        // Задача 3
        int[] sumArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int sum = 0;

        foreach (int num in sumArray)
        {
            sum += num;
        }

        double average = (double)sum / sumArray.Length;

        Console.WriteLine($"Сумма элементов массива: {sum}");
        Console.WriteLine($"Среднее арифметическое значение элементов массива: {average}");
        Console.ReadLine();
    }
}
