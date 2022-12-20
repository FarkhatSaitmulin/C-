/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Console.Clear();

int InputNumber(string message)
{
    System.Console.WriteLine(message);
    int number = int.Parse(System.Console.ReadLine());
    return number;
}

int m = InputNumber("Введите количество строк m: ");
int n = InputNumber("Введите количество столбцов n: ");
int[,] array = CreateArray(m, n);


int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(100);
        }
    }
    return array;
}

int minSumRows = 0;
int sumRows = SmallSumElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumRows = SmallSumElements(array, i);
    if (sumRows > tempSumRows)
    {
        sumRows = tempSumRows;
        minSumRows = i;
    }
}

int SmallSumElements(int[,] array, int i)
{
    int sumRows = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumRows += array[i, j];
    }
    return sumRows;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

PrintArray(array);
Console.WriteLine($"\n{minSumRows + 1} - строкa с наименьшей суммой ({sumRows}) элементов ");