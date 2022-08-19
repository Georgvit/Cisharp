/* Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

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

//Вычисляем разницу мин и макс значений массива


void EvenNumber(int[] array)
{
    int max = 0;
    int min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        else if (array[i] < min)
            min = array[i];
    }

    int sum = max - min;

    Console.WriteLine(sum);
}

//Задаем параметры массива кол-во и диапазон
int[] newArray = array(15, 1, 100);

//Выводим массив в виде строки

Console.WriteLine(string.Join(" ", newArray));

//Запускаем функцию

EvenNumber(newArray);
