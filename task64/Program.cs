// Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в
// промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Please Enter a real number:");
int n = Convert.ToInt32(Console.ReadLine());
int realNumbers(int n)
{
    if (n == 0) return 1;
    Console.Write(n + " ");
    return realNumbers(n-1);
}
// Console.WriteLine();
realNumbers(n);
Console.WriteLine();