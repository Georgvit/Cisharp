/* Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых расположен наименьший
 элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7
 */


//Метод создания массива

void Massif(int[,] array)
{
    for (int line = 0; line < array.GetLength(0); line++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            array[line, column] = new Random().Next(1, 100);
            Console.Write(array[line, column]);
            if (array[line, column] > 9) Console.Write($" ");
            else Console.Write($"  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}

//Метод вывода массива без строк и столбцов на пересечении с мин элементом
void DeleteItem(int[,] array)
{

    int min = array[0, 0];
    int lineMinItem = 0;
    int columnMinItem = 0;

    //Определим минимальный элемент в массиве и на пересечении  каких строк и столбцов
    // он находится

    for (int line = 0; line < array.GetLength(0); line++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {

            if (array[line, column] < min)
            {

                min = array[line, column];
                lineMinItem = line;
                columnMinItem = column;
            }

        }

    }
    Console.WriteLine($"min {min} / lineMinItem {lineMinItem} / columnMinItem {columnMinItem}");

    //Вывод матрицы без строки и столбца на пересечении которых находится наименьший элемент
    for (int line = 0; line < array.GetLength(0); line++)
    {
        if (line == lineMinItem) { }
        else
        {
            for (int column = 0; column < array.GetLength(1); column++)
            {
                if (column == columnMinItem)
                {
                    if (column == array.GetLength(1) - 1) { break; }
                    else { column = column + 1; }

                    Console.Write(array[line, column]);

                    if (array[line, column] > 9) Console.Write($" ");
                    else Console.Write($"  ");
                }
                else
                {
                    Console.Write(array[line, column]);
                    if (array[line, column] > 9) Console.Write($" ");
                    else Console.Write($"  ");
                }

            }
            Console.WriteLine();

        }

    }

}

//Запускаем программу

int[,] arr = new int[5, 5];
Massif(arr);
DeleteItem(arr);