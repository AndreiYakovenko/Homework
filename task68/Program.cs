// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Please enter a positive number M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter a positive number N:");
int n = Convert.ToInt32(Console.ReadLine());
int Akkermam(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Akkermam(m - 1, 1);
    return Akkermam(m - 1, Akkermam(m, n - 1));
}

Console.WriteLine("A(" + m + "," + n + ") = " + Akkermam(m, n));