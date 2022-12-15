/* Задача 47. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */



// Console.WriteLine("Hello, World!");

void ShowArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "  ");
        }
        System.Console.WriteLine();
    }
}

double[,] CreateArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(new Random().Next(10) + new Random().NextDouble(), 2);
        }
    }
    return array;
}

int EnterNumber(string message)
{
    System.Console.WriteLine(message);
    int number = int.Parse(System.Console.ReadLine());
    return number;
}
// Получить от пользователя M и N

int m = EnterNumber("Введите значение m: ");

int n = EnterNumber("Введите значение n: ");

// Создать двухмерный массив

double[,] array = CreateArray(m, n);

// вывести созданный массив

ShowArray(array);
