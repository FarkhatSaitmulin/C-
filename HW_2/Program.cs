// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//Console.Clear();
//int RandomDigit = new Random().Next(100,999); // случайное число от 100 до 999
//Console.WriteLine("Случайное 3-х значное число:" +RandomDigit); // вывод на консоль случайного 3-х значного числа
Console.Clear();
int random = new Random().Next(100,999);
int result = (random / 10) % 10;
Console.WriteLine(result);
Console.WriteLine(random + " -> "+ result);