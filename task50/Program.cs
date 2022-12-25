// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Please enter the number of lines:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the number of columns:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the number:");
int num = Convert.ToInt32(Console.ReadLine());
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
int count = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] == num)
        {
            Console.WriteLine("The number is located in an array with coordinates (" + i + "," + j + ")");
            count++;
        }
    }
}
Console.WriteLine();
if (count == 0) Console.WriteLine("This number is not in the array");
Console.WriteLine();