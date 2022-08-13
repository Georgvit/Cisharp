//Пользовательский ввод координат и конвертация в тип int
Console.Clear();

Console.WriteLine("Введите координаты точки А");
Console.WriteLine("Введите X");
int ax = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y");
int ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Z");
int az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки Б");
Console.WriteLine("Введите X");
int bx = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y");
int by = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Z");
int bz = Convert.ToInt32(Console.ReadLine());

// Задаем проекцию точки Б точку С

int cx = bx;
int cy = by;
int cz = az;

//Вычисляем  расстояние между точками А и С

double cat = (ax - cx) * (ax - cx) + (ay - cy) * (ay - cy);

//Вычисляем  расстояние между точками Б и С

double cat1 = (bz - cz) * (bz - cz) + (by - cy) * (by - cy);

//Вычисляем  расстояние между точками А и Б

double gip = cat + cat1;
double result = Math.Sqrt(gip);
result = Math.Round(result, 2);
Console.WriteLine($"{"Расстояние между точками А и Б"}{result}");
