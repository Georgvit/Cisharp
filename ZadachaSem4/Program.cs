//Пользовательский ввод чисела и конвертация в тип int
Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());

int numberStart = 2;

//Цикл вывода четных чисел от 0 до N

Console.WriteLine("Четные чисела от 0 до N: ");

while (numberStart < numberN)
{
        Console.WriteLine(numberStart);
    numberStart = numberStart + 2;
}

