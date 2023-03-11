// Задача 64: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

string PrintNumbers(int end, int start)
{
    if ( end == start) return end.ToString();
    return (end + ", " + PrintNumbers(end - 1, start));
}
Console.WriteLine(PrintNumbers(N, 1));