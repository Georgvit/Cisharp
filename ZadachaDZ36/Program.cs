/* Задача 36: Задайте одномерный массив,
заполненный случайными числами. Найдите сумму элементов,
стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

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

/*Метод сложения элементов по условию четных, но так как нумерация идет 
с 0, то складываем нечетные*/


void SumNumber(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            sum = sum + array[i];
    }

    Console.WriteLine(sum);
}

//Задаем параметры массива кол-во и диапазон
int[] newArray = array(7, 0, 2);

//Выводим массив в виде строки

Console.WriteLine(string.Join(" ", newArray));

//Запускаем функцию

SumNumber(newArray);
