/* Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы 
двух других сторон */

Console.WriteLine("Введите длины сторон треугольника");
Console.WriteLine("Введите число 1");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 3");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 + num2 > num3 & num2 + num3 > num1 & num1 + num3 > num2 & num1 > 0 & num2 >0 & num3>0) {
    Console.WriteLine("Треугольник существует");
}
else
Console.WriteLine("Треугольник не существует");