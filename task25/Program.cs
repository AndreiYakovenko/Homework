// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

Console.WriteLine("Please enter number A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter number B");
int B = Convert.ToInt32(Console.ReadLine());
int rate = A;
for (int i = 1; i < B; i++)
{
    rate = rate * A;
}
Console.WriteLine("Rate = " + rate);