/* 
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
 */

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

//Метод умножения элементов

void Multnum (int[] arr) {

    int mult =0;

for (int i = 0; i < arr.Length/2; i++)
{
    
mult = arr[i]*arr[arr.Length-1-i];

Console.WriteLine(mult); 
    
}

if (arr.Length % 2 == 1) 
Console.WriteLine(arr[arr.Length/2]); 


}

//Задаем параметры массива кол-во и диапазон
int[] arra33 = arr(7, 0, 10);

//Выводим массив в виде строки

Console.WriteLine(string.Join(" ", arra33));

//Запускаем функцию 

Multnum(arra33);