// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("How many numbers are you planning to enter?");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the numbers yourself:");
int[] array = new int[n];
int count = 0;
for (int i = 0; i < n; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i]>0) count++;
}
Console.WriteLine("You entered " + count + " numbers greater than zero.");

// foreach (int k in array)
// {
//     Console.Write($"{k} ");
// }