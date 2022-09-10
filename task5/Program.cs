//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Prompt(string messege)
{
    System.Console.WriteLine(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int Value = Prompt("Введите трех значное число");
void second()
{
int p = Value;
int a = p%10;
int b = p%100;
if (p > 99 && p < 1000)
{
    System.Console.WriteLine($"Ваше число ={p}");
    System.Console.WriteLine($"Второе число равно = {(b-a)/10}");
}
else
{
    System.Console.WriteLine($"Ваше число - не трехзначное");
} 
}
second();