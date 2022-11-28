// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = Math.Abs(number);
if (number1 > 9999 && number1 < 100000)
{
    int num1 = number / 10000;
    int num2 = number / 1000 - number / 10000 * 10;
    int num4 = number / 10 - number / 100 * 10;
    int num5 = number - number / 10 * 10;
    if (num1 == num5 && num2 == num4)
    {
        Console.WriteLine($"{number} палиндром");
    }
    else
    {
        Console.WriteLine($"{number} не палиндром");
    }
}
else 
{
    Console.WriteLine("Неверное число");
}