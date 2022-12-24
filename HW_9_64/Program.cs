/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

/* Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine());
int count = 1;
Natural(number,count);

void Natural(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        Natural(n, count + 1);
        System.Console.Write(count + " ");
    }
} */


/* double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
} */

Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine());

int Natural(int n)
{
    System.Console.Write(n + " ");
    if (n == 1) return n;
    return Natural(n - 1);
}
Natural(number);