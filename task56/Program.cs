// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

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

int[] arraySum = new int[m];
int indxMin = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];
    }
    arraySum[i] = sum;
    // Console.WriteLine(arraySum[i]); // Выводит массив суммы строк
    for (int k = 0; k < array.GetLength(0); k++)
        if (arraySum[indxMin] > arraySum[k])
        {
            indxMin = k;
        }
}
Console.WriteLine("The row with the smallest sum of elements N" + (indxMin + 1)); // Номер строки - индекс + 1
Console.WriteLine();