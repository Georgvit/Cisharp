//Пользовательский ввод чисела и конвертация в тип int
Console.Clear();

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

//Вычисляем вторую цифру трехзначного числа

int result = number / 10 % 10;
Console.WriteLine(result);
