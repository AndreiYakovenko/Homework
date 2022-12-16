// Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Enter coordinate X first segment");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter coordinate Y first segment");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter coordinate Z first segment");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter coordinate X second segment");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter coordinate Y second segment");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter coordinate Z second segment");
int z2= Convert.ToInt32(Console.ReadLine());
double distance = Math.Round(Math.Sqrt((Math.Pow((x2-x1), 2)) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2)), 2);
Console.WriteLine("Distance = " + distance);