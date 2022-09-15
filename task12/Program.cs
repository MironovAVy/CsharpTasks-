// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Prompt(string messege)
{
    System.Console.WriteLine(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int a = Prompt("Введите a");
int b = Prompt("Введите b");

while ( b != 0)
{
    Console.WriteLine($"{a},{b} >" + Math.Pow(a, b));
    break;
}
if (  b == 0) 
{
    Console.WriteLine($"{a},{b} > 1" );
}
