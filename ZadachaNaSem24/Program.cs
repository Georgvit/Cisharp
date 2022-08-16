/* Напишиет программу которая принемает число А и выдает сумму чисел
от 1 до А */

void SumNumb(int a)
{
    int sum = 0;
    for (int i = 1; i < a; i++)
    {
        sum = sum + 1;
    }
    Console.WriteLine(sum);
}

Console.WriteLine("Введите число А");
int num1 = Convert.ToInt32(Console.ReadLine());
SumNumb(num1);
