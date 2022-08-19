/* Задача 34: Задайте массив заполненный случайными
 положительными трёхзначными числами. Напишите программу, 
 которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

Console.Clear();

//Создаем массив

int[] array(int num, int x, int y)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = new Random().Next(x, y + 1);
    }
    return arr;
}

//Вычисляем четные числа


void EvenNumber(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 1)
            count++;
    }

    Console.WriteLine(count);
}

//Задаем параметры массива кол-во и диапазон
int[] newArray = array(5, 100, 999);

//Выводим массив в виде строки

Console.WriteLine(string.Join(" ", newArray));

//Запускаем функцию

EvenNumber(newArray);
