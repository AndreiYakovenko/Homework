// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Please Enter a real number N:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please Enter a real number M:");
int n = Convert.ToInt32(Console.ReadLine());
if (m > n) (m, n) = (n, m);
int sum = 0;
int sumRealNumbers(int n, int m)
{
    if (n == m - 1) return 1;
    sum = sum + n;
    return sumRealNumbers(n - 1, m);
}
sumRealNumbers(n, m);
Console.WriteLine();
Console.WriteLine(sum);
Console.WriteLine();