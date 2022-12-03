// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет, 12821 -> да,  23432 -> да.

void TablePOW2(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    int count = 1;
    while (count <= number)
    {
        int pow = count * count;
        Console.Write(pow + " ");
        count++;
    }
    Console.WriteLine();
}
Console.Clear();
TablePOW2("Введите число N: ");