/* Задача 26: Напишите программу, которая принимает на вход число и
выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
 */

Console.Clear();

//Метод вычисляения длины числа
void length(int number)
{
    int count = 1;
    while (number > 1)
    {
        number /= 10;
        count++;
    }

    Console.WriteLine(count);
}

//Пользовательский ввод
Console.WriteLine("Введите число ");
int number1 = Convert.ToInt32(Console.ReadLine());
length(number1);
