// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Please enter the number of lines:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the number of columns:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double[,] array = new double[m, n];

void FillArray(int m, int n)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * 100;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(array[i, j], 1)}" + "\t");
        }
        Console.WriteLine();
    }
}

FillArray(m, n);
PrintArray(array);
Console.WriteLine();