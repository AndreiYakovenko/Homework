Console.WriteLine("Please enter number 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter number 2");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter number 3");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b>max)
{
    max = b;
}
if (c>max)
{
    max=c;
}
Console.WriteLine("Maximum = " + max);