
//Метод создания массива с пользовательским вводом элементов
void Array(string[] massif)
{
    for (int countElement = 0; countElement < massif.Length; countElement++)
    {
        Console.WriteLine("Введите элеммент массива:");
        massif[countElement] = Console.ReadLine();

    }


}

//Метод создания нового строкового массива с заданной длиной элемента 
void CreatingNewArray(string[] massif)
{
    Console.WriteLine("Введите количество элемментов в строке для формирования нового массива:");
    int lengthString = Convert.ToInt32(Console.ReadLine());

    //Новый массив
    string[] newMassif = new string[massif.Length];

    //Счетчик элементов в новом массиве
    int countNewMassif = 0;

    //Перебор оригинального массива, и присвоение выбранных элемнтов новому массиву
    for (int countMassif = 0; countMassif < massif.Length; countMassif++)
    {

        if (massif[countMassif].Length <= lengthString)
        {
            newMassif[countNewMassif] = massif[countMassif];
            countNewMassif++;

        }


    }

    //Вывод  сформированного массива
    Console.WriteLine("\nНовый массив");
    Console.WriteLine(string.Join(" ", newMassif));
}


//Запуск методов с заданным пользователем количеством элементов в массиве
Console.WriteLine("Введите количество элемментов в массиве:");
int lengthMassif = Convert.ToInt32(Console.ReadLine());
string[] arr = new string[lengthMassif];

Array(arr);
CreatingNewArray(arr);
