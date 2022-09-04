
/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30  */


// Запрос точек отсчета у пользователя
Console.WriteLine("Введите число M для начала отсчета");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите конечное число N");
int numberN = Convert.ToInt32(Console.ReadLine());


//Рекурсивный метод вывода суммы всех натуральных чисел в промежутке от M до N

int NaturalRec(int numberOne, int numberTwo)
{
    if (numberTwo > numberOne)
    {
        return numberTwo + NaturalRec(numberOne, numberTwo - 1);

    }

    if (numberTwo < numberOne)
    {
        return numberOne + NaturalRec(numberOne - 1, numberTwo);

    }

    return numberTwo;

}

//Цикличный метод вывода суммы всех натуральных чисел в промежутке от M до N
void Natural(int numberOne, int numberTwo)
{
    int sum;
    if (numberOne < numberTwo)
    {
        sum = numberOne - 1;
        while (numberOne <= numberTwo)
        {
            sum = sum + numberOne;
            numberOne++;
        }
        Console.Write($"Сумма всех натуральных чисел в промежутке от M до N: {sum} / (Найденна Цикличным методом) ");
    }
    else if (numberOne > numberTwo)
    {
        sum = numberTwo - 1;
        while (numberOne >= numberTwo)
        {
            sum = sum + numberTwo;
            numberTwo++;
        }
        Console.Write($"Сумма всех натуральных чисел в промежутке от M до N: {sum} / (Найденна Цикличным методом) ");

    }
    else
    {
        sum = 0;
        Console.Write($"Сумма всех натуральных чисел в промежутке от M до N: {sum} / (Найденна Цикличным методом) ");

    }
}

//Вызов методов
Console.WriteLine($"Сумма всех натуральных чисел в промежутке от M до N: {NaturalRec(numberM, numberN)} / (Найденна Рекурсивным методом)");

Natural(numberM, numberN);
