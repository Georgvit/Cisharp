//Пользовательский ввод числа  и конвертация в тип int
Console.Clear();

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
int final = 1;
int length = number;

//Вычисляем длину числа
while (length > 1)
{
    length /= 10;
    count++;
}

/* Определяем является ли последняя цифра единицей,
не пойму почему, но если палиндром начинается с единици то код ломается и нужно менять
значение стемепи с -2 на -1*/

if (number % 10 == 1)
{
    while (count - 1 >= 1)
    {
        //Вычисляем первую цифру числа
        double a = number / Math.Pow(10, count - 1);
        // Промежуточная переменная для преобразования типа

        int b = 0;
        // Если результат деления меньше 1 то сдвигаемся на один знак
        if (a < 1)
        {
            b = (int)(a * 10);
        }
        else
        {
            b = (int)a;
        }

        int c = b % 10;

        int d = number % 10;

        count = count - 1;

        // Сравниваем первую и последнюю цифры числа

        if (c == d)
        {
            number /= 10;
            count = count - 1;
        }
        else
        {
            final = 0;
            break;
        }
    }
}
else
// Цикл для палиндромного числи с первой цифрой больше 1
{
    while (count - 1 >= 1)
    {
        double a = number / Math.Pow(10, count - 2);
        int b = 0;
        if (a < 1)
        {
            b = (int)(a * 10);
        }
        else
        {
            b = (int)a;
        }

        int c = b % 10;

        int d = number % 10;

        count = count - 1;

        if (c == d)
        {
            number /= 10;
            count = count - 1;
        }
        else
        {
            final = 0;
            break;
        }
    }
}

if (final != 0)
    Console.WriteLine("Число является палиндромом");
else
    Console.WriteLine("Число не является палиндромом");
