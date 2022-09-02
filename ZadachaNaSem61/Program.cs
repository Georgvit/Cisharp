/* Задача 61: Вывести первые N строк треугольника Паскаля. 
Сделать вывод в виде равнобедренного треугольника
 */

/* 
//Создаем метом создания массива треугольника Паскаля
void TriaglePascal(int[,] array)
{
    //Первый столбец присваиваем единицы
    for (int line = 0; line < array.GetLength(0); line++)
    {
        array[line, 0] = 1;
        array[line, line] = 1;

        //Заполняем массвив согластно формуле Паскаля нижний элемент равен сумме двух верхних
        for (int line2 = 2; line2 < array.GetLength(0); line2++)
        {

            for (int column = 1; column <= line2; column++)

            {
                array[line2, column] = array[line2 - 1, column - 1] + array[line2 - 1, column];

            }

        }
    }

    //Константа для отступа между элементами
    const int indent = 4;

    //Переменная для позиционирования курсора
    int positionNew = indent * array.GetLength(0);

    //Цикл вывода элементов матрицы
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.SetCursorPosition(positionNew, i + 1);

            if (array[i, j] != 0)
            {
                Console.Write($"{array[i, j],indent}");
                //Console.Write($"*");

            }
            positionNew = positionNew + indent * 2;

        }
        positionNew = indent * array.GetLength(0) - indent * (i + 1);
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] arr = new int[10, 10];
TriaglePascal(arr);  */



//Вариант 2
//Количетсва строк треугольника Паскаля
int quantityLine = 9;
//Константа для отступа между элементами
const int indent = 4;
//Переменная для позиционирования курсора
int positionNew = quantityLine * indent;

//Цикл создания треугольника
for (int line = 0; line <= quantityLine; line++)
{
    int firstNumber = 1;
    for (int column = 1; column <= line; column++)
    {
        Console.SetCursorPosition(positionNew, line + 1);
        Console.Write($"{firstNumber,indent}");
        
        //Формула нахождения последующего элемента
        firstNumber = firstNumber * (line - column) / column;

        //Двигаем курсор вправо
        positionNew = positionNew + indent * 2;

    }
    //Двигаем курсор в лево
    positionNew = indent * quantityLine - indent * (line + 1);
    Console.WriteLine();
}
Console.WriteLine();
 