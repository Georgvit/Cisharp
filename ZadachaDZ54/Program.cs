/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
 */

//Метод создания массива
void Massif(int[,] array)
{
    Console.WriteLine("Оригинальный массив");
    const int indent = 3;
    for (int line = 0; line < array.GetLength(0); line++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            array[line, column] = new Random().Next(1, 30);
            Console.Write($" {array[line, column],indent} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

//Метод сортировки элементов в масиве вариант 1
void Sort(int[,] array)
{
    Console.WriteLine("Сорторовка массива встроенным методом");
    const int indent = 3;
    int line = 0;
    while (line < array.GetLength(0))
    {
        int column = 0;
        int[] arrt = new int[4];
        for (int count = 0; count < arrt.Length; count++)
        {
            arrt[count] = array[line, column];
            column++;
        }
        Array.Sort(arrt);

        column = 0;

        for (int count = 0; count < array.GetLength(1); count++)
        {
            array[line, count] = arrt[column];
            column++;
            Console.Write($" {array[line, count],indent} ");
        }

        Console.WriteLine();
        line++;
    }
    Console.WriteLine();
}

//Метод сортировки элементов в масиве вариант 2
void Sort2(int[,] array)
{
    Console.WriteLine("Сорторовка массива методом пузырька");
    const int indent = 3;
    int line = 0;
    while (line < array.GetLength(0))
    {
        int column = 0;
        int[] arrt = new int[4];
        for (int count = 0; count < arrt.Length; count++)
        {
            arrt[count] = array[line, column];
            column++;
        }
        int temp;
        for (int countSortOne = 0; countSortOne < arrt.Length; countSortOne++)
        {
            for (int countSortTwo = 0; countSortTwo < arrt.Length; countSortTwo++)
            {
                if (arrt[countSortTwo] > arrt[countSortOne])
                {
                    temp = arrt[countSortTwo];
                    arrt[countSortTwo] = arrt[countSortOne];
                    arrt[countSortOne] = temp;
                }
            }
        }

        column = 0;

        for (int count = 0; count < array.GetLength(1); count++)
        {
            array[line, count] = arrt[column];
            column++;
            Console.Write($" {array[line, count],indent} ");
        }

        Console.WriteLine();
        line++;
    }

}

//Вызов мотодов
int[,] arr = new int[4, 4];
Massif(arr);
Sort(arr);
Sort2(arr);
