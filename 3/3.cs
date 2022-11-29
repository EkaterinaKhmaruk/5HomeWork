/* Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/


Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
double diffrent = 0;

Random rand = new Random();


Console.Write("Массива рандом: ");

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.NextDouble();
    Console.Write(array[i] + " ");
}

double min = array[0];
double max = array[0];

for (int i = 0; i < array.Length; i++)
{
    
    if (array[i] > max ) max = array[i];
    if (array[i] < min ) min = array[i];
}


diffrent = max - min;
Console.WriteLine();
Console.WriteLine("Минимальное число: " + min);
Console.WriteLine("Максимальное число: " + max);
Console.WriteLine($"Разница между max и min {diffrent}");
            