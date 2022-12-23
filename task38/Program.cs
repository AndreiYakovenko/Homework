// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.


double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return Math.Round(max, 2);
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return Math.Round(min, 2);
}

Console.WriteLine("Plese enter a number (array size):");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
for (int i = 0; i < n; i++)
{
    array[i] = new Random().NextDouble() * 100;
    Console.WriteLine(Math.Round(array[i], 2) + " ");
}
Console.WriteLine("Max = " + FindMax(array));
Console.WriteLine("Min = " + FindMin(array));
Console.WriteLine("Difference = " + Math.Round(((FindMax(array) - FindMin(array))), 2));