// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Введите число M: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int GetSum(int first, int second)
{
    if(first == second) return first;
    return (first + GetSum(first+1, second));
}
Console.WriteLine($"Cумма натуральных элементов в промежутке от M до N равна: {GetSum(firstNumber,secondNumber)}");