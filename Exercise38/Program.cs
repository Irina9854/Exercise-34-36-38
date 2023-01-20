// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива
Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива: ");
double A = Math.Round(new Random().NextDouble() + new Random().Next(0,9),2);
Console.WriteLine("Введите максимальное число массива: ");
double B = Math.Round(new Random().NextDouble() + new Random().Next(0,9),2);
int [] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > B)
    {
        double max = numbers[i];
    }
    if (numbers[i] < A)
    {
        double min = numbers[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным числом = {B - A}");

void FillArrayRandomNumbers(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}