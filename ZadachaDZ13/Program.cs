//Пользовательский ввод чисела и конвертация в тип int
Console.Clear();

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int ostatok = 100;

//Вычисляем третью цифру числа
if (ostatok < number)
{
    if (ostatok < number & number < ostatok * 10)
    {
        Console.WriteLine($"{"Третье число: "}{number % 10}");
    }
    else if (ostatok * 10 < number & number < ostatok * 100)
    {
        Console.WriteLine($"{"Третье число: "}{number / 10 % 10}");
    }
    else if (ostatok * 100 < number & number < ostatok * 1000)
    {
        Console.WriteLine($"{"Третье число: "}{number / 100 % 10}");
    }
    else if (ostatok * 1000 < number & number < ostatok * 10000)
    {
        Console.WriteLine($"{"Третье число: "}{number / 1000 % 10}");
    }
    else
        Console.WriteLine("Вы за пределами диапазона допустимых значений");
}
else
    Console.WriteLine("Нет третьего числа");
