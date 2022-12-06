// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int DataInput (string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int []FillArray(int [] array)
{
    int Length = array.Length;
    for ( i = 0; i < Length; i++); 
    {
        array[i] = newRandom().Next(0,7);
    }
    return array;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int i;
    for (i = 0; i < count; i++)
    {
        Console.Write(col[i] + " ");
    }
}

int NumberN = DataInput("Введите число: ");
int [] array = new int[NumberN];
array = FillArray(array);
PrintArray(array);