/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

// Создаем массив 4х4
int[,] spiral = new int[4, 4];

//Переменная для задания шага при заполнении
int step = new Random().Next(1, 20);

const int indent = 3;

//Цикл заполнения массива по спирали
for (int line = 0; line < spiral.GetLength(0); line++)
{
    for (int column = 0; column < spiral.GetLength(0); column++)
    {
        if (line == 0) { spiral[line, column] = step; step++; }
        if (line == 1 & column < 3) { spiral[line, column] = step + 7; step++; }
        if (line == 1 & column == 3) { spiral[line, column] = step - 3; }
        if (line == 2 & column == 0) { spiral[line, column] = step + 3; }
        if (line == 2 & column > 0 & column < 3) { spiral[line, column] = step + 8; step--; }
        if (line == 2 & column == 3) { spiral[line, column] = step; }
        if (line == 3 & column <= 4) { spiral[line, column] = step + 4; step--; }

        Console.Write($"{spiral[line, column],indent} ");
    }
    Console.WriteLine();
}