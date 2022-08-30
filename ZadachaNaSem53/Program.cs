/* Задача 53: Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.

 */

Console.Clear();

//Создание массива

void Massif(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}

void Replace(int[,] array)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {
        int i = array.GetLength(0) - 1;
        int x = 0;
        x = array[0, j];
        array[0, j] = array[i, j];
        array[i, j] = x;

    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }


}

int[,] arr = new int[4, 4];
Massif(arr);
Replace(arr);

