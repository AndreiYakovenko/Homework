// Напишите программу,
// которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

Console.WriteLine("Please enter a five-digit number");
int n = Convert.ToInt32(Console.ReadLine());
int d1 = n/10000;
int d2 = n/1000%10;
int d4 = n/10%10;
int d5 = n%10;
if(d1==d5 && d2==d4) Console.WriteLine("This number is a palindrome!");
else Console.WriteLine("This number is not a palindrome");