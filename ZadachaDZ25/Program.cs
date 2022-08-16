/* Напишите цикл, который принимает на вход два числа (A и B) и
 возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */


Console.Clear();

//Метод возведения в степень

void Product(int number, int number1)
{
    double result = Math.Pow(number, number1);

    Console.WriteLine($"{"Результат возведения числа А в степень Б: "}{result}");
}

//Второй способ
void Product2(int number, int number1)
{
    int result = 1;
    for (int i = 0; i < number1; i++)
    {
        result = result * number;
    }

    Console.WriteLine($"{"Результат возведения числа А в степень Б вторым способом: "}{result}");
}

//Пользовательский ввод чисел и конвертация в тип int
Console.WriteLine("Введите число А");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число Б");
int num1 = Convert.ToInt32(Console.ReadLine());

Product(num, num1);
Product2(num, num1);
