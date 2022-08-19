/* Задача 33: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да */

Console.Clear();

//Создаем массив

int[] arr(int num, int x, int y)
{
   int[] array = new int[num];
   for(int i = 0; i < num; i++)
   {
      array[i] = new Random().Next(x,y + 1);
   }
   return array;
}

//Метод анализа соответствия

void SeachNum (int[] arr, int a) {

    bool label = false;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == a)
        label = true;
        
    }

    if (label)
    Console.WriteLine("Да");
    else
    Console.WriteLine("Нет");



}

//Задаем параметры массива кол-во и диапазон
int[] arra33 = arr(5, -9, 9);

//Выводим массив в виде строки

Console.WriteLine(string.Join(" ", arra33));

//Запускаем функцию сравнения

SeachNum(arra33, 3);


