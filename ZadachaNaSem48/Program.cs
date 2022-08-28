/* Задача 48: Задайте двумерный массив размера m на n, каждый
элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный
массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5 */

Console.Clear();

void Massif(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
}

void PrintMassif(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int line = new Random().Next(1, 10);
int column = new Random().Next(2, 10);
int[,] arr = new int[line, column];

Massif(arr);
PrintMassif(arr);
