// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

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
Console.Clear();
Console.WriteLine("Введите день недели от 1 до 7 = " );
int day =  int.Parse(Console.ReadLine());
if (( day < 5 ) && ( day > 0 )) Console.WriteLine("Данный день недели не является выходным днем");
else 
if (day == 6  ||  day == 7) Console.WriteLine("Данный день недели является выходным днем");