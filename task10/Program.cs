// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

int Middle(int num)
{
    int digit = num / 10 - num / 100 * 10;
    return digit;
}

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1000 && number > 99)
{
    int res = Middle(number);
    Console.WriteLine($"Вторая цифра числа: {res}");
}

else if (number > -1000 && number < -99)
{
    int res = Middle(number * -1);
    Console.WriteLine($"Вторая цифра числа: {res}");
}

else
{
    Console.WriteLine("Трехзначное число пожалуйста");
}