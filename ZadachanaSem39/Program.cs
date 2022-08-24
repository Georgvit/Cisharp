/* Задача 39: Напишите программу, которая перевернёт одномерный массив
 (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] */

int num = new Random().Next(4, 10);

int[] arr = new int[num];

for (int i = 0; i < num; i++)
    {
        arr[i] = new Random().Next(0, 10);
    }

Console.WriteLine(string.Join(" ", arr));

// int[] arr2 = new int[num];

// for (int i = 0; i < num; i++)
//     {
//         arr2[i] = arr[num-1-i];
//     } 

// Console.WriteLine(string.Join(" ", arr2));

// for (int i = 0; i < num; i++)
//     {
//         arr[i] = arr2[i];
//     } 

// Console.WriteLine(string.Join(" ", arr));

for (int i = 0; i < num / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[num - 1 -i];
        arr[num - 1 -i] = temp;
    } 
Console.WriteLine(string.Join(" ", arr));
