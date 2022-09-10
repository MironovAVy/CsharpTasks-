//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int Prompt(string messege)
{
    System.Console.WriteLine(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int Value = Prompt("Введите  число");
void second()
{
int p = Value;
if (p > 5 && p < 7)
{
    System.Console.WriteLine($"Ваше число {p} - выходной");
}
if (p > 0 && p <= 5)
{
    System.Console.WriteLine($"Ваше число {p} - будний день");
} 
else
{
    System.Console.WriteLine($"{p} -такого дня недели не существует ");
}
}
second();