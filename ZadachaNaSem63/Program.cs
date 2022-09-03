// See https://aka.ms/new-console-template for more information


Console.WriteLine("Введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());




int Natural (int numberOne, int numberTwo){

        if (numberTwo <= numberOne){
        
        Console.Write($" {numberTwo} ");
        
       numberTwo++;
    } else {Environment.Exit(0);}
    return numberTwo = numberTwo + Natural(numberOne, numberTwo);
    
    
}

Natural(numberN, numberM );