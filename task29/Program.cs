// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Enter the desired array size (up to 10 elements):");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(0, 101);
    Console.Write(array[i] + " ");
}