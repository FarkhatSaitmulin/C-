/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4 */

string[] DataInput()  
{ 
    System.Console.Write("Введите несколько чисел через запятую = "); 
    string[] arr = Console.ReadLine().Split(","); 
    return arr; 
} 
 
Console.Clear(); 
string[] array = DataInput(); 
int count = 0; 
for (int i = 0; i < array.Length; i++) 
{ 
    if(int.Parse(array[i]) > 0) 
    { 
        count++; 
    } 
}

System.Console.WriteLine(String.Join(", ", array) + " -> " + count);