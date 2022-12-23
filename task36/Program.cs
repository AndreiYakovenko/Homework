// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Plese enter a number (array size):");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int sum = 0;
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(-100, 101);
    if ((i+1) % 2 == 0) sum = sum + array[i];
    Console.Write(array[i] + " ");
}
Console.WriteLine("Sum of elements in odd positions: " + sum);