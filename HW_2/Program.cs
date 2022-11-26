// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//Console.Clear();
//int RandomDigit = new Random().Next(100,999); // случайное число от 100 до 999
//Console.WriteLine("Случайное 3-х значное число:" +RandomDigit); // вывод на консоль случайного 3-х значного числа
Console.Clear();
int random = new Random().Next(100,1000);
int result = (random / 10) % 10;
Console.WriteLine(result);
Console.WriteLine(random + " -> "+ result);

 // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
 Console.Clear();
 Console.Write("Введите число =  " );
 int number = int.Parse(Console.ReadLine());
 if (number<100) Console.WriteLine("Третьего числа нет");
 else
 {
    while (number>1000) number = number/10;
    Console.WriteLine(number%10);
 }

 /// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 /// и проверяет, является ли этот день выходным.