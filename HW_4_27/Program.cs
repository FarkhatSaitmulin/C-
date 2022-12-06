// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// NUMBER %10     2///5///4
//NUMBER /10  45///4///0
//WHILE(NUM>0) 


Console.Clear();
int DataInput(string str)
{
Console.WriteLine(str);
int number = int.Parse(Console.ReadLine());
return number;
}
int SumNumbers(int num) 
{ 
    int result = 0; 
    while(num > 0) 
    { 
        result += num % 10; 
        num = num / 10;         
    } 
    return result; 
} 
 
Console.Clear(); 
 
int number = DataInput("Многоуважаемый гражданин введите число "); 
int res = SumNumbers(number); 
 
Console.WriteLine($"{number} -> {res}");
