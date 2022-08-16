/* Задача 27: Напишите программу, которая принимает на вход
число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

Console.Clear();

//Метод определения длины числа и сложения цифр числа

void Summa(int number)
{
    int count = number;
    int length = 1;
    int sum = 0;
    while (count > 1)
    {
        count /= 10;
        length++;
    }

    Console.WriteLine(length);

    for (int i = 0; i < length; i++)
    {
        sum = sum + number % 10;
        number = number / 10;
    }

    Console.WriteLine($"{"Сумма цифр числа: "}{sum}");
}

//Пользовательский ввод числа и конвертация в тип int
Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

Summa(num);
