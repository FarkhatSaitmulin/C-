// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 12

Console.Clear();
void pow3()
{
Console.WriteLine("Введите число N: ");
int number = int.Parse(Console.ReadLine());
int count =1;
while (count<= number)
    {
        double pow = Math.Pow(count,3);
        count++;
        Console.Write(pow + " ");
    }
    Console.WriteLine();
}
pow3 ();