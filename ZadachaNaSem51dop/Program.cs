/* И дам задачку, но она требует время для решения 😊
Так как если решать её "в лоб", то может завистнуть ПК,
так как слишком много итераций будет.
Надо подумать, как оптимизировать 😊
Необходимо найти 5 целых чисел (положительных),
 которые будут удовлетворять такому условию x^5 + y^5 + z^5 + q^5 = w^5 Т.е. сумма 4 чисел в пятой степени = 5 числу */

//Числа заданны с путем деления интервала поиска пополам это сократило время работы программы до 19сек.
//Если задать все значения 1 то время работы 51 сек.

double x = 3;
double y;
double z;
double q;
double w;

while (x < 150)
{
    x++;
    y = 7;

    double degreeOfNumberX = x * x * x * x * x;

    while (y < 150)
    {
        y++;
        z = 15;
        double degreeOfNumberY = y * y * y * y * y;

        while (z < 150)
        {
            z++;
            q = 35;
            double degreeOfNumberZ = z * z * z * z * z;

            while (q < 150)
            {
                q++;
                w = 70;
                double degreeOfNumberQ = q * q * q * q * q;

                while (w < 150)
                {
                    w++;
                    double degreeOfNumberW = w * w * w * w * w;

                    //Проверка условия задачи
                    if (
                        degreeOfNumberX + degreeOfNumberY + degreeOfNumberZ + degreeOfNumberQ
                        == degreeOfNumberW
                    )
                    {
                        Console.WriteLine($"Равенство верно");
                        Console.WriteLine($"x({x} + y({y}) + z({z}) + q({q}) = w({w})");

                        //Так как все варианты идентичны то прерываем программу на первом совпадении
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
