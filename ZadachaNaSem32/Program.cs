/* Задача 32: Напишите программу замена элементов массива:
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
 */

/* 
 int[] arr(int num, int x, int y)
{
   int[] array = new int[num];
   for(int i = 0; i < num; i++)
   {
      array[i] = new Random().Next(x,y + 1);
   }
   return array;
} */


Console.Clear();
//Создаем массив

int[] arrayRandom = new int[12];

for (int i = 0; i < arrayRandom.Length; i++)
{
    arrayRandom[i] = new Random().Next(-9, 10);

    Console.Write($"{arrayRandom[i]} ");
}

Console.WriteLine();

//Ивертируем и выводим массив

for (int i = 0; i < arrayRandom.Length; i++)
{
    arrayRandom[i] = arrayRandom[i] * (-1);
    Console.Write($"{arrayRandom[i]} ");
}
