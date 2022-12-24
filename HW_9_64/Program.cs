/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine());

int Natural(int n)
{
    System.Console.Write(n + " ");
    if (n == 1) return n;    // 1=1
    return Natural(n - 1);  // 5-1=4) 4-1=3) 3-1=2) 2-1=1) 
}
Natural(number);