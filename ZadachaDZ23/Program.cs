//Пользовательский ввод числа N и конвертация в тип int
Console.Clear();

Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());

//Вычисляем куб числа в диапазона чисел от 0 до N

int cicle = 1;

while (cicle <= number)
{
    double result = Math.Pow(cicle, 3);
    cicle++;
    Console.WriteLine(result);
}