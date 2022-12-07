/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

// Console.WriteLine("Hello, World!");

const int SIZE = 4;
const int LEFT_RANGE = 100;
const int RIGHT_RANGE = 1000;
int[] array = new int [SIZE];

int[] FillArray(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int [size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange);   // (100;999)
    }
    return arr;
}

int[] Evennumbersinarray(int []arr, int Evenarr)
{
    Evenarr = 0;
    array[i] = number[i]
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
        Evenarr  = (number %2==o);
        }
    }
    return arr;
}
array = FillArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine('[' + string.Join("; ", array) + ']');
Evennumbersinarray(array, Evenarr);
System.Console.WriteLine($"Сумма четных чисел = {Evenarr}");