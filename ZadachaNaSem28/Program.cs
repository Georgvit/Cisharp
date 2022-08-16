/* Задача 28: Напишите программу, которая принимает на
вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120 */

Console.Clear();

//Метод вычисления произведения чисел от 1 до N
void proiz(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result = result * i;
    }

    Console.WriteLine(result);
}

//Пользовательский ввод
Console.WriteLine("Введите число ");
int number1 = Convert.ToInt32(Console.ReadLine());
proiz(number1);
