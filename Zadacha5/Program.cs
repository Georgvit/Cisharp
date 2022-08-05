// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ввыдите число");

int num = Convert.ToInt32(Console.ReadLine());

int num2 = -num;

Console.WriteLine("Результат: ");

if (num<0) {
    while (num<=num2){
        Console.WriteLine(num);
        num++;

    }
}
else {
     while (num2<=num) {
        Console.WriteLine(num2);
        num2++;

    }
}