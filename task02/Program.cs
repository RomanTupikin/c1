// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Write("Введите трехзначное число чтобы узнать третью цифру: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
if (number < 1000 && number > 99)
{
    number = number % 10;

    Console.WriteLine($"Третья цифра {number}");
}
else
{
    Console.WriteLine("Трехзначное число пожалуйста");
}
