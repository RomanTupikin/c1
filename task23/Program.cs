// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125


Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

void Cube(int num)
{
    int cube = num * num * num;
    Console.WriteLine($"{num, 4} {cube, 4}");
}
int count = 1;
int num = Math.Abs(number);
while (count <= num)
{
    Cube(count);
    count++;
}