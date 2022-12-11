/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

const int SIZE = 8;
const int LEFT_RANGE = -1000;
const int RIGHT_RANGE = 1000;
int[] array = new int[SIZE];

int[] Fillarray(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange);   // (-1000;1000) также можно указать Next(-1000, 1000)
    }
    return arr;
}

int SumArray(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}
array = Fillarray(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine('[' + string.Join("; ", array) + ']');
int sum = SumArray(array);
System.Console.WriteLine('[' + string.Join("; ", sum) + ']');








/* int[] a = new int[10];
for (int i = 0; i < a.Length; i++)
{
    Console.Write($"Введите a[{i}] = ");
    a[i] = int.Parse(Console.ReadLine());
}
int sum = 0;
for (int i = 0; i < a.Length; i++)
{
    if (a[i] % 2 == 1)
        sum += a[i];
}
Console.WriteLine($"Сумма нечетных чисел = {sum}"); */