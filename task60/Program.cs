// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

int[,,] array = new int[2, 2, 2];
int k = 0;
while (k < 8)
{
    bool b = true;
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int l = 0; l < 2; l++)
            {
                int num = new Random().Next(10, 100);
                if (num == array[i, j, l])
                {
                    b = false;
                    break;
                }
                if (b)
                {
                    array[i, j, l] = num;
                    Console.WriteLine($"{array[i, j, l]}" + " " + "(" + i + "," + j + "," + l + ")" + "\t");
                    k++;
                }
            }
        }
    }
}