/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

Console.Clear();
Console.WriteLine("Hello, World!");

double size = 10;
double leftRange = -100;
double rightRange = 100;

double[] FillArray(double size, double leftRange, double rightRange)    // Метод рандомный массив и наполнить его
{
    double[] arr = new double[(int)size];
    double length = arr.Length;
    double index = 0;
    while (index < length)
    {
        arr[(int)index] = new Random().Next(-100, 100); // заполнение массива,также можно указать Next(leftRange, rightRange +1)
        index++;
    }
    return arr;
}

double ArrayNumberDifference(double[] array)
{
    double diff = 0;
    double min = array[0];
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    diff = max - min;
    return diff;
}

double[] array = FillArray(size, leftRange, rightRange);
//System.Console.WriteLine('[' + string.Join(",", array) + ']');
double result = ArrayNumberDifference (array);
System.Console.WriteLine('[' + string.Join(",", array) + "] -> "+ result);



/* Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
} */