/* Задача 29: Напишите программу, которая задаёт массив из 8
элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */


Console.Clear();

int a = new Random().Next(0, 99);
int[] array = new int[a];

Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 99);
    Console.Write($"{array[i]}{" "}");
}
Console.Write("]");
