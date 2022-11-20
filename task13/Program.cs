// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Three(int num)
{
    int digit = num % 10;
    return digit;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    while (number > 999)
        {
            number = number / 10;
        }
    int res = Three(number);
    Console.WriteLine($"Третья цифра числа: {res}");
}

else if (number < -99)
{
    while (number < -999)
        {
            number = number / 10;
        }
    int res = Three(number * -1);
    Console.WriteLine($"Третья цифра числа: {res}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}