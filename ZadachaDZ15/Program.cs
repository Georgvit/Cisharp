//Пользовательский ввод чисела и конвертация в тип int
Console.Clear();

Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());

//Проверяем день недели
if (number == 1)
{
    Console.WriteLine("Рабочий день");
}
else if (number == 2)
{
    Console.WriteLine("Рабочий день");
}
else if (number == 3)
{
    Console.WriteLine("Рабочий день");
}
else if (number == 4)
{
    Console.WriteLine("Рабочий день");
}
else if (number == 5)
{
    Console.WriteLine("Рабочий день");
}
else if (number == 6)
{
    Console.WriteLine("Выходной день");
}
else if (number == 7)
{
    Console.WriteLine("Выходной день");
}
else
    Console.WriteLine("Нет такого дня недели");
