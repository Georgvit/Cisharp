//Пользовательский ввод номера четверти и конвертация в тип int
Console.Clear();

Console.WriteLine("Введите номер четверти координатной сетки");
int number = Convert.ToInt32(Console.ReadLine());

//Вычисляем диапазон по номеру плоскости координатной сетки

if (number == 1)
    Console.WriteLine("Допустимый диапазон от 0 до X и от 0 до Y");
else if (number == 2)
    Console.WriteLine("Допустимый диапазон от 0 до -X и от 0 до Y");
else if (number == 3)
    Console.WriteLine("Допустимый диапазон от 0 до -X и от 0 до -Y");
else if (number == 4)
    Console.WriteLine("Допустимый диапазон от 0 до X и от 0 до -Y");
else
    Console.WriteLine("Нет такой плоскости");
