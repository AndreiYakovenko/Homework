// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Please enter number");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (number > 0)
{
    int n = number % 10;
    number = (number - n) / 10;
    sum = sum + n;
}
Console.WriteLine(sum);