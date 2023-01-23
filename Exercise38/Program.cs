// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
double [] numbers = new double[size];

FillArrayWithRandom(numbers);
Console.WriteLine ("Случайный массив: ");
PrintArray(numbers);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int a = 0; a < numbers.Length; a++)
{
    if (numbers[a] > max)
    {
        max = numbers[a];
    }
    if (numbers[a] < min)
    {
        min = numbers[a];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным числом = {max - min}");

void FillArrayWithRandom(double[] numbers)
{
    for (int i = 0 ; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble (new Random().Next(0,100))/10;
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
}