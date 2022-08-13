//Пользовательский ввод координат и конвертация в тип int
Console.Clear();

Console.WriteLine("Введите координаты плоскости");
Console.WriteLine("Введите X");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y");
int y = Convert.ToInt32(Console.ReadLine());

//Вычисляем номер плоскости координатной сетки

if (x > 0 & y > 0)
    Console.WriteLine("Номер плоскости координатной сетки - 1");
else if (x < 0 & y > 0)
    Console.WriteLine("Номер плоскости координатной сетки - 2");
else if (x < 0 & y < 0)
    Console.WriteLine("Номер плоскости координатной сетки - 3");
else if (x > 0 & y < 0)
    Console.WriteLine("Номер плоскости координатной сетки - 4");
else
    Console.WriteLine("Координаты 0-0");
