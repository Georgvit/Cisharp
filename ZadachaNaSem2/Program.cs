Console.Clear();
int num = new Random().Next(100, 1000);

Console.WriteLine(num);

//Вычисляем первую и третью цифру трехзначного числа

int a = num / 100;
int b = num % 10;

//Выводим пезультат последовательно

//Console.WriteLine(a +""+ b);
Console.WriteLine($"{a}{b}");

//Второй вариант решения

int c = num / 100 * 10 + num % 10;
Console.WriteLine(c);
