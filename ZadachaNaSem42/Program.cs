/* Задача 42: Напишите программу, которая будет преобразовывать
 десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
 */


 Console.WriteLine("Введите десятичное число");

int num1 = Convert.ToInt32(Console.ReadLine());
int length = 0;
int num2 = num1;
while (num2 > 0) {
    num2 = num2/2;
    length++;
}

//Console.WriteLine(length);

int[] arr = new int[length];

for (int i = 0; i < length; i++)
{
    arr[length - 1 -i] = num1 % 2;
		num1 = num1 / 2;
      // Console.WriteLine(num1);
}
    



Console.WriteLine($"Число в двоичной системе: {string.Join(" ", arr)}");

