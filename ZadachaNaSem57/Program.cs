/* Задача 57: Составить частотный словарь элементов двумерного массива.
 Частотный словарь содержит информацию о том, сколько раз встречается 
 элемент входных данных.

 */

//Метод создания массива
void Massif(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}
// Подсчет количества повторяющихся элементов
void count(int[,] array)
{
    //Путем перебора и присваивания значения временной переменной с ее последующим прогоном по циклу
    // подсчитываем количество одинаковых елементов в массиве

    for (int l = 0; l < array.GetLength(0); l++)
    {

        for (int n = 0; n < array.GetLength(1); n++)
        {
            int x = array[l, n];
            int sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (x == array[i, j])
                    {
                        sum++;

                    }
                }

            }

            //Фильтруем вывод от повторений
           

            if (array[l, n] != 0) Console.WriteLine($"Элемент {array[l, n]} встречается {sum} раз(а)");
           

            int test = 0;
            test = array[l, n];
            for (int t = 0; t < array.GetLength(0); t++)
            {
                for (int r = 0; r < array.GetLength(0); r++)
                {
                    if (test == array[t, r])
                        array[t, r] = 0;
                }
            }

        }

    }
}


int[,] arr = new int[4, 4];
Massif(arr);
count(arr);