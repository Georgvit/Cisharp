//Пользовательский ввод чисела и конвертация в тип int
Console.WriteLine("Введите число А");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число Б");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число В");
int numberC = Convert.ToInt32(Console.ReadLine());

//Определяем большее число с выводом на консоль
if (numberA > numberB)
{
    if (numberA > numberC)
    {
        Console.WriteLine("Число MAX -> " + numberA);
    }
    else
    {
        Console.WriteLine("Число MAX -> " + numberC);
    }
}
else
{
    if (numberB > numberC)
    {
        Console.WriteLine("Число MAX -> " + numberB);
    }
    else
    {
        Console.WriteLine("Число MAX -> " + numberC);
    }
}

if (numberA == numberB)
{
    if (numberA == numberC)
    {
        Console.WriteLine("Числа равны ");
    }
}
