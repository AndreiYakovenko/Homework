Console.WriteLine("Please enter number 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter number 2");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    Console.WriteLine("Max = " + a);
    Console.WriteLine("Min = " + b);
}
else
{
    Console.WriteLine("Max = " + b);
    Console.WriteLine("Min = " + a);
}
Console.WriteLine("end");