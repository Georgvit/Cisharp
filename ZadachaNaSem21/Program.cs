//Пользовательский ввод координат и конвертация в тип int
Console.Clear();

Console.WriteLine("Введите координаты точки А");
Console.WriteLine("Введите X");
int ax = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y");
int ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки Б");
Console.WriteLine("Введите X");
int bx = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y");
int by = Convert.ToInt32(Console.ReadLine());

//Вычисляем  расстояние между точками

double cat = (ax - bx) * (ax - bx) + (ay - by) * (ay - by);
double result = Math.Sqrt(cat);
result = Math.Round(result, 2);
Console.WriteLine($"{"Расстояние между точками "}{result}");
