
/* Задача 64: Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""  */


// Запрос точек отсчета у пользователя
Console.WriteLine("Введите число M для начала отсчета");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите конечное число N");
int numberN = Convert.ToInt32(Console.ReadLine());


//Рекурсивный метод вывода всех натуральных чисел в промежутке от M до N
int Natural(int numberOne, int numberTwo)
{

    if (numberTwo <= numberOne)
    {

    Console.Write($" {numberTwo} ");

    numberTwo++;
}
    else { Environment.Exit(0); }
return Natural(numberOne, numberTwo);

}

//Вызов метода
Natural(numberN, numberM);