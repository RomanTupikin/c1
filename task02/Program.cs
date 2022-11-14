

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
