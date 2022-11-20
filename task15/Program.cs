// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32 (Console.ReadLine());
if (day > 0 && day < 6) 
{
    Console.WriteLine ("Рабочий день");
}
else if (day > 5 && day < 8) 
{
    Console.WriteLine ("Выходной день");
} 
else 
{
    Console.WriteLine ("Нет такого дня недели");
}