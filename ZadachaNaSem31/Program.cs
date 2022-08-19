/* Демонстрация решения
Задача 31: Задайте массив из 12 элементов, заполненный случайными
 числами из промежутка [-9, 9]. Найдите сумму отрицательных и
  положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
положительных чисел равна 29, сумма отрицательных равна -20.
 */

Console.Clear();

int[] arrayRandom = new int[12];

for (int i =0; i < arrayRandom.Length; i++){
    arrayRandom[i] = new Random().Next(-9, 10);
    Console.WriteLine(arrayRandom[i]);
}

int sumPositive = 0;
int sumNegative = 0;

for (int i = 0; i < arrayRandom.Length; i++) {
    if (arrayRandom[i] >= 0)
    sumPositive +=arrayRandom[i];
    else
    sumNegative +=arrayRandom[i];
}

Console.WriteLine($"Сумма положительных {sumPositive}");
Console.WriteLine($"Сумма отрицательных {sumNegative}");