﻿/// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
/// и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Введите день недели от 1 до 7" );
int day =  int.Parse(Console.ReadLine());
if (( day < 6 ) && ( day > 0 )) Console.WriteLine("Данный день недели не является выходным днем");
else 
if (day == 6  ||  day == 7) Console.WriteLine("Данный день недели является выходным днем");
else Console.WriteLine ("Нет такого дня в недели ");
