/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/
//Метод ручного ввода матрицы и подсчета элементов больше 0
void TableOfNumbers()
{
    Console.WriteLine($"Введите количество эллементов в матрице");
    int matrixLength = Convert.ToInt32(Console.ReadLine());
    if (matrixLength <= 0) {
        Console.WriteLine("Значение не может быть меньше или равным нулю ");
        TableOfNumbers();
    }
    int[] matrix = new int[matrixLength];

    for (int i = 0; i < matrixLength; i++)
    {
        Console.WriteLine($"Введите значение элемента матрицы");
        matrix[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine($"Введенная матрица: {string.Join(" ", matrix)}");
    int count = 0;
    for (int i = 0; i < matrixLength; i++)
    {
        if (matrix[i] > 0)
            count++;
        
    }

    Console.WriteLine($"Количество цифр в матрице больше нуля:  {count}");
}

TableOfNumbers();
