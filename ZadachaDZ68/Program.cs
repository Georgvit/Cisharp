/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29 */


// Запрос данных у пользователя
Console.WriteLine("Введите значение аргумента M ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение аргумента N");
int numberN = Convert.ToInt32(Console.ReadLine());

// Вычисление функции Аккермана
int Akkerman(int m, int n){
   
    if (m == 0){
        return n+1;
    } else if(m > 0 & n == 0){
         return Akkerman(m-1,1);
    } else if(m > 0 & n > 0){
        return Akkerman(m-1,Akkerman(m,n-1));
    } else return 0;
    
}

//Вызов функции
Console.WriteLine($"Значение функции Аккермана для данных аргументов: {Akkerman(numberM,numberN)}");