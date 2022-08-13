//Пользовательский ввод числа N и конвертация в тип int
Console.Clear();

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int final = 1;

//Вычисляем упорядочены ли цифры в числе

while (number >= 1)
{
    int a = number % 10;
    int b = number / 10 % 10;

    if (a >= b)
    {
        number = number / 10;
    }
    else
    {
        final = 0;
        break;
    }
}

if (final != 0)
    Console.WriteLine("Цифры в числе идут в порядке возрастания");
else
    Console.WriteLine("Цифры в числе идут как попало ))");
