// See https://aka.ms/new-console-template for more information
Console.Clear();
int num = new Random().Next(10, 100);

Console.WriteLine(num);

int a = num / 10;
int b = num % 10;

int max = a;
if (max < b)
{
    max = b;
}
Console.WriteLine(max);