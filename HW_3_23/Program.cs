// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 12

Console.Clear();

void POW3(string str);
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine()); 
    int count =1;
    while (count<= number)
    {
        int pow3 = count*count*count;
        Console.Write(Pow3 + " ");
        count++;
    }
 Console.WriteLine();
}
Pow3 ("Введите число N: ");
