/* Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */


const int indent = 3;

//Создаем первый массив
int[,] massifOne = new int[2, 2];

Console.WriteLine($"Массив massifOne: ");

for (int line = 0; line < massifOne.GetLength(0); line++)
{
    for (int column = 0; column < massifOne.GetLength(1); column++)
    {
        massifOne[line, column] = new Random().Next(1, 10);
        Console.Write($"{massifOne[line, column],indent}");
    }
    Console.WriteLine();
}

Console.WriteLine();


//Создаем второй массив
int[,] massifTwo = new int[2, 2];
Console.WriteLine($"Массив massifTwo: ");

for (int line = 0; line < massifTwo.GetLength(0); line++)
{
    for (int column = 0; column < massifTwo.GetLength(1); column++)
    {
        massifTwo[line, column] = new Random().Next(1, 10);
        Console.Write($"{massifTwo[line, column],indent}");
    }
    Console.WriteLine();
}

Console.WriteLine();


//Создаем третий массив и присваиваем его элементам результат произведения двух матриц
int[,] massifMultioly = new int[2, 2];
Console.WriteLine($"Произведение двух массивов massifMultioly: ");

for (int line = 0; line < massifMultioly.GetLength(0); line++)
{
    for (int column = 0; column < massifMultioly.GetLength(1); column++)
    {
        if (line == 0 & column == 0)
        {
            massifMultioly[line, column] = massifOne[line, column] * massifTwo[line, column] + massifOne[line, column + 1] * massifTwo[line + 1, column];
        }
        if (line == 1 & column == 0)
        {
            massifMultioly[line, column] = massifOne[line, column] * massifTwo[line - 1, column] + massifOne[line, column + 1] * massifTwo[line, column];
        }

        if (line == 0 & column == 1)
        {
            massifMultioly[line, column] = massifOne[line, column - 1] * massifTwo[line, column] + massifOne[line, column] * massifTwo[line + 1, column];
        }

        if (line == 1 & column == 1)
        {
            massifMultioly[line, column] = massifOne[line, column - 1] * massifTwo[line - 1, column] + massifOne[line, column] * massifTwo[line, column];
        }

        Console.Write($"{massifMultioly[line, column],indent}");
    }
    Console.WriteLine();
}





