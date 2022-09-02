/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка
 */


//Метод создания массива
void Massif(int[,] array)
{
    const int indent = 3;
    for (int line = 0; line < array.GetLength(0); line++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            array[line, column] = new Random().Next(1, 30);
            Console.Write($"{array[line, column],indent}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

//Метод подсчета суммы в каждой строке массива и вывод номера строки с наименьшей суммой
void SumInLine(int[,] array)
{

    //Подсчет суммы элементов в строке
    int line = 0;
    int sum = 0;

    int sizeArrayMin = array.GetLength(0);
    int[] ArrayMin = new int[sizeArrayMin];

    while (line < array.GetLength(0))
    {

        for (int column = 0; column < array.GetLength(0); column++)
        {
            sum = sum + array[line, column];
        }

        ArrayMin[line] = sum;

        Console.WriteLine($"Сумма строки {line} - {sum}");
        Console.WriteLine();

        line++;
        sum = 0;
    }

    // Поиск минимальной суммы
    int minNUmber = ArrayMin[0];
    int index = 0;
    for (int count = 0; count < sizeArrayMin; count++)
    {
        if (minNUmber > ArrayMin[count])
        {
            minNUmber = ArrayMin[count];
            index = count;
        }
    }
    Console.WriteLine($"В строке {index} минимальная сумма {minNUmber}");

}

//Создаем массива и вызываем методы
int[,] arr = new int[4, 4];
Massif(arr);
SumInLine(arr);
