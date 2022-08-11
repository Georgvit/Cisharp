//Ввод чисел
Console.WriteLine("Введите число А");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число Б");
int numberB = Convert.ToInt32(Console.ReadLine());

//Проверка на кратность

int result = numberA % numberB;

//Вывод результата

if (result == 0)
    Console.WriteLine("Число А кратно числу Б");
else
    Console.WriteLine($"{"Число А не кратно числу Б, остаток: "}{result}");

//Числа для проверки на кратность числа А

int numberOne = 7;
int numberTwo = 23;

if (numberA % numberOne == 0)
{
    if (numberA % numberTwo == 0)
    {
        Console.WriteLine("Число А кратно числу 7 и числу 23");
    }
    else
        Console.WriteLine("Число А не кратно числу 23");
}
else
    Console.WriteLine("Число А не кратно числу 7");

// Проверка является ли число А квадратом числа Б

int resultA = numberA / numberB;

if (resultA == numberB)
    Console.WriteLine("Число А - квкадрат числа Б");

// Проверка является ли число Б квадратом числа А

int resultB = numberB / numberA;

if (resultB == numberA)
    Console.WriteLine("Число Б - квкадрат числа А");
