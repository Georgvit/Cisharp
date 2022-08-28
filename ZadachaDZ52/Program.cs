/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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
    Console.WriteLine();
}

//Среднее арифмитическое каждого столбца
void ArithmeticMean(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sumNumbersColumn = 0;
        double count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumNumbersColumn = sumNumbersColumn + array[i, j];
            count++;
        }
        Console.WriteLine(
            $"Среднее арифметическое чисел в столбце {j}: {Math.Round((sumNumbersColumn / count), 4)}"
        );
    }
}

//Задаем произвольный размер массива
int line = new Random().Next(2, 10);
int column = new Random().Next(2, 10);
int[,] arr = new int[line, column];

Massif(arr);
PrintMassif(arr);
ArithmeticMean(arr);
