// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет, 12821 -> да,  23432 -> да.

Console.Clear();

Console.WriteLine("Введите пятизначное число: ");

int number = int.Parse(Console.ReadLine());

void Polindrome(string str)
{
    Console.WriteLine(str);
    int ostatok = number/1000;
    int ostatok1 = number%100;
    int ostatok2 = (ostatok1 % 10) * 10 + (ostatok1/10);
    if (ostatok == ostatok2) Console.WriteLine ($"число {number} является полиндромом ");
    else Console.WriteLine ($"число {number} не является полиндромом ");
    Console.WriteLine();
}

Polindrome ("Проверяем является ли число полиндромным: ");