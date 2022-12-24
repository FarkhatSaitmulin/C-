/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int DataNumber(string message)
{
    System.Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int Sum(int leftNum, int rightNum)
{
    if (leftNum == rightNum) return leftNum;
    return rightNum + Sum(leftNum, rightNum - 1);  // 2 до 5, 5 + (4+(3+(2)))
}

Console.Clear();
int leftRangeNumber = DataNumber("Введите натуральное число m = ");
int rightRangeNumber = DataNumber("Введите натуральное число n = ");
int resultSum = Sum(leftRangeNumber, rightRangeNumber);
System.Console.WriteLine($"Сумма натуральных чисел в промежутке от {leftRangeNumber} до {rightRangeNumber} = {resultSum}");