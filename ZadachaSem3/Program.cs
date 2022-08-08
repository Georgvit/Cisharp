//Пользовательский ввод чисела и конвертация в тип int
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

//Проверка на четность
int result = number % 2;

if (result == 0)
{
    Console.WriteLine("Введено четное число");
}
else
    Console.WriteLine("Введено нечетное число");
