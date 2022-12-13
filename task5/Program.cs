Random random = new Random();
int number = random.Next(100, 1000);
Console.WriteLine("Random number = {0}", number);
int number2 = (number/10)%10;
Console.WriteLine(number2);