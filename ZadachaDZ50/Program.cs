/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */


//Создание массива
void Massif(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

//Вывод массива на экран
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

//Проверка наличия элемента в массиве
void ElementSearch(int[,] array)
{
    try
    {
        //Ввод номера позиции для проврки пользователем
        Console.WriteLine("Введите номен элемента в массиве по горизонтали");
        int NumberPositionColumn = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите номен элемента в массиве по вертикали");
        int NumberPositionLine = Convert.ToInt32(Console.ReadLine());

        int number = 0;
        bool mark = false;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (NumberPositionLine == i & NumberPositionColumn == j)
                {
                    number = array[i, j];
                    mark = true;
                }
            }
        }
        if (mark == true)
            Console.WriteLine($"Елемент в массиве под таким номером позиции: {number} ");
        else
            Console.WriteLine($"Нет елемента в массиве под таким номером позиции ");
    }
    catch (Exception)
    {
        Console.WriteLine("Ошибка! Вы не ввели номен элемента в массиве");
    }
}

//Задаем произвольный размер массива
int line = new Random().Next(2, 10);
int column = new Random().Next(2, 10);
int[,] arr = new int[line, column];

Massif(arr);
PrintMassif(arr);
ElementSearch(arr);
