/* Задача 63: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */

// Запрос точек отсчета у пользователя

Console.WriteLine("Введите конечное число N");
int numberN = Convert.ToInt32(Console.ReadLine());



//Рекурсивный метод вывода всех натуральных чисел в промежутке от 1 до N
void NaturalOne(int numberTwo)
{

    if (numberTwo != 1)
    {

        NaturalOne(numberTwo - 1);
    }
    
    Console.Write($" {numberTwo} ");

}

//Вызов метода
NaturalOne(numberN);

