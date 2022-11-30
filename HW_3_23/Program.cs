// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 12

void TablePOW2(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine()); 
    int count =1;
    while (count<= number)
    {
        int pow = count*count;
        Console.Write(pow + " ");
        count++;
    }
    Console.WriteLine();
}
Console.Clear();
TablePOW2 ("Введите число N: ");