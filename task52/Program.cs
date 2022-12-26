// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Please enter the number of lines:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the number of columns:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[m, n];

void FillArray(int m, int n)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}" + "\t");
        }
        Console.WriteLine();
    }
}

FillArray(m, n);
PrintArray(array);
Console.WriteLine();
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    double average = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = sum + array[i, j];
    }
    average = sum / array.GetLength(0);
    Console.WriteLine("Average in a column " + j + " there's " + Math.Round(average, 1));
}
Console.WriteLine();