/* Задача 55: Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, если это невозможно, 
программа должна вывести сообщение для пользователя. */

//Метод создания и печати массива

void Massif(int[,] array)
{
    for (int line = 0; line < array.GetLength(0); line++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            array[line, column] = new Random().Next(0, 20);
            Console.Write($"{array[line, column]}");
            if (array[line, column] > 9) Console.Write($" ");
            else Console.Write($"  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

//Метод разворота массива

void Turn(int[,] array)
{
    if (array.GetLength(1) == array.GetLength(0))
    {
        for (int line = 0; line < array.GetLength(1); line++)
        {
            for (int column = 0; column < array.GetLength(0); column++)
            {
                Console.Write($"{array[column, line]}");
                if (array[column, line] > 9) Console.Write($" ");
                else Console.Write($"  ");
            }
            Console.WriteLine();

        }
        Console.WriteLine();

    }
    else Console.WriteLine("Массив развернуть не возможно");

}

int[,] arr = new int[5, 5];
Massif(arr);
Turn(arr);