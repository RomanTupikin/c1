// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

void Quad(int num)
{
    int square = num * num;
    Console.WriteLine($"{num, 4} {square, 4}");
}
int count = 1;
int num = Math.Abs(number);
while (count <= num)
{
    Quad(count);
    count++;
}