/* Задача 50. Напишите программу, которая на вход принимает значение элемента,
и возвращает позицию элемента в двумерном массиве или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4 
17 -> такого числа в массиве нет */

Console.Clear();

int DataNumber(string message)
{
    System.Console.WriteLine(message);
    int number = int.Parse(System.Console.ReadLine());
    return number;
}

int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(100);
            //System.Console.WriteLine();
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

bool SearchNumber(int[,] arr, int number)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == number)
            {
                System.Console.WriteLine($"Позиция искомого элемента в массиве - [{i},{j}]");
                return true;
            }
        }
    }
    System.Console.WriteLine("Искомого элемента в массиве не найдено");
    return false;
}

int m = DataNumber("Введите количество строк m: ");
int n = DataNumber("Введите количество столбцов n: ");
int[,] array = CreateArray(m, n);
ShowArray(array);
int searchNum = DataNumber("Введите искомое число в диапазоне от 0 до 100");
SearchNumber(array, searchNum);