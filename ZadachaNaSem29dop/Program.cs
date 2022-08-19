// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
string str1 = "Hello";
string str2 = "World!";
string str3 = str1 + ", " + str2;

string str4  = string.Concat(str1, str2, " ####");

Console.WriteLine(str3);
Console.WriteLine(str4);

int[] values = new int[] {1, 2, 3, 4, 5, 6};

string str5 = string.Join("*", values);

Console.WriteLine(str5);