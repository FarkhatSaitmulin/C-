// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

const int SIZE = 8;
const int LEFT_RANGE = -8;
const int RIGHT_RANGE = 100;

int[] array = new int[SIZE];

int[] FillArray(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);   // (0 до 100)
    }
    return arr;
}
array = FillArray (SIZE,LEFT_RANGE,RIGHT_RANGE);
Console.WriteLine ('[' + string.Join("; ", array) + ']');