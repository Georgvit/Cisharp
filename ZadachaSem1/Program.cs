//Пользовательский ввод чисела и конвертация в тип int
Console.WriteLine("Введите число А");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число Б");
int numberB = Convert.ToInt32(Console.ReadLine());

//Определяем большее число с выводом на консоль
if (numberA > numberB)
{
    Console.WriteLine("Число MAX -> " + numberA);
    Console.WriteLine("Число MIN -> " + numberB);
}

if (numberA < numberB)
{
    Console.WriteLine("Число MAX -> " + numberB);
    Console.WriteLine("Число MIN -> " + numberA);
}

if (numberA == numberB)
{
    Console.WriteLine("Числа равны ");
}
