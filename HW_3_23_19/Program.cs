// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет, 12821 -> да,  23432 -> да.

Console.Clear();
void DataEntry(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    int Reverse = 0;
    int numberData = number;
    while (number < 0)
    {
        int remainder = number % 10;
        Reverse = (Reverse * 10) + remainder;
        number = number / 10;
    }
    if (numberData == Reverse)
    {
        Console.WriteLine($"{numberData}--> является полиндромным числом");
    }
    else
    {
        Console.WriteLine($"{numberData}--> не является полиндромным числом");
    }

}
DataEntry("Введите пятизначное число ");
